using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using PenaltySharp.View;
using System.Windows.Forms;
using System.IO;
using PenaltySharp.DAL;

namespace PenaltySharp.Controller
{
    [Serializable]
    class SpelareController
    {


        private List<Spelare> m_Spelare;
        public string publicanvändarnamn;
        public int publicID;
        public SpelareController()
        {
            m_Spelare = new List<Spelare>();
            //TestData();
            try
            {
                if (File.Exists("SpelareLista.DAT"))
                {
                    m_Spelare = BinarySerialization<List<Spelare>>.BinaryDeSerialize("SpelareLista.DAT");
        }

            }
            catch (Exception ex)
            {

                throw new Exception("Den kunde inte ladda från spelare listan." + ex.Message);// CustomException(ex.Message);
            }
        }

        public void LäggaTill(Spelare item)
        {
            m_Spelare.Add(item);
            ServiceProvider.GetSpelareService().BinarySerialize();
            
        }
        public void TaBort(Spelare item)
        {
            m_Spelare.Remove(item);
        }

        public Spelare Get(int index)
        {
            return m_Spelare.ElementAt(index);
        }

        public int Antal()
        {
            return m_Spelare.Count();
        }

        public String GetAnvändarnamn(int index)
        {
            return m_Spelare[index].getAnvändarnamn();
        }
        public int GetIndexOfNamn(string Namn)
        {
            for (int i = 0; i < m_Spelare.Count; i++)
            {
                if (m_Spelare[i].getNamn() == Namn)
                {
                    return i;
                }
            }
            return -1;
        }
        public string GetNamnOfIndex(int Index)
        {
            return m_Spelare[Index].getNamn();
        }
        public string GetAnvändarNamnOfIndex(int Index)
        {
            return m_Spelare[Index].getAnvändarnamn();
        }
        public bool GetAdminStatusOfIndex(int Index)
        {
            return m_Spelare[Index].getAdmin();
        }
        public void TestData() //skapar default spelarna
        {
            Spelare
            spelare = new Spelare("Felix Kujanpää", 0, "kujfel", "felkuj", true);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Aderian Jakobsen", 1, "jakade", "adejak", false);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Jarl Ballheden", 2, "baljar", "jarbal", true);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Inos Leran", 3, "lerino", "inoler", false);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Smartin Smartlund", 4, "smasma", "smasma", true);
            m_Spelare.Add(spelare);
            spelare = new Spelare("1", 5, "1", "1", false);
            m_Spelare.Add(spelare);
        }

        /// <summary>
        /// Hur inloggningen fungerar
        /// </summary>
        /// <param name="Användarnamn"></param>
        /// <param name="Lösenord"></param>
        /// <returns></returns>
        public string LoggaIn(string Användarnamn, string Lösenord)
        {
            for (int i = 0; i < Antal(); i++)
            {
                if (Användarnamn == m_Spelare[i].getAnvändarnamn() && Lösenord == m_Spelare[i].getLösenord())
                {
                    publicanvändarnamn = Användarnamn;
                    publicID = m_Spelare[i].getId();
                    var adminsidaForm = new AdminSida();
                    var inloggningsForm = new Inloggning();
                    var användarsidaForm = new Användarsida();

                    if (m_Spelare[i].getAdmin() == true) //om man är admin
                    {
                        adminsidaForm.Show();
                        inloggningsForm.Hide();                       
                    }

                    else //eller om man är en vanlig användare
                    {
                        användarsidaForm.Show();
                        inloggningsForm.Hide();
                    }
                    
                    return Användarnamn;
                }
                else //om det inte finns ett matchande användarman med lösenord kommer ett felmeddelande fram
                {
                    if (i == Antal() - 1)
                    {
                        MessageBox.Show("Fel användarnamn eller lösenord");
                    }
                }
            }

            return "Fel användarnamn eller lösenord.";
        }

        public string SkapaAnvändare(string Förnamn, string efternamn, string Användarnamn, string Lösenord, string Lösenord2, string Email)
        {
            
             //kollar om det finns samma användarnamn redan finns
            for (int i = 0; i < Antal() ; i++)
            {
                if (Användarnamn == m_Spelare[i].getAnvändarnamn())
                {
                    return "Användarnamn upptaget";
                }
            }

            if (Lösenord == Lösenord2) // lösenorden är lika?
            {
                Spelare spelare = new Spelare(Förnamn + " " + efternamn, Antal() + 1, Användarnamn, Lösenord, false);
                this.LäggaTill(spelare);
            }
            else
            {
                return "lösenordet fel";
            }
            

            return "Ny användare skapad";
        }
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Spelare>>.FileName = "SpelareLista.DAT";
                BinarySerialization<List<Spelare>>.BinarySerialize(m_Spelare);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); //CustomException(ex.Message);
            }

            return true;
        }
    }
}


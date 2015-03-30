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
        /// <summary>
        /// Kollar om listan existerar och upptaterar listan efter filen.
        /// </summary>
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
        /// <summary>
        /// Lägger till ett objekt i listan spelare.
        /// </summary>
        /// <param name="item">En spelare</param>
        public void LäggaTill(Spelare item)
        {
            m_Spelare.Add(item);
            ServiceProvider.GetSpelareService().BinarySerialize();
            
        }

        /// <summary>
        /// Tar bort ett objekt ur listan spelare.
        /// </summary>
        /// <param name="item">En spelare</param>
        public void TaBort(Spelare item)
        {
            m_Spelare.Remove(item);
        }
        public void TaBortVid(int ID)
        {
            m_Spelare.RemoveAt(ID);
        }

        /// <summary>
        /// Tar fram ett spelareindex
        /// </summary>
        /// <param name="index">Spelareindex</param>
        /// <returns>Specifikt index</returns>
        public Spelare Get(int index)
        {
            return m_Spelare.ElementAt(index);
        }

        /// <summary>
        /// Beräknar antalet objekt i listan spelare.
        /// </summary>
        /// <returns>Antalet objekt i listan spelare.</returns>
        public int Antal()
        {
            return m_Spelare.Count();
        }

        /// <summary>
        /// Tar fram ett användarnamn för en specifik spelare med ett visst index.
        /// </summary>
        /// <param name="index">Spelareindex</param>
        /// <returns>Spelarens användarnamn</returns>
        public String GetAnvändarnamn(int index)
        {
            return m_Spelare[index].getAnvändarnamn();
        }

        /// <summary>
        /// Tar fram ett index tillhörande en spelares namn.
        /// </summary>
        /// <param name="Namn">En spelares namn</param>
        /// <returns>Spelarens index</returns>
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
        /// <summary>
        /// Tar fram en spelares namn med hjälp av ett specifikt index.
        /// </summary>
        /// <param name="index">Spelareindex</param>
        /// <returns>Spelarens namn</returns>
        public string GetNamnOfIndex(int index)
        {
            return m_Spelare[index].getNamn();
        }

        /// <summary>
        /// Tar fram ett användarnamn med hjälp av en spelares index.
        /// </summary>
        /// <param name="Index">En spelares index</param>
        /// <returns>En spelares användarnamn.</returns>
        public string GetAnvändarNamnOfIndex(int Index)
        {
            return m_Spelare[Index].getAnvändarnamn();
        }
        /// <summary>
        /// Kollar om en spelare är admin eller inte utifrån ett index.
        /// </summary>
        /// <param name="Index">En spelares index</param>
        /// <returns>Om en spelare är admin eller inte.</returns>
        public bool GetAdminStatusOfIndex(int Index)
        {
            return m_Spelare[Index].getAdmin();
        }

        /// <summary>
        /// Lista med grundspelare för att ha en bas till projektet.
        /// </summary>
        public void TestData() 
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
        /// Loggar in samt kollar om man är admin eller inte.
        /// Om användarnamnet och lösenordet som skrivs in tillhör samma index godkänns inloggningen.
        /// </summary>
        /// <param name="Användarnamn">En spelares användarnamn från listan m_Spelare</param>
        /// <param name="Lösenord">En spelares lösenord från listan m_Spelare</param>
        /// <returns>Vid felinloggningen: felmeddelande. Vid godkänd inloggning: Användarnamnet på spelaren som loggats in.</returns>
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

        /// <summary>
        /// Kollar om användarnamn är upptaget vid regristrering.
        /// Kollar om man fyllt i samma lösenord två gånger vid regristrering.
        /// Om lösenorden stämmer och användarnamnet inte är upptaget läggs en ny spelare till med namn, efternamn och email.
        /// Lägger till en spelare i filsparningen.
        /// </summary>
        /// <param name="Förnamn">Spelarens förnamn</param>
        /// <param name="efternamn">Spelarens efternamn</param>
        /// <param name="Användarnamn">Spelarens användarnamn</param>
        /// <param name="Lösenord">Spelarens lösenord</param>
        /// <param name="Lösenord2">Spelarens lösenord</param>
        /// <param name="Email">Spelarens email</param>
        /// <returns></returns>
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

        /// <summary>
        /// Sparar ner spelare som en fil.
        /// </summary>
        /// <returns>Att sparningen lyckades.</returns>
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


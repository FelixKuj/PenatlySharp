using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using PenaltySharp.View;

namespace PenaltySharp.Controller
{
    [Serializable]
    class SpelareController
    {


        private List<Spelare> m_Spelare;

        public SpelareController()
        {
            m_Spelare = new List<Spelare>();
            TestData();
        }

        public void LäggaTill(Spelare item)
        {
            m_Spelare.Add(item);
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
        public void TestData()
        {
            Spelare
            spelare = new Spelare("Felix Kujanpää", 0, "kujfel", "felkuj", true);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Aderian Jakobsen", 1, "jakade", "adejak", false);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Jarl Ballheden", 2, "baljar", "jarbal", true);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Leran Inos", 3, "inoler", "lerino", false);
            m_Spelare.Add(spelare);
            spelare = new Spelare("Smartin Smartlund", 4, "smasma", "smasma", true);
            m_Spelare.Add(spelare);
        }
        public string LoggaIn(string Användarnamn, string Lösenord)
        {
            for (int i = 0; i < Antal(); i++)
            {
                if (Användarnamn == m_Spelare[i].getAnvändarnamn() && Lösenord == m_Spelare[i].getLösenord())
                {
                    var adminsidaForm = new AdminSida();
                    var inloggningsForm = new Inloggning();
                    var användarsidaForm = new Användarsida();

                    if (m_Spelare[i].getAdmin() == true)
                    {
                        adminsidaForm.Show();
                        inloggningsForm.Hide();                       
                    }

                    else
                    {
                        användarsidaForm.Show();
                        inloggningsForm.Hide();
                    }
                    return Användarnamn;
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
                m_Spelare.Add(spelare);
            }
            else
            {
                return "lösenordet fel";
            }
            

            return "Ny användare skapad";
        }
    }
}


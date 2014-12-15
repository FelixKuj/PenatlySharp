using PenaltySharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Controller
{
    class SpelareController
    {
        private List<Spelare> m_Spelare;

        public SpelareController()
        {
            m_Spelare = new List<Spelare>();
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
            spelare = new Spelare("Felix Kujanpää",0,"kujfel","felkuj");
            m_Spelare.Add(spelare);
            spelare = new Spelare("Aderian Jakobsen", 1, "jakade", "adejak");
            m_Spelare.Add(spelare);
            spelare = new Spelare("Jarl Ballheden", 2, "baljar", "jarbal");
            m_Spelare.Add(spelare);
            spelare = new Spelare("Leran Inos", 3, "inoler", "lerino");
            m_Spelare.Add(spelare);
            spelare = new Spelare("Smartin Smartlund", 4, "smasma", "smasma");
            m_Spelare.Add(spelare);
        }
        public string LoggaIn(string Användarnamn, string Lösenord)
        {
            return "AS";
        }
    }
}


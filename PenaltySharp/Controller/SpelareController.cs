using PenaltySharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Controler
{
    class SpelareController
    {
        private List<Spelare> m_Spelare;

        public SpelareController()
        {
            m_Spelare = new List<Spelare>();
        }

        public void Läggatill(Spelare item)
        {
            m_Spelare.Add(item);
        }
        public void Tabort(Spelare item)
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
    }
}


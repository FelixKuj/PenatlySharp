using PenaltySharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Controller
{
    class RegelController
    {
        private List<Regler> m_Regler;

        public RegelController()
        {
            m_Regler = new List<Regler>();
        }

        public void Add(Regler item)
        {
            m_Regler.Add(item);
        }

        public void Remove(Regler item)
        {
            m_Regler.Remove(item);
        }

        public Regler Get(int index)
        {
            return m_Regler.ElementAt(index);
        }

        public int Count()
        {
            return m_Regler.Count();
        }

        public int GetIndexOfRegel(string regel)
        {
            for (int i = 0; i < m_Regler.Count; i++)
            {
                if (m_Regler[i].getNamn() == regel)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

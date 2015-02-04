using PenaltySharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Controller;
using PenaltySharp.View;
using System.Windows.Forms;

namespace PenaltySharp.Controller
{
    class RegelController
    {
        ReglerSida regelsida;
        private List<Regler> m_Regler;

        public RegelController()
        {
            m_Regler = new List<Regler>();
            TestData();
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

        public void TestData()
        {
            Regler
            regel = new Regler("Sen ankomst till träning", 0, 50);
            m_Regler.Add(regel);
            regel = new Regler("Sen ankomst till match", 1, 100);
            m_Regler.Add(regel);
            regel = new Regler("Mobil som ringer under samling/genomgång", 2, 50);
            m_Regler.Add(regel);
            regel = new Regler("Glömd utrustning till bortamatch", 3, 100);
            m_Regler.Add(regel);
            regel = new Regler("Oreda på platsen", 4, 50);
            m_Regler.Add(regel);
            regel = new Regler("10 min misconduct", 5, 100);
            m_Regler.Add(regel);
            regel = new Regler("Matchstraff för snack", 6, 200);
            m_Regler.Add(regel);
            regel = new Regler("Hångel på lokal", 7, 50);
            m_Regler.Add(regel);
            regel = new Regler("Ta över någons ex", 8, 300);
            m_Regler.Add(regel);
            regel = new Regler("Avslagen klubba", 9, 500);
            m_Regler.Add(regel);
            regel = new Regler("Bild i tidningen", 10, 20);
            m_Regler.Add(regel);
            regel = new Regler("Ramla på matchuppvärmning", 11, 20);
            m_Regler.Add(regel);


        }
        public void VisaRegler()
        {
            string visaregler = "Regler" + System.Environment.NewLine;
            string visaböter = System.Environment.NewLine;
            for (int regelnr = 0; regelnr < m_Regler.Count; regelnr++)
            {
                visaregler += (m_Regler[regelnr].getId() + 1).ToString() + ".  " + m_Regler[regelnr].getNamn().ToString() + System.Environment.NewLine;
                visaböter += m_Regler[regelnr].getBöter().ToString() + "kr" + System.Environment.NewLine;
            }
            regelsida = new ReglerSida();
            regelsida.tbx_ReglerSida_Regel.Text = visaregler;
            regelsida.tbx_ReglerSida_Böter.Text = visaböter;
            regelsida.Show();
        }
    }
}

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
    [Serializable]
    class RegelController
    {
        int id = 0;
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
            regel = new Regler("Sen ankomst till träning", id, 50);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Sen ankomst till match", id, 100);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Mobil som ringer under samling/genomgång", id, 50);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Glömd utrustning till bortamatch", id, 100);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Oreda på platsen", id, 50);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("10 min misconduct", id, 100);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Matchstraff för snack", id, 200);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Hångel på lokal", id, 50);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Ta över någons ex", id, 300);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Avslagen klubba", id, 500);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Bild i tidningen", id, 20);
            m_Regler.Add(regel);
            id++;
            regel = new Regler("Ramla på matchuppvärmning", id, 20);
            m_Regler.Add(regel);

            //if (regelsida.skaparegel == true)
            //{
            //    id++;
            //    regel = new Regler(regelsida.tbx_ReglerSida_Regel.Text, id, Convert.ToInt32(regelsida.tbx_ReglerSida_Böter));
            //    m_Regler.Add(regel);
            //    regelsida.skaparegel = false;

            }
        }

    }




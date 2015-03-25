using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using PenaltySharp.View;
using System.Windows.Forms;

namespace PenaltySharp.Controller
{
    class BöterController
    {
        int id = 0;
        private List<Böter> m_böter;

          public BöterController()
        {
            m_böter = new List<Böter>();
            testData();
        }
        /// <summary>
        /// Lägger till objekt i listan Böter
        /// </summary>
        /// <param name="item"></param>
        public void Add(Böter item)
        {
            m_böter.Add(item);
        }

        /// <summary>
        /// Tar bort objekt från listan Böter
        /// </summary>
        /// <param name="item"></param>
        public void Remove(Böter item)
        {
            m_böter.Remove(item);
        }

        /// <summary>
        /// Tar bort ett specifikt objekt efter index i listan Böter.
        /// </summary>
        /// <param name="i"></param>
        public void RemoveAt(int i)
        {
            m_böter.RemoveAt(i);
        }

        /// <summary>
        /// Letar reda på specifik böters index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Böter Get(int index)
        {
            return m_böter.ElementAt(index);
        }

        /// <summary>
        /// Antalet obkejt i listan Böter.
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return m_böter.Count();
        }
       
        public int GetIndexOfBöter(int böter)
        {
            for (int i = 0; i < m_böter.Count; i++)
            {
                if (m_böter[i].getBöterId() == böter)
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// Lista med grunböter för att skapa en bas i projektet.
        /// </summary>
        public void testData()
        {
            Böter
            böter = new Böter(1, 2);
            m_böter.Add(böter);
            id++;
            böter = new Böter(2,5);
            m_böter.Add(böter);
            id++;
            böter = new Böter(3,6);
            m_böter.Add(böter);
            id++;
            böter = new Böter(2,10);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4,8);
            m_böter.Add(böter);
            id++;
            böter = new Böter(2,8);
            m_böter.Add(böter);
            id++;
            böter = new Böter(5,7);
            m_böter.Add(böter);
            id++;
            böter = new Böter(1,4);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4,8); //Vilken lirare asså//
            m_böter.Add(böter);
            id++;
            böter = new Böter(4,8);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4,8);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4,8);
            m_böter.Add(böter);
            id++;
        }
    }
}

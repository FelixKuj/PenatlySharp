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
using System.IO;
using PenaltySharp.DAL;

namespace PenaltySharp.Controller
{
    [Serializable]
    class BöterController
    {
        int id = 0;
        private List<Böter> m_böter;
        int antal = 0;

        /// <summary>
        /// Samlade metoder för att hantera böter i applikationen.
        /// </summary>
          public BöterController()
        {
            m_böter = new List<Böter>();
            testData();
            try
            {
                if (File.Exists("BöterLista.DAT"))
                {
                    m_böter = BinarySerialization<List<Böter>>.BinaryDeSerialize("BöterLista.DAT");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Den kunde inte ladda från Böter listan." + ex.Message);// CustomException(ex.Message);
            }
        }
        /// <summary>
        /// Lägger till objekt i listan Böter
        /// </summary>
        /// <param name="item">Böter</param>
        public void Add(Böter item)
        {
            m_böter.Add(item);
           // ServiceProvider.GetBöterService().BinarySerialize();
        }

        /// <summary>
        /// Tar bort objekt från listan Böter
        /// </summary>
        /// <param name="item">Böter</param>
        public void Remove(Böter item)
        {
            m_böter.Remove(item);
        }

        /// <summary>
        /// Tar bort ett specifikt objekt efter index i listan Böter.
        /// </summary>
        /// <param name="i">Böterindex</param>
        public void RemoveAt(int i)
        {
            m_böter.RemoveAt(i);
        }

        /// <summary>
        /// Letar reda på specifik böters index.
        /// </summary>
        /// <param name="index">Böterindex</param>
        /// <returns>Specifikt Index</returns>
        public Böter Get(int index)
        {
            return m_böter.ElementAt(index);
        }

        /// <summary>
        /// Antalet objekt i listan Böter.
        /// </summary>
        /// <returns>Antalet objekt i listan Böter</returns>
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
        public int GetAntalBöter(int spelarID)
        {
             antal = 0;
            for (int i = 0; i < m_böter.Count; i++)
			{
			 if (m_böter[i].getPersonId() == spelarID)
	            {
		            antal++;
	            }
			}
            return antal;
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
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Böter>>.FileName = "BöterLista.DAT";
                BinarySerialization<List<Böter>>.BinarySerialize(m_böter);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); //CustomException(ex.Message);
            }

            return true;
        }
    }
}

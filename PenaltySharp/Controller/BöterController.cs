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
        /// Samlade metoder för att hantera böter i applikationen. Samt kollar om listan existerar och upptaterar listan efter filen.
        /// </summary>
        public BöterController()
        {
            m_böter = new List<Böter>();
            try
            {
                if (File.Exists(@"..\..\DAL\BöterLista.DAT"))
                {
                    m_böter = BinarySerialization<List<Böter>>.BinaryDeSerialize("BöterLista.DAT");
                }
                else
                {
                    //testData();
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
            ServiceProvider.GetBöterService().BinarySerialize();
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
        /// <summary>
        /// Tar fram ett index till en böter.
        /// </summary>
        /// <param name="böter">Böterns namn</param>
        /// <returns>Böterns index</returns>
        public int GetIndexOfBöter(int böter)
        {
            for (int i = 0; i < m_böter.Count; i++)
            {
                if (m_böter[i].getRegelId() == böter)
                {
                    return i;
                }
            }

            return -1;
        }
        /// <summary>
        /// Tar fram antal böter.
        /// </summary>
        /// <param name="spelarID">En spelares ID</param>
        /// <returns>Antal Böter</returns>
        public int GetAntalObetaldBöter(int spelarID)
        {
            antal = 0;
            for (int i = 0; i < m_böter.Count; i++)
            {
                if (m_böter[i].getPersonId() == spelarID && m_böter[i].getBetald() == false)
                {
                    antal++;
                }
            }
            return antal;
        }

        /// <summary>
        /// Tar fram antal betalda böter.
        /// </summary>
        /// <param name="spelarID"></param>
        /// <returns>Antal betalda böter</returns>
        public int GetAntalBetaldBöter(int spelarID)
        {
            antal = 0;
            for (int i = 0; i < m_böter.Count; i++)
            {
                if (m_böter[i].getPersonId() == spelarID && m_böter[i].getBetald() == true)
                {
                    antal++;
                }
            }
            return antal;
        }

        /// <summary>
        /// Tar fram antal obrutna regler
        /// </summary>
        /// <param name="regelID"></param>
        /// <returns>Antalet obrutna regler</returns>
        public int GetAntalOBrutnaRegler(int regelID)
        {
            antal = 0;
            for (int i = 0; i < m_böter.Count; i++)
            {
                if (m_böter[i].getRegelId() == regelID && m_böter[i].getBetald() == true)
                {
                    antal++;
                }
            }
            return antal;
        }

        /// <summary>
        /// Tar fram antal brutna regler
        /// </summary>
        /// <param name="regelID"></param>
        /// <returns>Antal brutna regler</returns>
        public int GetAntalBrutnaRegler(int regelID)
        {
            antal = 0;
            for (int i = 0; i < m_böter.Count; i++)
            {
                if (m_böter[i].getRegelId() == regelID && m_böter[i].getBetald() == false)
                {
                    antal++;
                }
            }
            return antal;
        }
        /// <summary>
        /// Lägger till en böter till en spelare.
        /// </summary>
        /// <param name="spelare">Spelaren som ska få bötern</param>
        /// <param name="regel">Regeln som bötern ska vara</param>
        public void LäggtillBöter(int spelare, int regel)
        {
            Böter
            böter = new Böter(spelare, regel, false);
            m_böter.Add(böter);
            ServiceProvider.GetBöterService().BinarySerialize();
            //SaveToDBA();
        }

        /// <summary>
        /// Lista med grundböter för att skapa en bas i projektet.
        /// </summary>
        public void testData()
        {
            Böter
            böter = new Böter(1, 2, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(2, 5, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(3, 6, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(2, 10, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4, 8, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(2, 8, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(5, 7, true);
            m_böter.Add(böter);
            id++;
            böter = new Böter(1, 4, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4, 8, false); //Vilken lirare asså//
            m_böter.Add(böter);
            id++;
            böter = new Böter(4, 8, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4, 8, false);
            m_böter.Add(böter);
            id++;
            böter = new Böter(4, 8, false);
            m_böter.Add(böter);
            id++;
        }

        /// <summary>
        /// Sparar böter som en fil.
        /// </summary>
        /// <returns>Om sparningen fungerade</returns>
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
        /// <summary>
        /// Sparar i databasen.
        /// </summary>
        /// <returns></returns>
        public void SaveToDBA()
        {
            DataAccessLayerDBA dba = new DataAccessLayerDBA();
            dba.SaveBöter();

        }

        /// <summary>
        /// Bestämmer om en regel är betald
        /// </summary>
        /// <param name="id"></param>
        /// <param name="betald"></param>
        public void SetBetald(int id, bool betald)
        {
            m_böter[id].setBetald(betald);

        }

    }
}

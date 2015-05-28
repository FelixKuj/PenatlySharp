using PenaltySharp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Controller;
using PenaltySharp.View;
using System.Windows.Forms;
using System.IO;
using PenaltySharp.DAL;

namespace PenaltySharp.Controller
{
    [Serializable]
    class RegelController
    {
        int id = 0;
        private List<Regler> m_Regler;
        /// <summary>
        /// Samlade metoder för att hantera regler i applikationen. Samt kollar om listan existerar och upptaterar listan efter filen.
        /// </summary>
        public RegelController()
        {
            m_Regler = new List<Regler>();
            
            try
            {
                if (File.Exists(@"..\..\DAL\ReglerLista.DAT"))
                {
                    m_Regler = BinarySerialization<List<Regler>>.BinaryDeSerialize("ReglerLista.DAT");
                }
                else
                {
                    //TestData();
                }

            }
            catch (Exception ex)
            {
                
                throw new Exception("Den kunde inte ladda från Regler listan." + ex.Message);// CustomException(ex.Message);
            }
        }
        /// <summary>
        /// Lägger till objekt i listan Regler
        /// </summary>
        /// <param name="item">Regel</param>
        public void Add(Regler item)
        {
            m_Regler.Add(item);
            ServiceProvider.GetReglerService().BinarySerialize();
            SaveToDBA();

        }
        /// <summary>
        /// Tar bort objekt i listan Regler.
        /// </summary>
        /// <param name="item">Regel</param>
        public void Remove(Regler item)
        {
            m_Regler.Remove(item);
        }

        public string GetNamnOFIndex(int i)
        {
            return m_Regler[i].getNamn();
        }
        /// <summary>
        /// Tar bort specifikt objekt efter index.
        /// </summary>
        /// <param name="i">Regelindex</param>
        public void RemoveAt(int i)
        {
            m_Regler.RemoveAt(i);
        }
        /// <summary>
        /// Tar fram ett regelindex.
        /// </summary>
        /// <param name="index">Regelindex</param>
        /// <returns>Specifikt index</returns>
        public Regler Get(int index)
        {
            return m_Regler.ElementAt(index);
        }
        /// <summary>
        /// Tar fram antalet objekt i listan Regler.
        /// </summary>
        /// <returns>Antalet objekt i Regler</returns>
        public int Count()
        {
            return m_Regler.Count();
        }
        /// <summary>
        /// Tar fram ett index för en viss regel.
        /// </summary>
        /// <param name="regel">En regels namn/signatur</param>
        /// <returns>Regelns index</returns>
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
        /// <summary>
        /// Lista med grundregler för att ha en bas till projektet.
        /// </summary>
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

        /// <summary>
        /// Sparar ner regler som en fil.
        /// </summary>
        /// <returns>Att sparningen lyckades</returns>
        public bool BinarySerialize()
        {
            try
            {
                BinarySerialization<List<Regler>>.FileName = "ReglerLista.DAT";
                BinarySerialization<List<Regler>>.BinarySerialize(m_Regler);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message); //CustomException(ex.Message);
            }

            return true;
        }

        /// <summary>
        /// Sparar till databasen
        /// </summary>
        public void SaveToDBA()
        {
            DataAccessLayerDBA dba = new DataAccessLayerDBA();
            dba.SaveRegel();

        }
    }



}




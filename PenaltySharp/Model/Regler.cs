using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Model
{
    class Regler
    {
        //Medlemsvariabler
        private string m_namn;
        private int m_id;
        private int m_böter;
     
        public Regler()
        {
            this.m_namn = "Hångel";
            this.m_id = 0;
            this.m_böter = 450000000;
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inNamn">Regel Namn</param>
        /// <param name="inId">Regel Id</param>
        /// <param name="inBöter">Regel Böter</param>
        public Regler(string inNamn, int inId, int inBöter)
        {
            this.m_namn = inNamn;
            this.m_id = inId;
            this.m_böter = inBöter;
        }

        // Metoder

        /// <summary>
        ///Returnerar regel namn
        /// </summary>
        /// <returns>regel namn</returns>
        public string getNamn()
        {
            return this.m_namn;
        }


        /// <summary>
        /// Returnerar regel id.
        /// </summary>
        /// <returns>regel id</returns>
        public int getId()
        {
            return this.m_id;
        }

        /// <summary>
        /// Returnerar regel böter.
        /// </summary>
        /// <returns>regel böter</returns>
        public int getBöter()
        {
            return this.m_böter;
        }

        /// <summary>
        /// Bestämmer regel namn.
        /// </summary>
        /// <param name="namn">regel namn</param>
        public void setNamn(string namn)
        {
            this.m_namn = namn;
        }

        /// <summary>
        /// Bestämmer regel id.
        /// </summary>
        /// <param name="id">regel id</param>
        public void setId(int id)
        {
            this.m_id = id;
        }

        /// <summary>
        /// Bestämmer regel böter.
        /// </summary>
        /// <param name="böter">regel böter</param>
        public void setBöter(int böter)
        {
            this.m_böter = böter;
        }

    }
}

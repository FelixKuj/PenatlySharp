using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Model
{
    class Regler
    {
        //medlemsvariabler
        private string namn;
        private int id;
        private int böter;


        public Regler()
        {
            this.namn = "Hångel";
            this.id = 0;
            this.böter = 450000000;
        }

        public Regler(string inNamn, int inId, int inBöter)
        {
            this.namn = inNamn;
            this.id = inId;
            this.böter = inBöter;
        }

        // metoder

        /// <summary>
        ///Returnerar regel namn
        /// </summary>
        /// <returns>regel namn</returns>
        public string getNamn()
        {
            return this.namn;
        }


        /// <summary>
        /// Returnerar regel id.
        /// </summary>
        /// <returns>regel id</returns>
        public int getId()
        {
            return this.id;
        }

        /// <summary>
        /// Returnerar regel böter.
        /// </summary>
        /// <returns>regel böter</returns>
        public int getBöter()
        {
            return this.böter;
        }

        /// <summary>
        /// Bestämmer regel namn.
        /// </summary>
        /// <param name="namn">regel namn</param>
        public void setNamn(string namn)
        {
            this.namn = namn;
        }

        /// <summary>
        /// Bestämmer regel id.
        /// </summary>
        /// <param name="id">regel id</param>
        public void setId(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Bestämmer regel böter.
        /// </summary>
        /// <param name="böter">regel böter</param>
        public void setBöter(int böter)
        {
            this.böter = böter;
        }

    }
}

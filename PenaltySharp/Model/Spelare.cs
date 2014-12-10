using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Model
{
    class Spelare
    {
        private string m_namn;
        private int m_id;
        private string m_användarnamn;
        private string m_lösenord;

        public Spelare()
        {
            this.m_namn = "Felix Kujanpää";
            this.m_id = 0;
            this.m_användarnamn = "FelixKuj";
            this.m_lösenord = "QWE123";
        }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inNamn">Spelare namn</param>
        /// <param name="inId">Spelare ID</param>
        /// <param name="inAnvändarnamn">Spelare användarnamn</param>
        /// <param name="inLösenord">Spealre Lösenord</param>
        public Spelare(string inNamn,
                     int inId,
                     string inAnvändarnamn,
                     string inLösenord)
        {
            this.m_namn = inNamn;
            this.m_id = inId;
            this.m_användarnamn = inAnvändarnamn;
            this.m_lösenord = inLösenord;
        }

        /// <summary>
        /// rerurnerar Namn
        /// </summary>
        /// <returns>Namn</param>
        public string getNamn(string Namn)
        {
           return this.m_namn;
        }

        /// <summary>
        /// Bestämmer Namn 
        /// </summary>
        /// <param name="namn">Namn</param>
        public void setNamn(string namn)
        {
            this.m_namn = namn;
        }

        /// <summary>
        /// Returnerar ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ID</returns>
        public int getId(int id)
        {
            return this.m_id;
        }
        /// <summary>
        /// Returnerar ID
        /// </summary>
        /// <param name="id">ID</param>
        public void setId(int id)
        {
            this.m_id = id;
        }

        public string getAnvändarnamn(string användarnamn)
        {
            return this.m_användarnamn;
        }


        public void setAnvändarnamn(string användarnamn)
        {
            this.m_användarnamn = användarnamn;
        }

        public string getLösenord(string användarnamn)
        {
            return this.m_lösenord;
        }

        public void setLösenord(string lösenord)
        {
            this.m_lösenord = lösenord;
        }
    }
}

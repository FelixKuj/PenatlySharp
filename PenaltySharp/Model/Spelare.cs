using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Model
{
    class Spelare
    {
        private string namn;
        private int id;
        private string användarnamn;
        private string lösenord;

        public Spelare()
        {
            this.namn = "Felix Kujanpää";
            this.id = 0;
            this.användarnamn = "FelixKuj";
            this.lösenord = "QWE123";
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
            this.namn = inNamn;
            this.id = inId;
            this.användarnamn = inAnvändarnamn;
            this.lösenord = inLösenord;
        }

        /// <summary>
        /// rerurnerar Namn
        /// </summary>
        /// <returns>Namn</param>
        public string getNamn(string Namn)
        {
           return this.namn;
        }

        /// <summary>
        /// Bestämmer Namn 
        /// </summary>
        /// <param name="namn">Namn</param>
        public void setNamn(string namn)
        {
            this.namn = namn;
        }

        /// <summary>
        /// Returnerar ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ID</returns>
        public int getId(string id)
        {
            return this.id;
        }
        /// <summary>
        /// Returnerar ID
        /// </summary>
        /// <param name="id">ID</param>
        public setId(string id)
        {
            this.id = id;
        }
    }
}

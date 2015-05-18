using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.Model
{
    [Serializable]
    class Böter
    {
        // Medlemsvariabler
        private int m_personId;
        private int m_regelId;
        private bool m_betald;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inPersonId">PersonID</param>       
        /// <param name="inRegelId">RegelID</param>
        /// <param name="inBetald">Betald</param>
        public Böter(int inPersonId, int inRegelId, bool inBetald)
        {
            this.m_personId = inPersonId;       
            this.m_regelId = inRegelId;
            this.m_betald = inBetald;
        }

        // Metoder

        /// <summary>
        /// Returnerar PersonID
        /// </summary>
        /// <returns>Person ID</returns>
        public int getPersonId()
        {
            return this.m_personId;
        }

        /// <summary>
        /// Returnerar Regel ID
        /// </summary>
        /// <returns>Regel ID</returns>
        public int getRegelId()
        {
            return this.m_regelId;
        }
        /// <summary>
        /// Returnar Betald
        /// </summary>
        /// <returns>Betalad eller ej</returns>
        public bool getBetald()
        {
            return this.m_betald;
        }

        /// <summary>
        /// Bestämmer PersonID
        /// </summary>
        /// <param name="personId">Person ID</param>
        public void setPersonId(int personId)
        {
            this.m_personId = personId;
        }

        /// <summary>
        /// Bestämmer RegelID
        /// </summary>
        /// <param name="böterId">Regel ID</param>
        public void setRegelId(int regelId)
        {
            this.m_regelId = regelId;
        }

        /// <summary>
        /// Bestämmer Betald eller ej
        /// </summary>
        /// <param name="betald">Betald eller ej</param>
        public void setBetald(bool betald)
        {
            this.m_betald = betald;
        }
    }
}

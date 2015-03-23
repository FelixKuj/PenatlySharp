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
        private int m_böterKostnad;
        private int m_böterId;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inPersonId">PersonID</param>
        /// <param name="inBöterKostnad">BöterKostnad</param>
        /// <param name="inBöterId">BöterID</param>
        public Böter(int inPersonId, int inBöterKostnad, int inBöterId)
        {
            this.m_personId = inPersonId;
            this.m_böterKostnad = inBöterKostnad;
            this.m_böterId = inBöterId;
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
        /// Returnerar Böterkostnaden
        /// </summary>
        /// <returns>BöterKostnad</returns>
        public int getBöterKostnad()
        {
            return this.m_böterKostnad;
        }

        /// <summary>
        /// Returnerar Böter ID
        /// </summary>
        /// <returns>Böter ID</returns>
        public int getBöterId()
        {
            return this.m_böterId;
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
        /// Besämmer BöterKostnad
        /// </summary>
        /// <param name="böterKostnad">BöterKostnad</param>
        public void setBöterKostnad(int böterKostnad)
        {
            this.m_böterKostnad = böterKostnad;
        }

        /// <summary>
        /// Bestämmer BöterID
        /// </summary>
        /// <param name="böterId">Böter ID</param>
        public void setBöterId(int böterId)
        {
            this.m_böterId = böterId;
        }
    }
}

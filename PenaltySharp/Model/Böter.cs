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
        private int m_böterkostnad;
        private int m_böterId;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inPersonId"></param>
        /// <param name="inBöterkostnad"></param>
        /// <param name="inBöterId"></param>
        public Böter(int inPersonId, int inBöterkostnad, int inBöterId)
        {
            this.m_personId = inPersonId;
            this.m_böterkostnad = inBöterkostnad;
            this.m_böterId = inBöterId;
        }

        // Metoder

        public int getPersonId()
        {
            return this.m_personId;
        }

        public int getBöterkostnad()
        {
            return this.m_böterkostnad;
        }

        public int getBöterId()
        {
            return this.m_böterId;
        }

        public void setPersonId(int personId)
        {
            this.m_personId = personId;
        }
        public void setBöterkostnad(int böterKostnad)
        {
            this.m_böterkostnad = böterKostnad;
        }
        public void setBöterId(int böterId)
        {
            this.m_böterId = böterId;
        }
    }
}

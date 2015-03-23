using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenaltySharp.Model;
using PenaltySharp.Controller;
using PenaltySharp.View;

namespace PenaltySharp.Model
{
    [Serializable]
    class Spelare
    {   //Medlemsvariabler

        private string m_namn;
        private int m_id;
        private string m_användarnamn;
        private string m_lösenord;
        private bool m_admin;


        //(list)
         
      

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="inNamn">Spelare namn</param>
        /// <param name="inId">Spelare ID</param>
        /// <param name="inAnvändarnamn">Spelare användarnamn</param>
        /// <param name="inLösenord">Spelare Lösenord</param>
        public Spelare(string inNamn,
                     int inId,
                     string inAnvändarnamn,
                     string inLösenord,
                     bool inAdmin)
        {
            this.m_namn = inNamn;
            this.m_id = inId;
            this.m_användarnamn = inAnvändarnamn;
            this.m_lösenord = inLösenord;
            this.m_admin = inAdmin;
        }

        /// <summary>
        /// Returnerar Namn
        /// </summary>
        /// <returns>Namn</param>
        public string getNamn()
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
        public int getId()
        {
            return this.m_id;
        }
        /// <summary>
        /// Bestämmer ID
        /// </summary>
        /// <param name="id">ID</param>
        public void setId(int id)
        {
            this.m_id = id;
        }
        /// <summary>
        /// Returnerar Användarnamn
        /// </summary>
        /// <returns>Användarnamn</returns>
        public string getAnvändarnamn()
        {
            return this.m_användarnamn;
        }

        /// <summary>
        /// Bestämmer Användarnamn
        /// </summary>
        /// <param name="användarnamn">Användarnamn</param>
        public void setAnvändarnamn(string användarnamn)
        {
            this.m_användarnamn = användarnamn;
        }
        /// <summary>
        /// Returnerar Lösenord
        /// </summary>
        /// <returns>Lösenord</returns>
        public string getLösenord()
        {
            return this.m_lösenord;
        }
        /// <summary>
        /// Bestämmer Lösenord
        /// </summary>
        /// <param name="lösenord">Lösenord</param>
        public void setLösenord(string lösenord)
        {
            this.m_lösenord = lösenord;
        }

        /// <summary>
        /// Returnerar Admin
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Admin</returns>
        public bool getAdmin()
        {
            return this.m_admin;
        }
        /// <summary>
        /// Bestämmer Admin
        /// </summary>
        /// <param name="admin">Admin</param>
        public void setAdmin(bool admin)
        {
            this.m_admin = admin;
        }
    }
}

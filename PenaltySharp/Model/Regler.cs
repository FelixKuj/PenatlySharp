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
        //public string namn { get; set; }

        public Regler()
        {
            this.namn = "hångel";
            this.id = 0;
            this.böter = 450000000;
        }

        public Regler(string inNamn, int inId, int inBöter)
        {
            this.namn = inNamn;
            this.id = inId;
            this.böter = inBöter;
        }
    }
}

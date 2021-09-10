using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class Rowhouse : Villa
    {
        private bool garden; 

        // Constructor 

        public Rowhouse (bool g, bool b, int cy, int nbrRooms, int f) : base(b, cy, nbrRooms, f)
        {
            this.garden = g; 
        }

        //Properties 
        public bool Garden
        {
            get; set; 
        }
    }
}
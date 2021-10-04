using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    [Serializable]
    public class University : Institutional
    {

        // Specific vars 

        private int nbrOfGroupRooms; 


        // Constructor 
        public University(int nbrOfGroupRooms) : base()
        {
            this.nbrOfGroupRooms = nbrOfGroupRooms; 
        }

        public University() { }

        // Property

        public int NbrOfGroupRooms
        {
            get; set; 
        }

        public override string ToString()
        {
            return base.ToString() + " Group rooms: "+ NbrOfGroupRooms;
        }
    }
}
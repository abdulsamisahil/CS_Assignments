using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class University : Institutional
    {

        // Specific vars 

        private int nbrOfGroupRooms; 


        // Constructor 
        public University(int nbrOfGroupRooms, string name, bool library) : base(name, library)
        {
            this.nbrOfGroupRooms = nbrOfGroupRooms; 
        }

        // Property

        public int NbrOfGroupRooms
        {
            get; set; 
        }
    }
}
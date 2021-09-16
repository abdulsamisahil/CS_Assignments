using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public abstract class Residential : Estate
    {
        private int numberOfRooms;
        
        private int floor;

        public Residential() { }

        // Constructor 
        public Residential(int r, int f)
        {
            numberOfRooms = r;

            floor = f; 
        }

        public int NumberOfRooms { get; set; }

        public int Floor { get; set; }

        public override double calculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
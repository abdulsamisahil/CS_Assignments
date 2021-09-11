using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{

   
    public abstract class Residential : Estate
    {
        private double numberOfRooms;
        private int floor;


        // Constructor 
        public Residential(double r, int f)
        {
            this.numberOfRooms = r;
            this.floor = f; 
        }
        public Residential()
        {

        }

        public override double calculateArea()
        {
            throw new NotImplementedException();
        }
    }
}
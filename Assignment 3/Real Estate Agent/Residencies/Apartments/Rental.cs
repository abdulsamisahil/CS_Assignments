using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    [Serializable]
    public class Rental : Apartment
    {
        private double rent; 

        // Constructor 
        public Rental() {}

        public Rental(double rent) : base()
        {
            this.rent = rent; 
        }


        // Property 
        public double Rent
        {
            get; set;
        }
        public override string ToString()
        {
            return base.ToString() + " Rent: "+ Rent;
        }
    }
}
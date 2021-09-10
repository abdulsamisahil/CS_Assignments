using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class Rental : Apartment
    {
        private double rent; 

        // Constructor 

        public Rental(double rent, bool balcony, int rooms, int floor) :base(balcony, rooms, floor)
        {
            this.rent = rent; 
        }


        // Property 
        public double Rent
        {
            get; set; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class Apartment : Residential
    {
        private bool balcony; 

        // Constructor

        public Apartment(bool balcony, int rooms, int floor) : base(rooms, floor)
        {
            this.balcony = balcony; 
        }
        

        // Proptery 
        public bool Balcony
        {
            get; set; 
        }
    }
}
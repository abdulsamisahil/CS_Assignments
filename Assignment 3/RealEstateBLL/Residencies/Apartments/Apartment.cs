using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class Apartment : Residential
    {
        private bool balcony; 

        // Constructor

        public Apartment() {}

        public Apartment(bool balcony) : base()
        {
            this.balcony = balcony; 
        }
        

        // Proptery 
        public bool Balcony
        {
            get; set; 
        }
        public override string ToString()
        {
            return base.ToString() + " Balcony: "+ Balcony;
        }
    }
}
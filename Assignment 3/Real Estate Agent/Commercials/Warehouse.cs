using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    [Serializable]
    public class Warehouse : Commercial
    {
        // Specific vars 
        private double rating; 

        // Constructor 
        public Warehouse() { }
        public Warehouse(double rating) : base()
        {
            this.rating = rating; 
        }

        //Property

        public double Rating
        {
            get; set; 
        }

        public override string ToString()
        {
            return base.ToString() + " Ratings: "+ Rating;
        }
    }
}
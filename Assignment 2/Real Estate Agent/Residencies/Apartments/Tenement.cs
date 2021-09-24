using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    [Serializable]
    public class Tenement : Apartment
    {

        // Var Specific for Tenement 
        private string housingAssociation; 

        // Constructor 
        public Tenement() {}

        public Tenement(string ha) : base()
        {
            housingAssociation = ha; 
        }


        // Property 
        public string HousingAssociation
        {
            get; set; 
        }
        public override string ToString()
        {
            return base.ToString() + " Förening: "+ HousingAssociation;
        }
    }
}
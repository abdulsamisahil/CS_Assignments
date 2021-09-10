using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class Tenement : Apartment
    {

        // Var Specific for Tenement 
        private string housingAssociation; 

        // Constructor 


        public Tenement(string ha, bool balcony, int rooms, int floor) : base(balcony, rooms, floor)
        {
            this.housingAssociation = ha; 
        }


        // Property 

        public string HousingAssociation
        {
            get; set; 
        }
    }
}
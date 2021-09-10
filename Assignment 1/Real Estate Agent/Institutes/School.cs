using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class School : Institutional
    {
        // Specific vars 

        private string typeOfSchool; 

        // Constructor 
        public School(string type, string name, bool library) : base(name, library)
        {
            this.typeOfSchool = type; 
        }

        // Property

        public string TypeOfSchool
        {
            get; set; 
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public class School : Institutional
    {
        // Specific vars 

        private string typeOfSchool; 

        // Constructor 

        public School()
        {

        }
        public School(string type) : base()
        {
            this.typeOfSchool = type; 
        }

        // Property

        public string TypeOfSchool
        {
            get; set; 
        }
        public override string ToString()
        {
            return base.ToString() + " Type: "+ TypeOfSchool;
        }
    }
}
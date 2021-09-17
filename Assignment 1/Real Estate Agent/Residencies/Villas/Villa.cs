using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    public class Villa : Residential
    {
        private bool basement;
        
        private int constructionYear; 

        // Constructor 
        public Villa() {}

        public Villa(bool b, int cy) : base()
        {
            basement = b;
            
            constructionYear = cy; 
        }

        #region Properties 

        public bool Basement
        {
            get; set; 
        }

        public int ConstructionYear
        {
            get; set;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + " Builded: "+ ConstructionYear;
        }
    }
}
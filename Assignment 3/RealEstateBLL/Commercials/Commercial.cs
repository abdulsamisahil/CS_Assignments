using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public abstract class Commercial : Estate
    {

        // Common vars for commercial 
        private string usage;
        private double income;
        
        // Constructor 

        public Commercial (string usage, double income): base()
        {
            this.usage = usage;
            this.income = income; 
        }

        public Commercial()
        {

        }

        #region properties 
        public string Usage
        {
            get; set;  
        }
        public double Income
        {
            get; set;
        }
        #endregion


        public override string ToString()
        {
            return " Usage: " + Usage+  " Income: " + Income;
        }
    }
}
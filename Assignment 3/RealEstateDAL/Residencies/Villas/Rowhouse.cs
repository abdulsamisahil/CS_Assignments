using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateDAL
{
    [Serializable]
    public class Rowhouse : Villa
    {
        private bool garden; 

        // Constructor 
        public Rowhouse() {}

        public Rowhouse (bool g, bool b, int cy) : base(b, cy)
        {
            garden = g; 
        }

        //Properties 
        public bool Garden
        {
            get; set; 
        }
        public override string ToString()
        {
            return base.ToString() + " Garden: "+ Garden;
        }
    }
}
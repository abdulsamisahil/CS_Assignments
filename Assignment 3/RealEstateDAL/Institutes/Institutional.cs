using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateDAL
{
    [Serializable]
    public abstract class Institutional : Estate
    {

        // Commons vars for instit.. 

        private string name;
        private bool library;
        

        // Constructor 
        public Institutional(string name, bool library)
        {
            this.name = name;
            this.library = library; 
        }
        public Institutional()
        {

        }

        #region Properties
        public string Name
        {
            get; set; 
        }
        public bool Library
        {
            get; set;
        }

        #endregion
        public override string ToString()
        {
            return " Name: "+ Name+ " Library: " + Library;
        }
    }
}
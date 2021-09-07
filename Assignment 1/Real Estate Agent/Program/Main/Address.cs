using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Agent
{ 
        
    class Address
    {
        private string  zip_code;
        private string street;
        private string city;
        private Countries country; 

        // Constructor 
        public Address(string zc, string st, string ct, Countries co)
        {
            this.zip_code = zc;
            this.street = st;
            this.city = ct;
            this.country = co; 
        }
    }
}

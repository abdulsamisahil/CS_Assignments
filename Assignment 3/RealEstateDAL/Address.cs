using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateDAL
{ 
    [Serializable]    
    public class Address
    {
        public string  zip_code;
        public  string street;
        public string city;
        public Countries country;


        //// Constructor 
        //public Address(string zc, string st, string ct, Countries co)
        //{
        //    this.zip_code = zc;
        //    this.street = st;
        //    this.city = ct;
        //    this.country = co;
        //}

        public override string ToString()
        {
            return string.Format("{0}", "{1}", "{2}", "{3}",street, zip_code, city, country );
        }
    }
}

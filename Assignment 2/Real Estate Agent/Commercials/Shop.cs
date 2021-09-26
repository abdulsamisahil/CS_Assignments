using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Real_Estate_Agent
{
    [Serializable]
    public class Shop : Commercial
    {
        // Specific var 

        private string shopeName; 
          
        // Constructor 

        public Shop() { }
        public Shop(string shopeName) : base()
        {
            this.shopeName = shopeName;
            
        }

        // Property 
        public string ShopeName
        {
            get; set; 
        }

        public override string ToString()
        {
            return base.ToString() + " Shop name: "+ ShopeName;
        }
    }
}
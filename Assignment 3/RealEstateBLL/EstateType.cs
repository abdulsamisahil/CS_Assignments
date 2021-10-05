using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL
{

    // Enums which will be used when figuring out user input while creating estate objects
    public enum EstateType
    {
        Commercial, 
        
        Institutional, 
        
        Residential
    }

    public enum SubTypes
    {
        Shop,
        
        Warehouse,
        
        School,
        
        University,
        
        Villa,
        
        Rowhouse,
        
        Rental, 
        
        Tenement
    }

}

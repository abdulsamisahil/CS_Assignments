using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Estate_Agent.Program.Main
{
    /// <summary>
    /// This class handles the estates, being created and added to the collection
    /// </summary>
    class EstateHandler
    {
        // Estate objects collection 
        private List<Estate> estateList; 

        //Constructor 
        public EstateHandler() 
        {
            estateList = new List<Estate>(); 
        }


        // Adding an estate object 
        private void addEstate (Estate obj)
        {
            if (obj != null)
                estateList.Add(obj); 
        }

        // Removing an estate object from the list 
        private void removeEstateAt(int index)
        {
            if(checkIndexValidation(index))
                estateList.RemoveAt(index);
        }

        // Changing an estate object in the collection 
        private void changeEstate(int index)
        {

        }

        // Checking if the index is not out of bounds 
        private bool checkIndexValidation(int index)
        {
            bool ok = false;
            if ((index >= 0) && (index < estateList.Count))
                ok = true;
            return ok; 
        }
    }

}

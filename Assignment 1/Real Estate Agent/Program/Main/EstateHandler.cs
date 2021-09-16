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
        public void addEstate (Estate obj)
        {
            if (obj != null)
            {
                estateList.Add(obj);
            }
        }

        // Removing an estate object from the list 
        public void removeEstateAt(int index)
        {
            if(checkIndexValidation(index))
            {
                estateList.RemoveAt(index);
            }
        }

        // Finds an estate object
        public Estate findEstateAt(int index) 
        {
            if (checkIndexValidation(index))
            {
                return estateList.ElementAt(index);
            }

            return null;
        }

        // Changing an estate object in the collection 
        public void changeEstate(int index, Estate obj)
        {
            if (obj != null && checkIndexValidation(index)) 
            {
                estateList[index] = obj;
            }
        }

        // Checking if the index is not out of bounds 
        private bool checkIndexValidation(int index)
        {
            return (index >= 0) && (index < estateList.Count);
        }
    }

}

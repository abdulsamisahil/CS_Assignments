using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL
{
    interface IListManager <T>
    {
        /// <summary>
        /// This method brings us a property of the length of the collection
        /// </summary>
        public int Count { get; }

        /// <summary>
        /// Here we return true if the method succeeds adding the obj to the collection
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        bool Add(T obj);
        /// <summary>
        /// This method takes an object from a given index and changes it. 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        bool ChangeAt(T obj, int index);
        /// <summary>
        /// This method checks the index validation and returns true if valid 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool CheckIndex(int index);
        /// <summary>
        /// This function deletes cleans the collection 
        /// </summary>
        void DeleteAll();
        /// <summary>
        /// This method deletes the object at the given index, and returns true
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        bool DeleteAt(int index);

        /// <summary>
        /// This function returns the object at the given index
        /// it is a generic method and can be of any type. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T GetAt(int index);

        /// <summary>
        /// This method changes the list<T> to a string array where 
        /// each index at the array represents an object of type T 
        /// </summary>
        /// <returns></returns>
        string[] ToStringArray();
        /// <summary>
        /// Returns the collection T of type string 
        /// </summary>
        /// <returns></returns>
        List<string> ToStringList(); 
        
    }
}

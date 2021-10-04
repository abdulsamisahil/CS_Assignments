using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Assignment 1 
/// This abstract class will play the role as the base for the sub-categories as 
/// commercial, residential, instit... 
/// @authors Abdul Sami & Motaz 
/// </summary>
namespace Real_Estate_Agent
{
    [Serializable]

    public abstract class Estate : IEstate
    {
        //Common vars for all subs 
        
        private  Address address;

        private string id;

        // Constructor 
        public Estate(string Id, Address address) 
        {
            id = Id;
            this.address = address; 
         
        }


       public Estate()
        {

        }

        #region properties 
        public string Id 
        {
            get; set; 
        }


        //Address IEstate.Address
        //{
        //    get; set;
        //}

        public Address Address
        {
            get; set; 
        }

        //internal Address Address
        //{
        //    get => address;
        //    set
        //    {
        //        address = value;
        //    }
        //}

        #endregion



        // The abstract method which is common for all estates
        public abstract string ToString();


    }
}
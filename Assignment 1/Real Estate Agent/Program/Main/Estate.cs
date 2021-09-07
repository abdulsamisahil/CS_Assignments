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
    public abstract class Estate : IEstate
    {
        //Common vars for all subs 
        private string id;
        private Address address;


        #region properties 
        public string estate_Id 
        {
            get { return id;  } 
            set
            {
                if (id != null)
                    id = value; 
            }
        }
        Address IEstate.Estate_address 
        {
            get { return address; }
            set { address = value; }
        }

        internal Address Address
        {
            get => address;
            set
            {
                address = value;
            }
        }
        #endregion



        // The abstract method which is common for all estates
        public abstract double area();


    }
}
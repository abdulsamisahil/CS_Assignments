using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// Assignment 1 
/// This interface will be implemented by the Estate and it includes some 
/// common objects like id and address   
/// @authors Abdul Sami & Motaz 
namespace Real_Estate_Agent
{
     interface IEstate
    {
        // Each state has an id and an address, properties for the interface 
        string Id { get; set; }
        Address Address { get; set; }
    }
}
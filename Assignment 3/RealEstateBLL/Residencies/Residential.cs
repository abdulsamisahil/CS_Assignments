using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RealEstateBLL
{
    [Serializable]
    public abstract class Residential : Estate
    {
        private int numberOfRooms;
        private int floor;

        public Residential() { }

        // Constructor 
        public Residential(int r, int f)

        {
            this.numberOfRooms = r;
            this.floor = f; 
        }
        
        #region Properties 
        public int NumberOfRooms { get; set; }
        public int Floor { get; set; }
        #endregion
        public override string ToString()
        {
            return  "Rooms: "+ NumberOfRooms+ " Floor: "+ Floor;
        }
    }
}
using System;

namespace UtilitiesLib
{
    public class parsingString
    {
        // Convert string into numeric data 

        public int stringToInt(string strNum, int low, int high)
        {
            int i;
            bool isParsable = Int32.TryParse(strNum, out i);

            if (isParsable && i < high && i > low)
                     return i; 
          
            return -1; 
        }

        public double stringToDecimal(string strNum, double low, double high)
        {
            double i;
            bool isParsable = Double.TryParse(strNum, out i); 

            if (isParsable && i < high && i > low)
                return i;

            return -1;
        }

    }
}

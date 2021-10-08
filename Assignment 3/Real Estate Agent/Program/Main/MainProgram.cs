//using Real_Estate_Agent.Program.Main;
using System;
using UtilitiesLib; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Estate_Agent
{
    static class MainProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());


            //Testing B - Part
           /* parsingString ul = new parsingString();
            int number =ul.stringToInt("999", 0, 99);
            double dec = ul.stringToDecimal("-2.0", 0.0, 99.0); 

            MessageBox.Show("Integer: "+number + "\nDecimal: " + dec); */

            //Testing A - Part 
            //Moved all generic file handlers to UtilitiesLib assembly for future projects, the program works fine

            /*
            //Testing serialization and deserialization to binary files

            Shop shop = new Shop();
            shop.ShopeName = "Samitesting";
            shop.Usage = "medical";
            shop.Income = 54000;

   
            string filePath = "samitestingseranddes.save"; 

            EstateSerializer<Shop> es = new EstateSerializer<Shop>();

            es.BinarySerialize(shop, filePath);
            Shop shop2 = null;
            shop2 = es.BinaryDeserialize(filePath);
            MessageBox.Show(shop2.ToString());
            */
        }
    }
}


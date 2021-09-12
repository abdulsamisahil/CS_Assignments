using System;
using System.Windows.Forms;
using System.Drawing;


namespace Real_Estate_Agent
{
    public partial class mainForm : Form
    {
        string[] eTypes = new string[] { "Commercial", "Institutional", "Residential" };

        int activeEstateIndex = -1;
        int activeSubTypeIndex = -1; 

        // Returns the subType array in acccordance to the main 3 categories 
        private string [] returnSubTypes(int index)
        {
            string[] types = new string[5];
            switch (index)
            {
                case 0:
                    types = new string[] { "Shop", "Warehouse" };
                    break;
                case 1:
                    types = new string[] { "School", "University" };
                    break;
                case 2:
                    types = new string[] { "Villa", "Rowhouse", "Rental", "Tenement" };
                    break; 

            }
            return types; 
        }

        public mainForm()
        {
            InitializeComponent();
            eTypeComboBox.Items.AddRange(eTypes);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void eTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeEstateIndex = eTypeComboBox.SelectedIndex;
            
            string[] subTypes = returnSubTypes(activeEstateIndex);
            eSubComboBox.Items.Clear(); 
            eSubComboBox.Items.AddRange(subTypes); 
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // CommonVar1.Text = "Number of rooms"; 
        }

        private void CommonVar2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStreet_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void eSubComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeSubTypeIndex = eSubComboBox.SelectedIndex;



            switch (activeEstateIndex)
            {
                case 0:
                    if (activeSubTypeIndex == 0)
                        subTypes("Shop");
                    else
                        subTypes("Warehouse"); 
                    break;
               case 1:
                    if (activeSubTypeIndex == 0)
                        subTypes("School");
                    else
                        subTypes("University");
                    break;
                case 2:
                    switch (activeSubTypeIndex)
                    {
                        case 0:
                            subTypes("Villa");
                            break;
                        case 1:
                            subTypes("Rowhouse");
                            break;
                        case 2:
                            subTypes("Rental");
                            break;
                        case 3:
                            subTypes("Tenement");
                            break; 
                    }
                    break;

            }


            
           
        }

        // Returns subtypes index 
        private int subTypesIndex() 
        {
            return eSubComboBox.SelectedIndex; 
        }
        // Returns estate type index 
        private int estateTypeIndex()
        {
            return eTypeComboBox.SelectedIndex; 
        }


        private void subTypes (string str, string str2, string str3)
        {
            string data = "";
            CommonVar1.Text = str;
            CommonVar2.Text = str2;
            CommonVar3.Text = str3;

            if (str == "Shop")
            {
                setCommonVars("Shope name", "Usage", "Income"); 
            }
            else if (str == "Warehouse")
            {
                setCommonVars("Rating", "Usage", "Income");
            }
            else if (str == "School")
            {
                CommonVar1.Text = "Type of school";
                CommonVar2.Text = "School name";
                CommonVar3.Text = "Library";
            }
            else if (str == "University")
            {
                CommonVar1.Text = "Group rooms";
                CommonVar2.Text = "Name";
                CommonVar3.Text = "Library";
            }
            else if (str == "Villa")
            {
                CommonVar1.Text = "Construction year";
                CommonVar2.Text = "Rooms";
                CommonVar3.Text = "Floor";
            }
            else if (str == "Villa")
            {
                CommonVar1.Text = "Construction year";
                CommonVar2.Text = "Rooms";
                CommonVar3.Text = "Floor";
            }
            // return data; 
        }

       private void setCommonVars(string str1, string str2, string str3)
        {
            subTypes(str1, str2, str3); 
        }
         
    }
}

using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace Real_Estate_Agent
{
    public partial class mainForm : Form
    {
        string[] eTypes = new string[] { "Commercial", "Institutional", "Residential" };

        int activeEstateIndex = -1;
        
        int activeSubTypeIndex = -1; 

        public mainForm()
        {
            InitializeComponent();

            eTypeComboBox.Items.AddRange(eTypes);

            // List<Countries> countriesValues = Enum.GetValues(typeof(Countries)).ToList();

            string[] countriesValues = Enum.GetNames(typeof(Countries));

            countriesComboBox.Items.AddRange(countriesValues);

        }

        // Returns the subType array in acccordance to the main 3 categories 
        private string[] returnSubTypes(int index)
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
                    setCommonVarsToCommercial(activeSubTypeIndex);
                    break;
                case 1:
                    setCommonVarsToInstitutional(activeSubTypeIndex);
                    break;
                case 2:
                    setCommonVarsResidential(activeSubTypeIndex);
                    break;
            }           
        }
        
        private void setCommonVarsResidential(int activeSubTypeIndex)
        {
            switch (activeSubTypeIndex)
            {
                case 0:
                    setCommonVarsToVilla();
                    break;
                case 1:
                    setCommonVarsToRowHouse();
                    break;
                case 2:
                    setCommonVarsToRental();
                    break;
                case 3:
                    setCommonVarsToTeneament();
                    break;
            }
        }

        private void setCommonVarsToInstitutional(int activeSubTypeIndex)
        {
            if (activeSubTypeIndex == 0)
                setCommonVarsToSchool();
            else
                setCommonVarsToUnversity();
        }

        private void setCommonVarsToCommercial(int activeSubTypeIndex)
        {
            if (activeSubTypeIndex == 0)
                setCommonVarsToShop();
            else
                setCommonVarsToWarehouse();
        }

        private void setCommonVarsToUnversity()
        {
            setCommonVars("Group rooms", "Name", "Library");
        }

        private void setCommonVarsToSchool()
        {
            setCommonVars("Type of school", "School name", "Library");
        }

        private void setCommonVarsToWarehouse()
        {
            setCommonVars("Rating", "Usage", "Income");
        }

        private void setCommonVarsToShop()
        {
            setCommonVars("Shope name", "Usage", "Income");
        }

        private void setCommonVarsToTeneament()
        {
            setCommonVars("Housing association", "Rooms", "Floor");
        }

        private void setCommonVarsToRental()
        {
            setCommonVars("Rent", "Rooms", "floor");
        }

        private void setCommonVarsToRowHouse()
        {
            setCommonVars("Garden", "Rooms", "Floor");
        }

        private void setCommonVarsToVilla()
        {
            setCommonVars("Construction year", "Rooms", "Floor");
        }

        private void setCommonVars(string str, string str2, string str3)
        {   
            CommonVar1.Text = str;
            
            CommonVar2.Text = str2;
            
            CommonVar3.Text = str3;
        }
    }
}

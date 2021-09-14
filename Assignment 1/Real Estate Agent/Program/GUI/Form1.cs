using System;

using System.Windows.Forms;

using Real_Estate_Agent.Program.Main;

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
        #region setting labels to their right values 
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
        #endregion

        private void setCommonVars(string str, string str2, string str3)
        {   
            CommonVar1.Text = str;
            
            CommonVar2.Text = str2;
            
            CommonVar3.Text = str3;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Todo: Figure out the user input object, by checking with the EstateType and SubType Enums 
            //Todo: Once the right input is found out, create the estate object and instantiate it to it's right subtype 
            //Todo: Call upon Estatehandler and add it to the collection 
            //Todo: Show it up in the gui listbox, with its full information visible
        }

        // Creating Estate Object

        private void createEstate(string userInput)
        {

            int estate = estateIndex();

            EstateType chooseBase = (EstateType)estate;

            string activeItemStr = (string)eSubComboBox.SelectedItem;

            SubTypes chooseSpecific = (SubTypes)Enum.Parse(typeof(SubTypes), activeItemStr);

            Estate estateToAdd = null;

            switch (chooseBase)
            {
                case EstateType.Commercial:
                    switch(chooseSpecific)
                    {
                        case SubTypes.Shop:

                            Shop shop = new Shop(txtCV1.Text);

                            shop.ShopeName = txtCV2.Text;

                            shop.Income = new Double();


                            

                            break;

                        case SubTypes.Warehouse:
                            break;
                    }    

                    break;

                case EstateType.Institutional:
                    switch(chooseSpecific)
                    {
                        case SubTypes.School:
                            break;

                        case SubTypes.University:
                            break;
                    }

                    break;


                case EstateType.Residential:
                    switch(chooseSpecific)
                    {
                        case SubTypes.Villa:
                            break;

                        case SubTypes.Rowhouse:
                            break;

                        case SubTypes.Rental:
                            break;

                        case SubTypes.Tenement:
                            break;
                    }
                    break;
            }
        }
       

        // Estate index returns 
        private int estateIndex() 
        {
            activeEstateIndex = eTypeComboBox.SelectedIndex;
            return activeEstateIndex; 
        }
        // Subtype index returns 
        private int subTypeIndex()
        {
            activeSubTypeIndex = eSubComboBox.SelectedIndex;
            return activeSubTypeIndex;
        }
    }
}

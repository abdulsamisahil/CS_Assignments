using System;

using System.Windows.Forms;

using Real_Estate_Agent.Program.Main;

namespace Real_Estate_Agent
{
    public partial class mainForm : Form
    {

        private Observable<string> commonVarObservable1 = new Observable<string>(null);

        private Observable<string> commonVarObservable2 = new Observable<string>(null);

        private Observable<string> commonVarObservable3 = new Observable<string>(null);

        private Observable<string> streetObservable = new Observable<string>(null);

        private Observable<string> zipCodeObservable = new Observable<string>(null);

        private Observable<string> cityObservable = new Observable<string>(null);

        private Observable<string> countryObservable = new Observable<string>(null);

        private Observable<string> subTypeObservable = new Observable<string>(null);

        private readonly string[] commercialSubComboboxItems = new string[] { "Shop", "Warehouse" };

        private readonly string[] institutionalSubComboboxItems = new string[] { "School", "University" };

        private readonly string[] residentialSubComboboxItems = new string[] {
            "Villa",
            "Rowhouse",
            "Rental",
            "Tenement"
        };

        public mainForm()
        {
            InitializeComponent();

            addTwoWaybindingToTextBox(txtCV1, commonVarObservable1);

            addTwoWaybindingToTextBox(txtCV2, commonVarObservable2);

            addTwoWaybindingToTextBox(txtCV3, commonVarObservable3);

            addTwoWaybindingToTextBox(textBox1, streetObservable);

            addTwoWaybindingToTextBox(textBox2, zipCodeObservable);

            addTwoWaybindingToTextBox(textBox3, cityObservable);

            countriesComboBox.Items.AddRange(Utilis.enumToStrArr<Countries>());

            addTwoWayBindingToComboBox(countriesComboBox, countryObservable);

            eTypeComboBox.Items.AddRange(Utilis.enumToStrArr<EstateType>());

            eTypeComboBox.TextChanged += baseTypeUpdater;

            addTwoWayBindingToComboBox(eSubComboBox, subTypeObservable);

            subTypeObservable.listener += subTypeUpdater;

            subTypeObservable.listener += commonVarsLabelsUpdater;
        }

        private void subTypeUpdater(string value)
        {
            if (value != null && value != "")
            {
                SubTypes subType = Utilis.strToEnumValue<SubTypes>(value);

                switch(subType)
                {
                    case SubTypes.Rental:
                    case SubTypes.Villa:
                    case SubTypes.Rowhouse:
                    case SubTypes.Tenement:

                        eTypeComboBox.SelectedItem = EstateType.Residential.ToString();
                        break;

                    case SubTypes.Shop:
                    case SubTypes.Warehouse:

                        eTypeComboBox.SelectedItem = EstateType.Commercial.ToString();
                        break;

                    case SubTypes.School:
                    case SubTypes.University:

                        eTypeComboBox.SelectedItem = EstateType.Institutional.ToString();
                        break;
                }

                eSubComboBox.Text = subType.ToString();
            }
        }

        private void baseTypeUpdater(object sender, EventArgs e)
        {
            string value = (string)eTypeComboBox.SelectedItem;

            EstateType estateType = Utilis.strToEnumValue<EstateType>(value);

            eSubComboBox.SelectedIndex = -1;

            eSubComboBox.Items.Clear();
            
            switch (estateType)
            {
                case EstateType.Commercial:

                    eSubComboBox.Items.AddRange(commercialSubComboboxItems);
                    break;

                case EstateType.Institutional:

                    eSubComboBox.Items.AddRange(institutionalSubComboboxItems);
                    break;

                case EstateType.Residential:
                    
                    eSubComboBox.Items.AddRange(residentialSubComboboxItems);
                    break;
            }

            setCommonVars("CommonVar1", "CommonVar2", "CommonVar3");
        }

        private void commonVarsLabelsUpdater(string value)
        {
            if (value != null && value != "")
            {
                SubTypes subType = Utilis.strToEnumValue<SubTypes>(value);

                switch (subType)
                {
                    case SubTypes.Rental:

                        setCommonVars("Rent", "Rooms", "floor");
                        break;

                    case SubTypes.Villa:

                        setCommonVars("Construction year", "Rooms", "Floor");
                        break;

                    case SubTypes.Rowhouse:

                        setCommonVars("Garden", "Rooms", "Floor");
                        break;

                    case SubTypes.Tenement:

                        setCommonVars("Housing association", "Rooms", "Floor");
                        break;

                    case SubTypes.Shop:

                        setCommonVars("Shope name", "Usage", "Income");
                        break;

                    case SubTypes.Warehouse:

                        setCommonVars("Rating", "Usage", "Income");
                        break;

                    case SubTypes.School:

                        setCommonVars("Type of school", "School name", "Library");
                        break;

                    case SubTypes.University:

                        setCommonVars("Group rooms", "Name", "Library");
                        break;
                }
            }
        }

        private void setCommonVars(string str, string str2, string str3)
        {
            CommonVar1.Text = str;

            CommonVar2.Text = str2;

            CommonVar3.Text = str3;
        }

        private void addTwoWaybindingToTextBox(TextBox textBox, Observable<string> observable) 
        {
            observable.listener += (string value) =>
            {
                textBox.Text = value;
            };

            textBox.TextChanged += (object sender, EventArgs e) => 
            {
                observable.value = textBox.Text;
            };
        }

        private void addTwoWayBindingToComboBox(ComboBox comboBox, Observable<string> observable)
        {
            observable.listener += (string value) =>
            {
                comboBox.SelectedItem = value;
            };

            comboBox.TextChanged += (object sender, EventArgs e) => 
            {
                observable.value = (string)comboBox.SelectedItem;
            };
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi Object! ");

            //Todo: Figure out the user input object, by checking with the EstateType and SubType Enums 
            //Todo: Once the right input is found out, create the estate object and instantiate it to it's right subtype 
            //Todo: Call upon Estatehandler and add it to the collection 
            //Todo: Show it up in the gui listbox, with its full information visible


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void eTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq; 
using Real_Estate_Agent.Program.Main;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; 
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

        private string fileFilterStr = "Text files (*.txt)|*.txt|All files (*.save)|*.save";

        // A1 implementation 
        // private EstateHandler estateHandler = new EstateHandler();

        // Implemented for a2 
        private EstateManager estateManager = new EstateManager(); 

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

            subTypeObservable.listener += imageUpdater;

            estateManager.observable.listener += updateListView; 
        }

        private void imageUpdater(string value)
        {
            if (Utilis.isValidStr(value))
            {
                SubTypes subType = Utilis.strToEnumValue<SubTypes>(value);

                switch(subType)
                {
                    case SubTypes.Shop:
                        break;

                    case SubTypes.Warehouse:
                        break;
        
                    case SubTypes.School:
                        break;

                    case SubTypes.University:
                        break;

                    case SubTypes.Villa:
                        break;

                    case SubTypes.Rowhouse:
                        break;

                    case SubTypes.Rental:
                        break;

                    case SubTypes.Tenement:
                        break;
                }
            }
        }

        private void subTypeUpdater(string value)
        {
            if (Utilis.isValidStr(value))
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
            else
            {
                eTypeComboBox.SelectedIndex = -1;

                eSubComboBox.SelectedIndex = -1;

                eSubComboBox.Items.Clear();
            }
        }

        private void baseTypeUpdater(object sender, EventArgs e)
        {
            string value = (string)eTypeComboBox.SelectedItem;

            if (Utilis.isValidStr(value))
            {
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
        }



        private void commonVarsLabelsUpdater(string value)
        {
            if (Utilis.isValidStr(value))
            {
                SubTypes subType = Utilis.strToEnumValue<SubTypes>(value);



                string commonvar1 = "";

                string commonvar2 = "";

                string commonvar3 = "";



                if (Utilis.isSubTypeResidential(subType)) 
                {
                    commonvar2 = "Rooms";

                    commonvar3 = "flor";
                }

                if (Utilis.isSubTypeCommercial(subType))
                {
                    commonvar2 = "Usage";

                    commonvar3 = "Income";
                }

                if (Utilis.isSubTypeInstitutional(subType))
                {
                    commonvar2 = "Name";

                    commonvar3 = "Library";
                }



                if (SubTypes.Rental == subType)
                {
                    commonvar1 = "Rent";
                }

                if (SubTypes.Villa == subType)
                {
                    commonvar1 = "Construction year";
                }

                if (SubTypes.Rowhouse == subType)
                {
                    commonvar1 = "Garden";
                }

                if (SubTypes.Tenement == subType)
                {
                    commonvar1 = "Housing association";
                }

                if (SubTypes.Shop == subType) 
                {
                    commonvar1 = "Shope name";
                }

                if (SubTypes.Warehouse == subType)
                {
                    commonvar1 = "Rating";
                }

                if (SubTypes.School == subType)
                {
                    commonvar1 = "Type of school";
                }

                if (SubTypes.University == subType)
                {
                    commonvar1 = "Group rooms";
                }

                setCommonVars(commonvar1, commonvar2, commonvar3);
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



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1) 
            {
                int index = 0;

                foreach (int i in listView1.SelectedIndices)
                {
                    index = i;
                }

                Estate estate = estateManager.GetAt(index);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (int index in listView1.SelectedIndices)
            {
                estateManager.DeleteAt(index);
            }

            commonVarObservable1.value = null;

            commonVarObservable2.value = null;

            commonVarObservable3.value = null;

            streetObservable.value = null;

            zipCodeObservable.value = null;

            cityObservable.value = null;

            subTypeObservable.value = null;

            countryObservable.value = null;
    }

        private void Change_Click(object sender, EventArgs e)
        {
            foreach (int index in listView1.SelectedIndices)
            {
                Estate estate = createEstate();

                estateManager.ChangeAt(estate, index);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (hasValidProperties())
            {
                Estate estate = createEstate();

                estateManager.Add(estate);
            }
        }

        private Estate createEstate()
        {
            Estate estate = null;

            SubTypes subType = Utilis.strToEnumValue<SubTypes>(subTypeObservable.value);


           
            int rooms = 0;

            int flor = 0;


            if (Utilis.isSubTypeResidential(subType))
            {
                rooms = int.Parse(commonVarObservable2.value);

                flor = int.Parse(commonVarObservable3.value);
            }



            string usage = "";

            double income = 0;

            if (Utilis.isSubTypeCommercial(subType))
            {
                usage = commonVarObservable2.value;

                income = double.Parse(commonVarObservable3.value);
            }



            string name = "";

            bool hasLibrary = false;

            if (Utilis.isSubTypeInstitutional(subType))
            {
                name = commonVarObservable2.value;

                hasLibrary = bool.Parse(commonVarObservable3.value);
            }



            if (SubTypes.Rental == subType)
            {
                double rent = double.Parse(commonVarObservable1.value);

                Rental rental = new Rental();

                rental.Rent = rent;

                rental.NumberOfRooms = rooms;

                rental.Floor = flor;

                estate = rental;
            }

            if (SubTypes.Villa == subType)
            {
                int constructionYear = int.Parse(commonVarObservable1.value);

                Villa villa = new Villa();

                villa.NumberOfRooms = rooms;

                villa.Floor = flor;

                villa.ConstructionYear = constructionYear;

                estate = villa;
            }

            if (SubTypes.Rowhouse == subType)
            {
                bool hasGarden = bool.Parse(commonVarObservable1.value);

                Rowhouse rowhouse = new Rowhouse();

                rowhouse.Garden = hasGarden;

                rowhouse.NumberOfRooms = rooms;

                rowhouse.Floor = flor;
            }

            if (SubTypes.Tenement == subType)
            {
                string housingAssociation = commonVarObservable1.value;

                Tenement tenement = new Tenement();

                tenement.HousingAssociation = housingAssociation;

                tenement.NumberOfRooms = rooms;

                tenement.Floor = flor;

                estate = tenement;
            }

            if (SubTypes.Shop == subType)
            {
                string shopName = commonVarObservable1.value;

                Shop shop = new Shop();

                shop.ShopeName = shopName;

                shop.Usage = usage;

                shop.Income = income;

                estate = shop;
            }

            if (SubTypes.Warehouse == subType)
            {
                double rating = double.Parse(commonVarObservable1.value);

                Warehouse warehouse = new Warehouse();

                warehouse.Rating = rating;

                warehouse.Usage = usage;

                warehouse.Income = income;

                estate = warehouse;
            }

            if (SubTypes.School == subType)
            {
                string typeOfSchool = commonVarObservable1.value;

                School school = new School();

                school.TypeOfSchool = typeOfSchool;

                school.Name = name;

                school.Library = hasLibrary;

                estate = school;
            }

            if (SubTypes.University == subType)
            {
                int nbrOfGroupRooms = int.Parse(commonVarObservable1.value);

                University university = new University();

                university.Name = name;

                university.NbrOfGroupRooms = nbrOfGroupRooms;

                university.Library = hasLibrary;

                estate = university;
            }

            setAdress(estate);

            return estate;
        }

        private void setAdress(Estate estate)
        {

            Address addr = new Address
            {
                zip_code = zipCodeObservable.value,
                street = streetObservable.value,
                city = cityObservable.value,

                country = Utilis.strToEnumValue<Countries>(countryObservable.value)
            };

            estate.Address = addr;
        }



        private bool hasValidProperties()
        {
            return (
                
                Utilis.isValidStr(subTypeObservable.value)
                
                && Utilis.isValidStr(countryObservable.value)
                
                && Utilis.isValidStr(commonVarObservable1.value)
                
                && Utilis.isValidStr(commonVarObservable2.value)
                
                && Utilis.isValidStr(commonVarObservable3.value)
                
                && Utilis.isValidStr(streetObservable.value)
                
                && Utilis.isValidStr(zipCodeObservable.value)
                
                && Utilis.isValidStr(cityObservable.value)
            );
        }

        private void updateListView(List<Estate> list)
        {
            listView1.Items.Clear(); 

            List<ListViewItem> listViewItems = new List<ListViewItem>(); 

            foreach(Estate lis in list )
            {
                ListViewItem item = new ListViewItem();

                item.Text = lis.ToString();
                
                listViewItems.Add(item); 
            }

            listView1.Items.AddRange(listViewItems.ToArray()); 
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to restart the app? All the objects will be erased", "Restarting", MessageBoxButtons.YesNo); 
            if (dr == DialogResult.Yes)
            {
                Application.Restart(); 
            }
            else
            {
                return; 
            }
        }

        private void mnuFileOpen_Click(object sender, EventArgs e)
        {
            Stream stream = null; 
            
            OpenFileDialog theDialog = new OpenFileDialog();

            theDialog.Title = "Open Text File";
            
            theDialog.Filter = fileFilterStr; // Only txt files will be shown
            
            theDialog.InitialDirectory = @"C:\"; // The default directory that opens

            if(theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((stream = theDialog.OpenFile())!= null)
                    { 

                        using (stream)
                        {
                            // string txtContent = System.IO.File.ReadAllText(theDialog.FileName);
                            // Shop shop2 = null;
                            // shop2 = es.BinaryDeserialize(filePath);

                            Shop estate = EstateSerializer<Shop>.BinaryDeserialize(theDialog.FileName);

                            MessageBox.Show(estate.ToString());
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not read the file from disk"); 
                }
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CommonVar2_Click(object sender, EventArgs e)
        {

        }

        private void CommonVar3_Click(object sender, EventArgs e)
        {

        }

        private void CommonVar1_Click(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void mnuFileSave_Click(object sender, EventArgs e)
        {
            mnuFileSaveAs_Click(sender, e); 
        }

        private void mnuFileSaveAs_Click(object sender, EventArgs e)
        {
            Stream stream;

            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.Filter = fileFilterStr;

            saveFile.FilterIndex = 2;
            
            saveFile.RestoreDirectory = true;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFile.OpenFile()) != null)
                {
                    // Code to serialize and write the object to file 


                    int selectedIndex = returnListViewSelectedIndex(); 

                    Shop estate = (Shop)estateManager.GetAt(selectedIndex);

                    EstateSerializer<Shop>.BinarySerialize2(estate, stream);

                    //after writing close the stream 
                    stream.Close();
                }
            }
        }
        private int returnListViewSelectedIndex()
        {
            int index = -1; 
            foreach(int i in listView1.SelectedIndices)
            {
                index = i;
                break; 
            }
            return index; 
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Closing the application", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                Application.Exit();
            else return; 
        }

        private void mnuFileExportXml_Click(object sender, EventArgs e)
        {
            int index = returnListViewSelectedIndex(); 
            if(index < 0)
            {
                MessageBox.Show("Please select an object to save it as an xml ");
            }
            try
            {
                string filename = "estateToXml.save";
                Rental rental = (Rental)estateManager.GetAt(index);
                EstateSerializer<Rental>.estateToXmlSerialie(rental, filename); 
            }catch (Exception)
            {
                
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq; 
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

        private EstateHandler estateHandler = new EstateHandler();

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

            estateHandler.observableList.listener += updateGui; 
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

            if (value != "" && value != null)
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

        private Estate createEstate()
        {
            Estate estate = null;

            if (subTypeObservable.value != "" && subTypeObservable.value != null) 
            {
                SubTypes subType = Utilis.strToEnumValue<SubTypes>(subTypeObservable.value);

                switch(subType)
                {
                    case SubTypes.Rental:

                        // setCommonVars("Rent", "Rooms", "floor");

                        double rent = double.Parse(commonVarObservable1.value);

                        int rooms = int.Parse(commonVarObservable2.value);

                        int floor = int.Parse(commonVarObservable3.value);

                        Rental rental = new Rental();
                        rental.Rent = rent;
                        rental.NumberOfRooms = rooms;
                        rental.Floor = floor; 

                        estate = rental;

                       // updateGUI(); 
                        break;

                    case SubTypes.Rowhouse:
                        bool garden = bool.Parse(commonVarObservable1.value);
                        bool basement = bool.Parse(commonVarObservable2.value);
                        int constructionYear = int.Parse(commonVarObservable3.value);

                        Rowhouse rowhouse = new Rowhouse();
                        rowhouse.Garden = garden;
                        rowhouse.Basement = basement;
                        rowhouse.ConstructionYear = constructionYear; 

                        estate = rowhouse;
                     
                        break;

                    case SubTypes.School:
                        string schoolType = commonVarObservable1.value;
                        string schoolName = commonVarObservable2.value;
                        bool lib = bool.Parse(commonVarObservable3.value);

                        School school = new School();
                        school.TypeOfSchool = schoolType; 
                        school.Name = schoolName;
                        school.Library = lib; 
                        estate = school;
                     
                        break;

                    case SubTypes.Shop:
                        string shopName = commonVarObservable1.value;
                        string usage = commonVarObservable2.value;
                        double income = double.Parse(commonVarObservable3.value);

                        Shop shop = new Shop();
                        shop.ShopeName= shopName;
                        shop.Usage = usage;
                        shop.Income = income; 

                        estate = shop;
                       

                        // updateGui();
                        break;

                    case SubTypes.Tenement:
                        string housingA = commonVarObservable1.value;
                        int ro = int.Parse(commonVarObservable2.value);
                        int floo = int.Parse(commonVarObservable3.value);

                        Tenement tenement = new Tenement();
                        tenement.HousingAssociation = housingA;
                        tenement.NumberOfRooms = ro;
                        tenement.Floor = floo; 
                        estate = tenement;
                      

                        // updateGui();

                        break;

                    case SubTypes.University:
                        string univName = commonVarObservable2.value;
                        int nbrOfGrooms = int.Parse(commonVarObservable1.value);
                        bool library = bool.Parse(commonVarObservable3.value);

                        University university = new University();
                        university.Name = univName;
                        university.NbrOfGroupRooms = nbrOfGrooms; 
                        university.Library= library;
                        estate = university;
                   
                        break;

                    case SubTypes.Villa:
                        int roms = int.Parse(commonVarObservable1.value);
                        int flor = int.Parse(commonVarObservable2.value);
                        int cy = int.Parse(commonVarObservable3.value);

                        Villa villa = new Villa();
                        villa.NumberOfRooms = roms;
                        villa.Floor = flor; 
                        villa.ConstructionYear = cy; 

                        estate = villa;
                       
                        break;

                    case SubTypes.Warehouse:
                        double ratings = double.Parse(commonVarObservable1.value);
                        string useag = commonVarObservable2.value;
                        double inc = double.Parse(commonVarObservable3.value);

                        Warehouse warehouse = new Warehouse();
                        warehouse.Rating = ratings;
                        warehouse.Usage = useag;
                        warehouse.Income = inc; 

                        estate = warehouse;

                        

                        break;
                }
                setAdress(estate);
               
            }
            return estate;
        }

        // setting the address of the estate 
        private void setAdress(Estate obj)
        {
            
                Address addr = new Address
            {
                zip_code = zipCodeObservable.value,
                street = streetObservable.value,
                city = cityObservable.value,
                
                country = Utilis.strToEnumValue<Countries>(countryObservable.value)
            };
            obj.Address = addr; 
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            Estate obj = createEstate();
            estateHandler.addEstate(obj); 
           
        }

        private void updateGui(List<Estate> list)
        {
            // Estate[] estateList = list.ToArray(); 

            //  ListViewItem[] listViewItems = new ListViewItem[list.Count];

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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (int index in listView1.SelectedIndices)
            {
                estateHandler.removeEstateAt(index); 
            }


            // This works as well

            //if (listView1.SelectedItems.Count > 0)
            //{
            //    int index = -1;
            //    for (int i = 0; i < listView1.Items.Count; i++)
            //    {
            //        if(listView1.Items[i].Selected == true)
            //        {
            //            index = i;
            //            estateHandler.removeEstateAt(index); 
            //            break; 
            //        }
            //    }
            //}

        }

        private void Change_Click(object sender, EventArgs e)
        {

        }
    }



}
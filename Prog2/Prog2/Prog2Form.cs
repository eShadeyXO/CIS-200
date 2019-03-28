//D1220
//CIS 200-76
//Monday, October 23rd, 2017
//Program 2
//This class contains functionality for the program two main form.
using Prog2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; //UPV

        //Precondition: None
        //Postcondition: GUI prepared for display
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();

            upv.AddAddress("Judy Cox", "2749 Duck Creek Road", 
                "Palo Alto", "CA", 94306); //Test Address 1
            upv.AddAddress("Rebecca Norris", "626 Kembery Drive",
                "Bucks", "AL", 36512); //Test Address 2
            upv.AddAddress("Jerry Owen", "2147 Eagles Nest Drive", "Apt. 2",
                "Sacramento", "CA", 95814); //Test Address 3
            upv.AddAddress("Francis Underwood", "1600 Pennsylvania Ave. NW",
                "Washington", "DC", 20500); //Test Address 4
            upv.AddAddress("Shrimply Pibbles", "123 Galactic Federation Dr.",
                "Seattle", "WA", 98155); //Test Address 5
            upv.AddAddress("Humany McHumanface", "745 Address Ave.",
                "Louisville", "KY", 40245); //Test Address 6
            upv.AddAddress("Namey McNameface", "4923 Addressy McAddressface Way",
                "Glendale", "CA", 91204); //Test Address 7
            upv.AddAddress("Jerry Seinfeld", "129 West 81st St.", "Apartment 5A",
                "New York", "NY", 10017); //Test Address 8

            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(2), 3.50M); //Test Letter 1
            upv.AddLetter(upv.AddressAt(3), upv.AddressAt(4), 2.00M); //Test Letter 2

            upv.AddGroundPackage(upv.AddressAt(5), upv.AddressAt(6), 10, 10, 10, 20); //Test GP 1
            upv.AddGroundPackage(upv.AddressAt(7), upv.AddressAt(5), 100, 75, 25, 80); //Test GP 2

            upv.AddNextDayAirPackage(upv.AddressAt(1), upv.AddressAt(5), 5, 5, 5, 15, 10.00M); //Test NDAP 1
            upv.AddNextDayAirPackage(upv.AddressAt(2), upv.AddressAt(3), 2.5, 2.6, 2.7, 5, 5.00M); //Test NDAP 2

            upv.AddTwoDayAirPackage(upv.AddressAt(4), upv.AddressAt(0), 10, 15, 20, 25,
                TwoDayAirPackage.Delivery.Saver); //Test TDAP 1
            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(7), 30, 30, 30, 300,
                TwoDayAirPackage.Delivery.Early); //Test TDAP2
        }

        //Preconiditon: None
        //Postcondition: Displays a messagebox with programmer information.
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Grading ID: D1220" + "\n" + "Section: CIS 200-76" + "\n" +
                "Due: Monday, October 23, 2017" + "\n" + "Program: Program 2");
        }

        //Precondition: None
        //Postcondition: Exits the application.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Precondition: None
        //Postcondition: Displays all addresses in display panel.
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayText.AppendText("Addresses:" + Environment.NewLine + Environment.NewLine);

            //Step through list of addresses and display in text box.
            foreach(Address item in upv.AddressList)
            {
                displayText.AppendText(item.ToString() + Environment.NewLine);
                displayText.AppendText("================================" + Environment.NewLine);
            }
        }

        //Precondition: None
        //Postcondition: Displays list of parcels in display panel.
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            displayText.AppendText("Parcels:" + Environment.NewLine + Environment.NewLine);
            
            //Step through list of parcels and display in text box.
            foreach (Parcel item in upv.ParcelList)
            {
                displayText.AppendText(item.ToString() + Environment.NewLine);
                displayText.AppendText("================================" + Environment.NewLine);
            }
        }

        //Precondition: Address menu item is clicked.
        //Postcondition: Input from address form is stored and sent to UPV.
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm AddressForm = new AddressForm();
            DialogResult result;
            string name; //Variable to hold name
            string address1; //Variable to hold address line 1
            string address2; //Variable to hold address line 2
            string city; //Variable to hold city
            string state; //Variable to hold state
            int zip; //Variable to hold zip

            result = AddressForm.ShowDialog(); //Show Address form on top of main form

            if(result == DialogResult.OK) //If the dialog result is okay
            {
                name = AddressForm.AddressName;
                address1 = AddressForm.AddressLine1;
                address2 = AddressForm.AddressLine2;
                city = AddressForm.AddressCity;
                state = AddressForm.AddressState;
                zip = int.Parse(AddressForm.AddressZip);

                upv.AddAddress(name, address1, address2, city, state, zip); //Use add address method to add address input to UPV.
            }
        }

        //Precondition: Letter menu item is clicked
        //Postcondition: Input from letter form is stored and sent to UPV.
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm LetterForm = new LetterForm(upv.AddressList);
            DialogResult result;
            int originIndex;
            int destinationIndex;
            decimal fixedCost;

            result = LetterForm.ShowDialog();

            if(result == DialogResult.OK)
            {
                originIndex = LetterForm.OriginIndex;
                destinationIndex = LetterForm.DestIndex;
                fixedCost = decimal.Parse(LetterForm.LetterFixedCost);

                upv.AddLetter(upv.AddressAt(originIndex), upv.AddressAt(destinationIndex) , fixedCost);
            }
        }
    }
}

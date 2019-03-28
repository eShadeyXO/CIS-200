// Program 3
// CIS 200-76
// Fall 2017
// Due: 11/8/2017
// Grading ID: D1220
//Class contains functionality for editAddressForm.
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
    public partial class SelectAddressForm : Form
    {
        public const int MIN_ADDRESSES = 2; // Minimum number of addresses needed

        private List<Address> addressList;

        public SelectAddressForm(List<Address> addresses)
        {
            InitializeComponent();

            addressList = addresses;
        }

        internal int EditAddressIndex
        {
            //Precondition: None
            //Postcondition: Returns selected index of edit address combo.
            get { return editAddressCombo.SelectedIndex; }

            //Precondition: Item must be chosen and must be smaller than address count.
            //Postcondition: Selected index is set to value.
            set
            {
                if ((value >= -1) && (value < addressList.Count))
                    editAddressCombo.SelectedIndex = value;
                else
                    throw new ArgumentOutOfRangeException("EditAddressIndex", value,
                        "Index must be valid.");
            }
        }

        //Precondition: None
        //Postcondition: editAddressCombo is loaded with available address names.
        private void SelectAddressForm_Load(object sender, EventArgs e)
        {
                foreach (Address a in addressList)
                {
                    editAddressCombo.Items.Add(a.Name);
                }
        }

        //Precondition: editAddressButton is activated.
        //Postcondition: SelectAddressForm closes.
        private void editAddressButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Precondition: editAddressCombo must have a selected item.
        //Postcondition: Correct error is displayed if no item is chosen.
        private void editAddressCombo_Validating(object sender, CancelEventArgs e)
        {
            if (editAddressCombo.SelectedIndex == -1) // -1 means no item selected
            {
                e.Cancel = true;
                editAddressErrorProvider.SetError(editAddressCombo, "Must select an address");
            }
        }

        //Precondition: editAddressCombo passes validation.
        //Postcondition: Error is cleared, if any.
        private void editAddressCombo_Validated(object sender, EventArgs e)
        {
            editAddressErrorProvider.SetError(editAddressCombo, "");
        }
    }
}

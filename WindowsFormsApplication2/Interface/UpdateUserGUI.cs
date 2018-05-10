using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Interface
{
    public partial class UpdateUserGUI : Form
    {
        DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();
        public UpdateUserGUI()
        {
            InitializeComponent();
        }

        private void UpdateUserGUI_Load(object sender, EventArgs e)
        {
            int id = Customer.activeCustomer.CustomerId;
            tbxFirstName.Text = Customer.activeCustomer.FirstName;
            tbxLastName.Text = Customer.activeCustomer.LastName;
            tbxPhone.Text = Customer.activeCustomer.Phone;
            tbxAddress.Text = Customer.activeCustomer.Address;
            tbxCity.Text = Customer.activeCustomer.City;
            tbxState.Text = Customer.activeCustomer.State;
            tbxZipCode.Text = Customer.activeCustomer.Zip;
            lblEmail.Text = Customer.activeCustomer.Email;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if(checkRequiredFields() && checkAddressFields())
            {
                Customer.activeCustomer.FirstName = tbxFirstName.Text;
                Customer.activeCustomer.LastName = tbxLastName.Text;
                Customer.activeCustomer.Phone = tbxPhone.Text;
                Customer.activeCustomer.Address = tbxAddress.Text;
                Customer.activeCustomer.City = tbxCity.Text;
                Customer.activeCustomer.State = tbxState.Text;
                Customer.activeCustomer.Zip = tbxZipCode.Text;

                if (db.UpdateCustomerInfo(Customer.activeCustomer))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update failed.");
                }
            }
        }

        private bool checkRequiredFields()
        {
            if ((tbxFirstName.Text == "" || tbxLastName.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool checkAddressFields()
        {
            if (tbxAddress.Text == "" || tbxCity.Text == "" || tbxState.Text == "" || tbxZipCode.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace WindowsFormsApplication2
{
    public partial class CreateNewUserGUI : Form
    {
        DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();

        public CreateNewUserGUI()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUser(object sender, EventArgs e)
        {
            if (checkRequiredFields() && checkAddressFields())
            {
                Customer cust = new Customer(
                    tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPhone.Text, tbxAddress.Text, tbxCity.Text, tbxState.Text, tbxZipCode.Text);
                db.AddCustomerToDatabase(cust);
                this.Close();
            } else if (checkRequiredFields())
            {
                Customer cust = new Customer(tbxFirstName.Text, tbxLastName.Text, tbxEmail.Text, tbxPhone.Text);
                db.AddCustomerToDatabase(cust);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add customer, at least the required fields are filled.");
            }
        }

        private bool checkRequiredFields()
        {
            if ((tbxEmail.Text == "" || tbxFirstName.Text == "" || tbxLastName.Text == ""))
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
            if(tbxAddress.Text=="" || tbxCity.Text == "" || tbxState.Text == "" || tbxZipCode.Text == "")
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}

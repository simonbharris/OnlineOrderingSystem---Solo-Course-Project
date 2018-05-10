using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.DatabaseUtilities;

namespace WindowsFormsApplication2
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void UserListGUI_Load(object sender, EventArgs e)
        {
            DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();
            lbxUsers.DataSource = db.SelectSpecificFromTable("email", "customer");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(lbxUsers.SelectedIndex > -1)
            {
                DBConnection db = new DBConnection();
                Customer.activeCustomer = db.RetrieveCustomerViaEmail(lbxUsers.Text);
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Please select a user.");
            }
        }
    }
}

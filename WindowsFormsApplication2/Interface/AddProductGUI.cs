using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class AddProductGUI : Form
    {
        MainGUI parent;
        public AddProductGUI()
        {
            InitializeComponent();
        }

        public AddProductGUI(MainGUI parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();
            if (tbxProductName.Text != "" || tbxPrice.Text != "")
            {
                Product p = new Product(tbxProductName.Text, Double.Parse(tbxPrice.Text), tbxDescription.Text);
                if (db.AddProductToDataBase(p))
                {
                    MessageBox.Show("Product added successfully.");
                    parent.updateProductLists();
                    this.Close();
                } else
                {
                    MessageBox.Show("Addition failed.");
                }
            }
            else
            {
                MessageBox.Show("Cannot add, be sure name and price are filled.");
            }
        }
    }
}

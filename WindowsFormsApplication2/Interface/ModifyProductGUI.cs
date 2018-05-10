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
    public partial class ModifyProductGUI : Form
    {
        Product p;
        public ModifyProductGUI()
        {
            InitializeComponent();
        }

        private void ModifyProductGUI_Load(object sender, EventArgs e)
        {
            p = (Product) MainGUI.selected;
            tbxProductName.Text = p.Name;
            tbxPrice.Text = p.Price.ToString();
            tbxDescription.Text = p.Description;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            p.Name = tbxProductName.Text;
            p.Price = double.Parse(tbxPrice.Text);
            p.Description = tbxDescription.Text;
            DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();
            db.UpdateProductInfo(p);
        }
    }
}

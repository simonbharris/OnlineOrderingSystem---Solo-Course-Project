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
    public partial class MainGUI : Form
    {
        /* Author: Simon Harris
         * Made for a programming class at DeVry University
         * 
         * I recently went back and glanced through it and finished the 
         * functionality of some *very* rushed features. 
         * We were given 1 week to develop this application from scratch.
         * 
         * At the time, working with databases and data 
         * from C# perspective was completely new to me.
         * Thus I work with data in a sort of an odd manner, 
         * I know now I probably should have used datasets. 
         * 
         * ... And also split this presentation layer into an application layer, and have better organization.
         * */
        DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();
        static public Object selected;
        List<Product> pList; //Product List
        List<Product> cart; // Customer Cart

        public MainGUI()
        {
            InitializeComponent();
            cart = new List<Product>();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductGUI form2 = new AddProductGUI();
            form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CreateNewUserGUI cnu = new CreateNewUserGUI();
            cnu.Show();
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            Interface.RemoveProductGUI rp = new Interface.RemoveProductGUI(this);
            rp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginGUI login = new LoginGUI();
            login.Show();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void MainGUI_Activated(object sender, EventArgs e)
        {
            if(Customer.activeCustomer != null)
            {
                lblActiveUser.Text = Customer.activeCustomer.Email;
            }
            else
            {
                lblActiveUser.Text = "No one";
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            Interface.UpdateUserGUI form = new Interface.UpdateUserGUI();
            form.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductGUI form = new AddProductGUI(this);
            form.Show();
        }

        private void btnModifyProduct_Click(object sender, EventArgs e)
        {
            if(lbxProductList.SelectedIndex > -1)
            {
                selected = pList[lbxProductList.SelectedIndex];
                Interface.ModifyProductGUI form = new Interface.ModifyProductGUI();
                form.Show();
            } else
            {
                MessageBox.Show("Please select a product first.");
            }
        }
        // Tried making these next two methods more modular and reusable...
        // May have ended up making it more awkward
        // To be used to update product lists so customer / admin can populate / update product catalog with new information
        private void updateProductListBox(ListBox lb)
        {
            lb.Items.Clear();
            pList = db.RetrieveProductsFromDatabase();
            foreach (Product prod in pList)
            {
                lb.Items.Add(prod.ToString());
            }
        }
        public void updateProductLists()
        {
            updateProductListBox(lbxItemCatalog);
            updateProductListBox(lbxProductList);
        }
        public void updateCartList()
        {
            lbxCart.Items.Clear();
            foreach (Product prod in cart)
            {
                lbxCart.Items.Add(prod.ToString());
                lbxOrderSummary.Items.Add(prod.ToString());
            }
        }

        // Populates catalogs when needed.
        private void oosTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(oosTab.SelectedIndex == 3 || oosTab.SelectedIndex == 1)
            {
                updateProductLists();
            }
        }

        private void btnAddItemToCart_Click(object sender, EventArgs e)
        {
            if(lbxItemCatalog.SelectedIndex >= 0)
            {
                Product p = pList[lbxItemCatalog.SelectedIndex];
                p.Quantity = Int32.Parse(tbxQuantity.Text);
                if(p != null)
                {
                    lbxCart.Items.Clear();
                    cart.Add(p);
                    foreach(Product prod in cart)
                    {
                        lbxCart.Items.Add(prod);
                    }
                }
                tbxTotalCost.Text = Product.CalculateCartValue(cart).ToString("C");
            }
        }

        private void btnRemoveItemFromCart_Click(object sender, EventArgs e)
        {
            if(lbxCart.SelectedIndex >= 0)
            {
                cart.RemoveAt(lbxCart.SelectedIndex);
                updateCartList();
                tbxTotalCost.Text = Product.CalculateCartValue(cart).ToString("C");

            }
        }

        private void btnSeeDesc_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pList[lbxItemCatalog.SelectedIndex].Description);
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            oosTab.SelectedTab = Checkout;
            lbxOrderSummary.Items.Clear();
            foreach (Product p in cart)
            {
                lbxOrderSummary.Items.Add(p);
            }
            tbxCheckoutTotalCost.Text = Product.CalculateCartValue(cart).ToString("C");
        }

        private void btnUseDefaultAddress_Click(object sender, EventArgs e)
        {
            if (Customer.activeCustomer != null)
            {
                tbxAddress.Text = Customer.activeCustomer.Address;
                tbxCity.Text = Customer.activeCustomer.City;
                tbxState.Text = Customer.activeCustomer.State;
                tbxZipCode.Text = Customer.activeCustomer.Zip;
            }
            else
            {
                MessageBox.Show("No default address found, please login or update your account.");
            }
        }
    }
}

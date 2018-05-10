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
    public partial class RemoveProductGUI : Form
    {
        DatabaseUtilities.DBConnection db = new DatabaseUtilities.DBConnection();
        List<Product> pList;
        private MainGUI parent;

        public RemoveProductGUI (MainGUI mgui)
        {
            InitializeComponent();
            this.parent = mgui;
        }

        public RemoveProductGUI()
        {
            InitializeComponent();
        }

        private void RemoveProductGUI_Load(object sender, EventArgs e)
        {
            lbxProductList.Items.Clear();
            pList = db.RetrieveProductsFromDatabase();
            foreach(Product prod in pList)
            {
                lbxProductList.Items.Add(prod);
            }
        }


        private void btnRemoveSelectedProduct_Click(object sender, EventArgs e)
        {
            if(lbxProductList.SelectedIndex > -1)
            {
                int prodId = pList[lbxProductList.SelectedIndex].Id;
                db.DeleteConditionFromTable("products", "productId =" + prodId);
                parent.updateProductLists();
                this.Close();
            }
        }
    }
}

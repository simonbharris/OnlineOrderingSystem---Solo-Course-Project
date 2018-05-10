namespace WindowsFormsApplication2
{
    partial class MainGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oosTab = new System.Windows.Forms.TabControl();
            this.tabCreateUser = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblActiveUser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateNewUser = new System.Windows.Forms.Button();
            this.tabCreateOrder = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeeDesc = new System.Windows.Forms.Button();
            this.tbxTotalCost = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRemoveItemFromCart = new System.Windows.Forms.Button();
            this.btnSubmitOrder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItemToCart = new System.Windows.Forms.Button();
            this.lbxItemCatalog = new System.Windows.Forms.ListBox();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.Checkout = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxCheckoutTotalCost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbxOrderSummary = new System.Windows.Forms.ListBox();
            this.btnUseDefaultAddress = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbpManageProducts = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbxProductList = new System.Windows.Forms.ListBox();
            this.btnModifyProduct = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.oosTab.SuspendLayout();
            this.tabCreateUser.SuspendLayout();
            this.tabCreateOrder.SuspendLayout();
            this.Checkout.SuspendLayout();
            this.tbpManageProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1162, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oosTab
            // 
            this.oosTab.Controls.Add(this.tabCreateUser);
            this.oosTab.Controls.Add(this.tabCreateOrder);
            this.oosTab.Controls.Add(this.Checkout);
            this.oosTab.Controls.Add(this.tbpManageProducts);
            this.oosTab.Location = new System.Drawing.Point(12, 27);
            this.oosTab.Name = "oosTab";
            this.oosTab.SelectedIndex = 0;
            this.oosTab.Size = new System.Drawing.Size(1138, 686);
            this.oosTab.TabIndex = 4;
            this.oosTab.SelectedIndexChanged += new System.EventHandler(this.oosTab_SelectedIndexChanged);
            // 
            // tabCreateUser
            // 
            this.tabCreateUser.Controls.Add(this.button1);
            this.tabCreateUser.Controls.Add(this.lblActiveUser);
            this.tabCreateUser.Controls.Add(this.label4);
            this.tabCreateUser.Controls.Add(this.label1);
            this.tabCreateUser.Controls.Add(this.btnLogin);
            this.tabCreateUser.Controls.Add(this.btnCreateNewUser);
            this.tabCreateUser.Location = new System.Drawing.Point(8, 39);
            this.tabCreateUser.Name = "tabCreateUser";
            this.tabCreateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateUser.Size = new System.Drawing.Size(1122, 639);
            this.tabCreateUser.TabIndex = 0;
            this.tabCreateUser.Text = "Create User";
            this.tabCreateUser.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 71);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // lblActiveUser
            // 
            this.lblActiveUser.AutoSize = true;
            this.lblActiveUser.Font = new System.Drawing.Font("Impact", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveUser.Location = new System.Drawing.Point(62, 457);
            this.lblActiveUser.Name = "lblActiveUser";
            this.lblActiveUser.Size = new System.Drawing.Size(123, 45);
            this.lblActiveUser.TabIndex = 4;
            this.lblActiveUser.Text = "No one";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Currently logged in as:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "Online Ordering System";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(284, 175);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 107);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateNewUser
            // 
            this.btnCreateNewUser.Location = new System.Drawing.Point(606, 175);
            this.btnCreateNewUser.Name = "btnCreateNewUser";
            this.btnCreateNewUser.Size = new System.Drawing.Size(219, 107);
            this.btnCreateNewUser.TabIndex = 0;
            this.btnCreateNewUser.Text = "Create new user";
            this.btnCreateNewUser.UseVisualStyleBackColor = true;
            this.btnCreateNewUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabCreateOrder
            // 
            this.tabCreateOrder.Controls.Add(this.label3);
            this.tabCreateOrder.Controls.Add(this.label2);
            this.tabCreateOrder.Controls.Add(this.btnSeeDesc);
            this.tabCreateOrder.Controls.Add(this.tbxTotalCost);
            this.tabCreateOrder.Controls.Add(this.label19);
            this.tabCreateOrder.Controls.Add(this.label18);
            this.tabCreateOrder.Controls.Add(this.label17);
            this.tabCreateOrder.Controls.Add(this.btnRemoveItemFromCart);
            this.tabCreateOrder.Controls.Add(this.btnSubmitOrder);
            this.tabCreateOrder.Controls.Add(this.label13);
            this.tabCreateOrder.Controls.Add(this.tbxQuantity);
            this.tabCreateOrder.Controls.Add(this.btnAddItemToCart);
            this.tabCreateOrder.Controls.Add(this.lbxItemCatalog);
            this.tabCreateOrder.Controls.Add(this.lbxCart);
            this.tabCreateOrder.Location = new System.Drawing.Point(8, 39);
            this.tabCreateOrder.Name = "tabCreateOrder";
            this.tabCreateOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateOrder.Size = new System.Drawing.Size(1122, 639);
            this.tabCreateOrder.TabIndex = 1;
            this.tabCreateOrder.Text = "Create Order";
            this.tabCreateOrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Catalog Controls";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cart Controls";
            // 
            // btnSeeDesc
            // 
            this.btnSeeDesc.Location = new System.Drawing.Point(877, 514);
            this.btnSeeDesc.Name = "btnSeeDesc";
            this.btnSeeDesc.Size = new System.Drawing.Size(207, 39);
            this.btnSeeDesc.TabIndex = 35;
            this.btnSeeDesc.Text = "See description";
            this.btnSeeDesc.UseVisualStyleBackColor = true;
            this.btnSeeDesc.Click += new System.EventHandler(this.btnSeeDesc_Click);
            // 
            // tbxTotalCost
            // 
            this.tbxTotalCost.Location = new System.Drawing.Point(69, 432);
            this.tbxTotalCost.Name = "tbxTotalCost";
            this.tbxTotalCost.ReadOnly = true;
            this.tbxTotalCost.Size = new System.Drawing.Size(100, 31);
            this.tbxTotalCost.TabIndex = 34;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(176, 435);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(110, 25);
            this.label19.TabIndex = 33;
            this.label19.Text = "Total Cost";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(611, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(156, 25);
            this.label18.TabIndex = 32;
            this.label18.Text = "Item Catalogue";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(54, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 25);
            this.label17.TabIndex = 31;
            this.label17.Text = "Cart";
            // 
            // btnRemoveItemFromCart
            // 
            this.btnRemoveItemFromCart.Location = new System.Drawing.Point(79, 512);
            this.btnRemoveItemFromCart.Name = "btnRemoveItemFromCart";
            this.btnRemoveItemFromCart.Size = new System.Drawing.Size(267, 43);
            this.btnRemoveItemFromCart.TabIndex = 30;
            this.btnRemoveItemFromCart.Text = "Remove Item from Order";
            this.btnRemoveItemFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveItemFromCart.Click += new System.EventHandler(this.btnRemoveItemFromCart_Click);
            // 
            // btnSubmitOrder
            // 
            this.btnSubmitOrder.Location = new System.Drawing.Point(458, 594);
            this.btnSubmitOrder.Name = "btnSubmitOrder";
            this.btnSubmitOrder.Size = new System.Drawing.Size(207, 39);
            this.btnSubmitOrder.TabIndex = 29;
            this.btnSubmitOrder.Text = "Submit Order";
            this.btnSubmitOrder.UseVisualStyleBackColor = true;
            this.btnSubmitOrder.Click += new System.EventHandler(this.btnSubmitOrder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(744, 478);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "Quantity";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Location = new System.Drawing.Point(638, 475);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(100, 31);
            this.tbxQuantity.TabIndex = 27;
            this.tbxQuantity.Text = "1";
            // 
            // btnAddItemToCart
            // 
            this.btnAddItemToCart.Location = new System.Drawing.Point(877, 469);
            this.btnAddItemToCart.Name = "btnAddItemToCart";
            this.btnAddItemToCart.Size = new System.Drawing.Size(207, 39);
            this.btnAddItemToCart.TabIndex = 26;
            this.btnAddItemToCart.Text = "Add item to order";
            this.btnAddItemToCart.UseVisualStyleBackColor = true;
            this.btnAddItemToCart.Click += new System.EventHandler(this.btnAddItemToCart_Click);
            // 
            // lbxItemCatalog
            // 
            this.lbxItemCatalog.FormattingEnabled = true;
            this.lbxItemCatalog.ItemHeight = 25;
            this.lbxItemCatalog.Items.AddRange(new object[] {
            "Example Catalog",
            "Item A | $2.00",
            "Item B | $3.98",
            "Item C | $29.98",
            "Item D | $7.00"});
            this.lbxItemCatalog.Location = new System.Drawing.Point(627, 47);
            this.lbxItemCatalog.Name = "lbxItemCatalog";
            this.lbxItemCatalog.Size = new System.Drawing.Size(392, 379);
            this.lbxItemCatalog.TabIndex = 25;
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 25;
            this.lbxCart.Location = new System.Drawing.Point(69, 47);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(392, 379);
            this.lbxCart.TabIndex = 24;
            // 
            // Checkout
            // 
            this.Checkout.Controls.Add(this.button7);
            this.Checkout.Controls.Add(this.label16);
            this.Checkout.Controls.Add(this.tbxCheckoutTotalCost);
            this.Checkout.Controls.Add(this.label15);
            this.Checkout.Controls.Add(this.lbxOrderSummary);
            this.Checkout.Controls.Add(this.btnUseDefaultAddress);
            this.Checkout.Controls.Add(this.label14);
            this.Checkout.Controls.Add(this.tbxZipCode);
            this.Checkout.Controls.Add(this.tbxState);
            this.Checkout.Controls.Add(this.tbxCity);
            this.Checkout.Controls.Add(this.tbxAddress);
            this.Checkout.Controls.Add(this.label9);
            this.Checkout.Controls.Add(this.label10);
            this.Checkout.Controls.Add(this.label11);
            this.Checkout.Controls.Add(this.label12);
            this.Checkout.Location = new System.Drawing.Point(8, 39);
            this.Checkout.Name = "Checkout";
            this.Checkout.Padding = new System.Windows.Forms.Padding(3);
            this.Checkout.Size = new System.Drawing.Size(1122, 639);
            this.Checkout.TabIndex = 2;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(661, 503);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(232, 66);
            this.button7.TabIndex = 40;
            this.button7.Text = "Confirm Order";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(246, 506);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "Total";
            // 
            // tbxCheckoutTotalCost
            // 
            this.tbxCheckoutTotalCost.Location = new System.Drawing.Point(122, 503);
            this.tbxCheckoutTotalCost.Name = "tbxCheckoutTotalCost";
            this.tbxCheckoutTotalCost.Size = new System.Drawing.Size(100, 31);
            this.tbxCheckoutTotalCost.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(106, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 25);
            this.label15.TabIndex = 34;
            this.label15.Text = "Order Summary";
            // 
            // lbxOrderSummary
            // 
            this.lbxOrderSummary.FormattingEnabled = true;
            this.lbxOrderSummary.ItemHeight = 25;
            this.lbxOrderSummary.Items.AddRange(new object[] {
            "Example Catalogue",
            "Item A | $2.00",
            "Item B | $3.98",
            "Item C | $29.98",
            "Item D | $7.00"});
            this.lbxOrderSummary.Location = new System.Drawing.Point(111, 285);
            this.lbxOrderSummary.Name = "lbxOrderSummary";
            this.lbxOrderSummary.Size = new System.Drawing.Size(346, 204);
            this.lbxOrderSummary.TabIndex = 33;
            // 
            // btnUseDefaultAddress
            // 
            this.btnUseDefaultAddress.Location = new System.Drawing.Point(384, 200);
            this.btnUseDefaultAddress.Name = "btnUseDefaultAddress";
            this.btnUseDefaultAddress.Size = new System.Drawing.Size(229, 40);
            this.btnUseDefaultAddress.TabIndex = 32;
            this.btnUseDefaultAddress.Text = "Use Default Address";
            this.btnUseDefaultAddress.UseVisualStyleBackColor = true;
            this.btnUseDefaultAddress.Click += new System.EventHandler(this.btnUseDefaultAddress_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(117, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "Shipping Info:";
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(595, 141);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(232, 31);
            this.tbxZipCode.TabIndex = 30;
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(111, 138);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(248, 31);
            this.tbxState.TabIndex = 29;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(595, 86);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(232, 31);
            this.tbxCity.TabIndex = 28;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(111, 86);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(248, 31);
            this.tbxAddress.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(849, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 31);
            this.label9.TabIndex = 26;
            this.label9.Text = "Zip Code";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(379, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "State (Abbv.)";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(849, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 31);
            this.label11.TabIndex = 24;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(379, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 31);
            this.label12.TabIndex = 23;
            this.label12.Text = "Address";
            // 
            // tbpManageProducts
            // 
            this.tbpManageProducts.Controls.Add(this.label22);
            this.tbpManageProducts.Controls.Add(this.label21);
            this.tbpManageProducts.Controls.Add(this.lbxProductList);
            this.tbpManageProducts.Controls.Add(this.btnModifyProduct);
            this.tbpManageProducts.Controls.Add(this.btnRemoveProduct);
            this.tbpManageProducts.Controls.Add(this.btnAddProduct);
            this.tbpManageProducts.Location = new System.Drawing.Point(8, 39);
            this.tbpManageProducts.Name = "tbpManageProducts";
            this.tbpManageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tbpManageProducts.Size = new System.Drawing.Size(1122, 639);
            this.tbpManageProducts.TabIndex = 3;
            this.tbpManageProducts.Text = "Manage Products";
            this.tbpManageProducts.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(200, 70);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(126, 25);
            this.label22.TabIndex = 28;
            this.label22.Text = "Product List";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(627, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(212, 25);
            this.label21.TabIndex = 27;
            this.label21.Text = "Product List Controls";
            // 
            // lbxProductList
            // 
            this.lbxProductList.FormattingEnabled = true;
            this.lbxProductList.ItemHeight = 25;
            this.lbxProductList.Items.AddRange(new object[] {
            "Example Catalogue",
            "Item A | $2.00",
            "Item B | $3.98",
            "Item C | $29.98",
            "Item D | $7.00"});
            this.lbxProductList.Location = new System.Drawing.Point(205, 98);
            this.lbxProductList.Name = "lbxProductList";
            this.lbxProductList.Size = new System.Drawing.Size(392, 379);
            this.lbxProductList.TabIndex = 26;
            // 
            // btnModifyProduct
            // 
            this.btnModifyProduct.Location = new System.Drawing.Point(632, 257);
            this.btnModifyProduct.Name = "btnModifyProduct";
            this.btnModifyProduct.Size = new System.Drawing.Size(195, 56);
            this.btnModifyProduct.TabIndex = 2;
            this.btnModifyProduct.Text = "Modify";
            this.btnModifyProduct.UseVisualStyleBackColor = true;
            this.btnModifyProduct.Click += new System.EventHandler(this.btnModifyProduct_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(632, 201);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(195, 50);
            this.btnRemoveProduct.TabIndex = 1;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(632, 142);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(195, 53);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 725);
            this.Controls.Add(this.oosTab);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainGUI";
            this.Text = "Online Ordering System";
            this.Activated += new System.EventHandler(this.MainGUI_Activated);
            this.Load += new System.EventHandler(this.MainGUI_Load);
            this.oosTab.ResumeLayout(false);
            this.tabCreateUser.ResumeLayout(false);
            this.tabCreateUser.PerformLayout();
            this.tabCreateOrder.ResumeLayout(false);
            this.tabCreateOrder.PerformLayout();
            this.Checkout.ResumeLayout(false);
            this.Checkout.PerformLayout();
            this.tbpManageProducts.ResumeLayout(false);
            this.tbpManageProducts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl oosTab;
        private System.Windows.Forms.TabPage tabCreateUser;
        private System.Windows.Forms.TabPage tabCreateOrder;
        private System.Windows.Forms.ListBox lbxItemCatalog;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.TextBox tbxTotalCost;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRemoveItemFromCart;
        private System.Windows.Forms.Button btnSubmitOrder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Button btnAddItemToCart;
        private System.Windows.Forms.TabPage Checkout;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxCheckoutTotalCost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbxOrderSummary;
        private System.Windows.Forms.Button btnUseDefaultAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tbpManageProducts;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox lbxProductList;
        private System.Windows.Forms.Button btnModifyProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateNewUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeeDesc;
        private  System.Windows.Forms.Label lblActiveUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}


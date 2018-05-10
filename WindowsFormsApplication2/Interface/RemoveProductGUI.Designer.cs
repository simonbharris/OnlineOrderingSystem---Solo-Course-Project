namespace WindowsFormsApplication2.Interface
{
    partial class RemoveProductGUI
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
            this.lbxProductList = new System.Windows.Forms.ListBox();
            this.btnRemoveSelectedProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxProductList
            // 
            this.lbxProductList.FormattingEnabled = true;
            this.lbxProductList.ItemHeight = 25;
            this.lbxProductList.Location = new System.Drawing.Point(37, 34);
            this.lbxProductList.Name = "lbxProductList";
            this.lbxProductList.Size = new System.Drawing.Size(390, 279);
            this.lbxProductList.TabIndex = 0;
            // 
            // btnRemoveSelectedProduct
            // 
            this.btnRemoveSelectedProduct.Location = new System.Drawing.Point(72, 334);
            this.btnRemoveSelectedProduct.Name = "btnRemoveSelectedProduct";
            this.btnRemoveSelectedProduct.Size = new System.Drawing.Size(309, 48);
            this.btnRemoveSelectedProduct.TabIndex = 1;
            this.btnRemoveSelectedProduct.Text = "Remove Selected Product";
            this.btnRemoveSelectedProduct.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedProduct.Click += new System.EventHandler(this.btnRemoveSelectedProduct_Click);
            // 
            // RemoveProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 403);
            this.Controls.Add(this.btnRemoveSelectedProduct);
            this.Controls.Add(this.lbxProductList);
            this.Name = "RemoveProductGUI";
            this.Text = "Remove Product";
            this.Load += new System.EventHandler(this.RemoveProductGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxProductList;
        private System.Windows.Forms.Button btnRemoveSelectedProduct;
    }
}
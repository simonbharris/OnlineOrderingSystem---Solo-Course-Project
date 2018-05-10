namespace WindowsFormsApplication2.Interface
{
    partial class ModifyProductGUI
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.RichTextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(244, 334);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(174, 70);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Update Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(107, 152);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(475, 159);
            this.tbxDescription.TabIndex = 12;
            this.tbxDescription.Text = "";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(455, 55);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(127, 31);
            this.tbxPrice.TabIndex = 11;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(107, 55);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(301, 31);
            this.tbxProductName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Product Name";
            // 
            // ModifyProductGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 436);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyProductGUI";
            this.Text = "Modify Product";
            this.Load += new System.EventHandler(this.ModifyProductGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.RichTextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
namespace WindowsFormsApplication2.Interface
{
    partial class UpdateUserGUI
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
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(358, 347);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(232, 43);
            this.btnUpdateUser.TabIndex = 48;
            this.btnUpdateUser.Text = "Update Info";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(536, 260);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(232, 31);
            this.tbxZipCode.TabIndex = 47;
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(52, 257);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(248, 31);
            this.tbxState.TabIndex = 46;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(536, 205);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(232, 31);
            this.tbxCity.TabIndex = 45;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(52, 205);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(248, 31);
            this.tbxAddress.TabIndex = 44;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(52, 148);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(248, 31);
            this.tbxPhone.TabIndex = 43;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(536, 99);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(232, 31);
            this.tbxLastName.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(790, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 41;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(320, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 40;
            this.label7.Text = "State (Abbv.)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(790, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 31);
            this.label6.TabIndex = 39;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(320, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(320, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Phone";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(790, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Last Name*";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(320, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "First Name*";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(52, 99);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(248, 31);
            this.tbxFirstName.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Logged in as;";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(201, 34);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(70, 25);
            this.lblEmail.TabIndex = 50;
            this.lblEmail.Text = "label9";
            // 
            // UpdateUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 425);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.tbxZipCode);
            this.Controls.Add(this.tbxState);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFirstName);
            this.Name = "UpdateUserGUI";
            this.Text = "UpdateUserGUI";
            this.Load += new System.EventHandler(this.UpdateUserGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
    }
}
namespace WindowsFormsApplication2
{
    partial class CreateNewUserGUI
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbxZipCode = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Create User";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddUser);
            // 
            // tbxZipCode
            // 
            this.tbxZipCode.Location = new System.Drawing.Point(524, 313);
            this.tbxZipCode.Name = "tbxZipCode";
            this.tbxZipCode.Size = new System.Drawing.Size(232, 31);
            this.tbxZipCode.TabIndex = 31;
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(40, 310);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(248, 31);
            this.tbxState.TabIndex = 30;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(524, 258);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(232, 31);
            this.tbxCity.TabIndex = 29;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(40, 258);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(248, 31);
            this.tbxAddress.TabIndex = 28;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(40, 201);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(248, 31);
            this.tbxPhone.TabIndex = 27;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(40, 56);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(248, 31);
            this.tbxEmail.TabIndex = 26;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(524, 102);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(232, 31);
            this.tbxLastName.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(778, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 31);
            this.label8.TabIndex = 24;
            this.label8.Text = "Zip Code";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(308, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 31);
            this.label7.TabIndex = 23;
            this.label7.Text = "State (Abbv.)";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(778, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 31);
            this.label6.TabIndex = 22;
            this.label6.Text = "City";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(308, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 21;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(308, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(308, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "E-Mail* (Will be used as login name)";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(778, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Last Name*";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(308, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name*";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(40, 102);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(248, 31);
            this.tbxFirstName.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(327, 25);
            this.label9.TabIndex = 33;
            this.label9.Text = "Fields marked with * are required";
            // 
            // CreateNewUserGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 472);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxZipCode);
            this.Controls.Add(this.tbxState);
            this.Controls.Add(this.tbxCity);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxFirstName);
            this.Name = "CreateNewUserGUI";
            this.Text = "Create New User";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxZipCode;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label label9;
    }
}
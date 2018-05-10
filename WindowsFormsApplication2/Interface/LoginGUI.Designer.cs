namespace WindowsFormsApplication2
{
    partial class LoginGUI
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
            this.lbxUsers = new System.Windows.Forms.ListBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxUsers
            // 
            this.lbxUsers.FormattingEnabled = true;
            this.lbxUsers.ItemHeight = 25;
            this.lbxUsers.Location = new System.Drawing.Point(56, 36);
            this.lbxUsers.Name = "lbxUsers";
            this.lbxUsers.Size = new System.Drawing.Size(474, 304);
            this.lbxUsers.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(182, 355);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(232, 62);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbxUsers);
            this.Name = "LoginGUI";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.UserListGUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxUsers;
        private System.Windows.Forms.Button btnLogin;
    }
}
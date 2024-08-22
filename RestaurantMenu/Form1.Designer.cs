namespace RestaurantMenu
{
    partial class Form1
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
            this.p1buttonClose = new System.Windows.Forms.Button();
            this.p1labelPassword = new System.Windows.Forms.Label();
            this.p1labelName = new System.Windows.Forms.Label();
            this.p1textBoxPassword = new System.Windows.Forms.TextBox();
            this.p1textBoxName = new System.Windows.Forms.TextBox();
            this.p1linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.p1buttonLogin = new System.Windows.Forms.Button();
            this.p1RestaurantTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1buttonClose
            // 
            this.p1buttonClose.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1buttonClose.Location = new System.Drawing.Point(254, 392);
            this.p1buttonClose.Name = "p1buttonClose";
            this.p1buttonClose.Size = new System.Drawing.Size(416, 49);
            this.p1buttonClose.TabIndex = 13;
            this.p1buttonClose.Text = "Close the application";
            this.p1buttonClose.UseVisualStyleBackColor = true;
            this.p1buttonClose.Click += new System.EventHandler(this.p1buttonClose_Click);
            // 
            // p1labelPassword
            // 
            this.p1labelPassword.AutoSize = true;
            this.p1labelPassword.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1labelPassword.Location = new System.Drawing.Point(139, 164);
            this.p1labelPassword.Name = "p1labelPassword";
            this.p1labelPassword.Size = new System.Drawing.Size(172, 32);
            this.p1labelPassword.TabIndex = 12;
            this.p1labelPassword.Text = "Password :";
            // 
            // p1labelName
            // 
            this.p1labelName.AutoSize = true;
            this.p1labelName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1labelName.Location = new System.Drawing.Point(132, 114);
            this.p1labelName.Name = "p1labelName";
            this.p1labelName.Size = new System.Drawing.Size(179, 32);
            this.p1labelName.TabIndex = 11;
            this.p1labelName.Text = "Username :";
            // 
            // p1textBoxPassword
            // 
            this.p1textBoxPassword.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1textBoxPassword.Location = new System.Drawing.Point(333, 158);
            this.p1textBoxPassword.Name = "p1textBoxPassword";
            this.p1textBoxPassword.Size = new System.Drawing.Size(213, 38);
            this.p1textBoxPassword.TabIndex = 10;
            this.p1textBoxPassword.UseSystemPasswordChar = true;
            // 
            // p1textBoxName
            // 
            this.p1textBoxName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1textBoxName.Location = new System.Drawing.Point(333, 108);
            this.p1textBoxName.Name = "p1textBoxName";
            this.p1textBoxName.Size = new System.Drawing.Size(213, 38);
            this.p1textBoxName.TabIndex = 9;
            // 
            // p1linkCreateAccount
            // 
            this.p1linkCreateAccount.AutoSize = true;
            this.p1linkCreateAccount.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.p1linkCreateAccount.Location = new System.Drawing.Point(115, 306);
            this.p1linkCreateAccount.Name = "p1linkCreateAccount";
            this.p1linkCreateAccount.Size = new System.Drawing.Size(455, 20);
            this.p1linkCreateAccount.TabIndex = 8;
            this.p1linkCreateAccount.TabStop = true;
            this.p1linkCreateAccount.Text = "If you do not have an account, click to create one.\r\n";
            this.p1linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.p1linkCreateAccount_LinkClicked);
            // 
            // p1buttonLogin
            // 
            this.p1buttonLogin.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1buttonLogin.Location = new System.Drawing.Point(333, 217);
            this.p1buttonLogin.Name = "p1buttonLogin";
            this.p1buttonLogin.Size = new System.Drawing.Size(213, 50);
            this.p1buttonLogin.TabIndex = 7;
            this.p1buttonLogin.Text = "Login";
            this.p1buttonLogin.UseVisualStyleBackColor = true;
            this.p1buttonLogin.Click += new System.EventHandler(this.p1buttonLogin_Click);
            // 
            // p1RestaurantTitle
            // 
            this.p1RestaurantTitle.AutoSize = true;
            this.p1RestaurantTitle.Font = new System.Drawing.Font("Harlow Solid Italic", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1RestaurantTitle.ForeColor = System.Drawing.Color.Red;
            this.p1RestaurantTitle.Location = new System.Drawing.Point(109, 9);
            this.p1RestaurantTitle.Name = "p1RestaurantTitle";
            this.p1RestaurantTitle.Size = new System.Drawing.Size(489, 59);
            this.p1RestaurantTitle.TabIndex = 14;
            this.p1RestaurantTitle.Text = "XXX Restaurant Menu";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.p1RestaurantTitle);
            this.Controls.Add(this.p1buttonClose);
            this.Controls.Add(this.p1labelPassword);
            this.Controls.Add(this.p1labelName);
            this.Controls.Add(this.p1textBoxPassword);
            this.Controls.Add(this.p1textBoxName);
            this.Controls.Add(this.p1linkCreateAccount);
            this.Controls.Add(this.p1buttonLogin);
            this.MaximumSize = new System.Drawing.Size(700, 500);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button p1buttonClose;
        private System.Windows.Forms.Label p1labelPassword;
        private System.Windows.Forms.Label p1labelName;
        private System.Windows.Forms.TextBox p1textBoxPassword;
        private System.Windows.Forms.TextBox p1textBoxName;
        private System.Windows.Forms.LinkLabel p1linkCreateAccount;
        private System.Windows.Forms.Button p1buttonLogin;
        private System.Windows.Forms.Label p1RestaurantTitle;
    }
}


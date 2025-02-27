namespace InvestInMe_Mini_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblUser = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblPassword = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txtUsername = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.headerTitle = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.lblDisclaimer = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(165, 424);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 48);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUser
            // 
            this.lblUser.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblUser.Location = new System.Drawing.Point(39, 237);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(72, 20);
            this.lblUser.TabIndex = 1;
            this.lblUser.Values.Text = "Username: ";
            // 
            // lblPassword
            // 
            this.lblPassword.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.BoldControl;
            this.lblPassword.Location = new System.Drawing.Point(42, 342);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 20);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Values.Text = "Password: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(128, 234);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(251, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 339);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(251, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // headerTitle
            // 
            this.headerTitle.Location = new System.Drawing.Point(85, 77);
            this.headerTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerTitle.Name = "headerTitle";
            this.headerTitle.Size = new System.Drawing.Size(312, 44);
            this.headerTitle.TabIndex = 5;
            this.headerTitle.Values.Description = "Learn Financial Freedom";
            this.headerTitle.Values.Heading = "InvestInMe";
            this.headerTitle.Values.Image = ((System.Drawing.Image)(resources.GetObject("headerTitle.Values.Image")));
            // 
            // lblDisclaimer
            // 
            this.lblDisclaimer.Location = new System.Drawing.Point(175, 522);
            this.lblDisclaimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDisclaimer.Name = "lblDisclaimer";
            this.lblDisclaimer.Size = new System.Drawing.Size(137, 20);
            this.lblDisclaimer.TabIndex = 6;
            this.lblDisclaimer.Values.Text = "This is just a prototype.";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(492, 619);
            this.Controls.Add(this.lblDisclaimer);
            this.Controls.Add(this.headerTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblUser;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUsername;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader headerTitle;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblDisclaimer;
    }
}


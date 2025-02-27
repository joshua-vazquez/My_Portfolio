using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestInMe_Mini_Project
{
    public partial class Login: Form
    {
        private User user;
        public Login()
        {
            InitializeComponent();
            user = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;

            if (user.ValidateCredentials(userName, password))
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Landing landing = new Landing();
                landing.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValorantApp.Model;
using User = ValorantApp.Model.User;

namespace ValorantApp.Authentication
{
    public partial class FormChangeUserName : Form
    {

        public List<User> users = new List<User>();
        public string oldUsername { get; set; } = string.Empty;
        public string newUsername { get; set; } = string.Empty;
        public string newPassword { get; set; } = string.Empty;

        public FormChangeUserName(List<User> users)
        {
            this.users = users;
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string oldUsername = textboxUserName.Text;
            string oldPassword = textboxPassword.Text;
            string newUsername = textBoxNewUser.Text;
            string newPassword = textBoxNewPassword.Text;

            var user = users.FirstOrDefault(p => p.UserName == newUsername);

            if (string.IsNullOrWhiteSpace(oldUsername))
            {
                MessageBox.Show("Username is empty or has white-space");
                textboxUserName.Focus();
            }
            else if (string.IsNullOrWhiteSpace(oldPassword))
            {
                MessageBox.Show("Password is empty or has white-space");
                textboxPassword.Focus();
            }
            else if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("New Username is empty or has white-space");
                textBoxNewUser.Focus();
            }
            else if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("New Password is empty or has white-space");
                textBoxNewPassword.Focus();
            }
            else if (oldUsername == newUsername && oldPassword == newPassword)
            {
                MessageBox.Show("Both username and password are the same, please change one of them");
            }
            else if (user?.UserName == newUsername)
            {
                MessageBox.Show("This new username account already exists.");
            }
            else
            {
                this.newUsername = newUsername;
                this.newPassword = newPassword;
                this.oldUsername = oldUsername;

                MessageBox.Show("Change Successfully");

                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void cancelChangeUsername_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

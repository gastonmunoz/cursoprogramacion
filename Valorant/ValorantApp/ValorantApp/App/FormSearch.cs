using ValorantApp.Authentication;
using ValorantApp.Helper;
using ValorantApp.Model;

namespace ValorantApp.App
{
    public partial class FormSearch : Form
    {

        public List<User> users = new List<User>();

        public FormSearch(List<User> users)
        {
            this.users = users;
            InitializeComponent();
        }

        private void buttonChangeUserPassword_Click(object sender, EventArgs e)
        {
            FormChangeUserName formChangeUserName = new FormChangeUserName(users);
            DialogResult result = formChangeUserName.ShowDialog();

            if (result == DialogResult.OK)
            {
                var user = users.FirstOrDefault(p => p.UserName == formChangeUserName.oldUsername);  //internamente hace un forEach y devuelve un valor

                if (user != null)
                {
                    user.UserName = formChangeUserName.newUsername; //modifica directo el elemento de la lista
                    user.Password = formChangeUserName.newPassword;
                    JsonHelper.SaveUsersToJson(users);
                }
            }
        }
    }
}

using System.Text.Json;
using ValorantApp.App;
using ValorantApp.Authentication;
using ValorantApp.Model;

namespace ValorantApp
{
    public partial class FormPrincipal : Form
    {
        public List<User> users = new List<User>();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            if (formSignUp.ShowDialog() == DialogResult.OK)
            {
                AddUser(new User(formSignUp.userName, formSignUp.password));
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            User user = users.FirstOrDefault(p => p.UserName == textBoxUser.Text && p.Password == textBoxPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Usuario/contraseña inválidos", "Error");
            }
            else
            {
                FormSearch formSearch = new FormSearch();
                formSearch.ShowDialog();
            }
        }

        private void AddUser(User user)
        {
            users.Add(user);
            SaveUsersToJson();
        }

        private void SaveUsersToJson()
        {
            if(!Directory.Exists($"{Directory.GetCurrentDirectory()}\\data"))
            {
                Directory.CreateDirectory($"{Directory.GetCurrentDirectory()}\\data");
            }

            var json = JsonSerializer.Serialize(users);
            File.WriteAllText($"{Directory.GetCurrentDirectory()}\\data\\users.json", json);
        }

        private void ReadUsers()
        {
            if (Directory.Exists($"{Directory.GetCurrentDirectory()}\\data"))
            {
                var json = File.ReadAllText($"{Directory.GetCurrentDirectory()}\\data\\users.json");
                users = JsonSerializer.Deserialize<List<User>>(json);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ReadUsers();
        }
    }
}
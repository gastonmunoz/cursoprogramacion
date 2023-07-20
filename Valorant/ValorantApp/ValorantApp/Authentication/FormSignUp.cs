using ValorantApp.App;

namespace ValorantApp.Authentication
{
    public partial class FormSignUp : Form
    {
        public string userName { get; set; }
        public string password { get; set; }

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            userName = textBoxUser.Text;
            password = textBoxPassword.Text;
            DialogResult = DialogResult.OK;
            Close();
            FormSearch formSearch = new FormSearch();
            formSearch.ShowDialog();
        }
    }
}

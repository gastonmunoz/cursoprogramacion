namespace WinFormsApp1
{
    public partial class FormAgregar : Form
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string googleMaps { get; set; }

        public FormAgregar()
        {
            InitializeComponent();
        }
        private void textboxAceptar_Click(object sender, EventArgs e)
        {
            nombre = textboxNombre.Text;
            direccion = textboxDireccion.Text;
            googleMaps = textboxGoogleMaps.Text;
            if (string.IsNullOrWhiteSpace(nombre)) //busco errores
            {
                string mensaje = "Pone nombre";
                string titulo = "BE CAREFUL";
                MessageBox.Show(mensaje, titulo);
                textboxNombre.Focus();
            }
            else if (string.IsNullOrWhiteSpace(direccion))
            {
                string mensaje = "Pone direccion";
                string titulo = "BE CAREFUL";
                MessageBox.Show(mensaje, titulo);
                textboxDireccion.Focus();
            }
            else if ((string.IsNullOrWhiteSpace(googleMaps) || !(Uri.IsWellFormedUriString(googleMaps, UriKind.RelativeOrAbsolute)) 
                || !(googleMaps.StartsWith("https://google.com/maps") || googleMaps.StartsWith("https://goo.gl/maps"))))
            {
                string mensaje = "Pone el link valido";
                string titulo = "BE CAREFUL";
                MessageBox.Show(mensaje, titulo);
                textboxGoogleMaps.Focus();
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            textboxNombre.Text = nombre;
            textboxDireccion.Text = direccion;
            textboxGoogleMaps.Text = googleMaps;
        }

        private void textboxCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; Close();
        }
    }
}

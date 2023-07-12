using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FormAgregar : Form
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            nombre = textBoxNombre.Text;
            descripcion = textBoxDescripcion.Text;
            email = textBoxEmail.Text;
            telefono = textBoxTelefono.Text;
            var funciones = new Funciones();
            // CORROBORA QUE EL DATO NO SEA NULL VACIO O SIN CARACTER Y QUE SOLO SEA LETRAS
            if (string.IsNullOrWhiteSpace(nombre) || int.TryParse(nombre, out _))
            {
                funciones.errorMensaje("Solamente letras por favor.");
            }
            else if (string.IsNullOrWhiteSpace(descripcion))
            {
                funciones.errorMensaje("Error al completar Descripcion.");
            }
            else if (!funciones.emailValido(email))
            {
                funciones.errorMensaje("Error al completar el email. No contiene @");
            }
            // INTENTA CONVERTIR EL DATO A NUMERO, SI NO PUEDE SALE El MENSAJE
            else if (string.IsNullOrWhiteSpace(telefono) || !int.TryParse(telefono, out _))
            {
                funciones.errorMensaje("Error al completar el Telefono. Ingrese solamente Numeros.");
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        // BOTON CANCELAR
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        // BOTON AGREGAR
        private void FormAgregar_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = nombre;
            textBoxDescripcion.Text = descripcion;
            textBoxEmail.Text = email;
            textBoxTelefono.Text = telefono;
        }
    }
}

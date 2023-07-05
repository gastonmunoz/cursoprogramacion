using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vacaciones
{
    public partial class FormEdicion : Form
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string empleada { get; set; }
        public DateTime fechaDesde { get; set; } = DateTime.Now;
        public DateTime fechaHasta { get; set; } = DateTime.Now.AddDays(1);
        public FormEdicion()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            nombre = textBoxNombre.Text;
            descripcion = textBoxDescripcion.Text;
            empleada = comboBoxEmpleadas.Text;
            fechaDesde = dateTimeDesde.Value;
            fechaHasta = dateTimeHasta.Value;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                mostrarErrorYHacerFoco($"{labelNombre.Text} no puede estar vacio", textBoxNombre);
            }
            else if (string.IsNullOrWhiteSpace(descripcion)) 
            {
                mostrarErrorYHacerFoco($"{labelDescripcion.Text} no puede estar vacio", textBoxDescripcion);
            }
            else if (string.IsNullOrWhiteSpace(empleada))
            {
                mostrarErrorYHacerFoco($"{labelEmpleada.Text} no puede estar vacio", comboBoxEmpleadas);
            }
            else if (fechaDesde < DateTime.Now.AddDays(-1))
            {
                mostrarErrorYHacerFoco($"{labelDesde.Text} no puede ser menor a hoy", dateTimeDesde);
            }
            else if (fechaHasta < fechaDesde)
            {
                mostrarErrorYHacerFoco($"{labelHasta.Text} no puede ser menor {labelDesde.Text}", dateTimeHasta);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; 
            Close();    
        }

        private void FormEdicion_Load(object sender, EventArgs e)
        {
            textBoxNombre.Text = nombre;
            textBoxDescripcion.Text = descripcion;
            comboBoxEmpleadas.Text = empleada;
            dateTimeDesde.Value = fechaDesde;
            dateTimeHasta.Value = fechaHasta;
        }

        private void mostrarErrorYHacerFoco(string mensaje, System.Windows.Forms.Control control) 
        {
            MessageBox.Show(mensaje);
            control.Focus();
        }
    }
}

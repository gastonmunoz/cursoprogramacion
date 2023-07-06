using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vacaciones
{
    public partial class Form1 : Form
    {
        private int Id = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            mostrarFormEdicion(true);
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridVacaciones.CurrentCell.RowIndex >= 0 &&
                dataGridVacaciones.CurrentCell.RowIndex < dataGridVacaciones.Rows.Count-1)  
            {
                mostrarFormEdicion(false);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridVacaciones.CurrentCell.RowIndex >= 0 &&
                dataGridVacaciones.CurrentCell.RowIndex < dataGridVacaciones.Rows.Count - 1)
            {
                dataGridVacaciones.Rows.RemoveAt(dataGridVacaciones.CurrentRow.Index);
            }
        }

        private void habilitarCampos(bool editado)
        {
            buttonEliminar.Enabled = editado;
            buttonModificar.Enabled = editado;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void mostrarFormEdicion(bool esAlta) 
        {
            FormEdicion formEdicion = new FormEdicion();
            if (!esAlta)
            {
                formEdicion.nombre = dataGridVacaciones.CurrentRow.Cells[1].Value.ToString();
                formEdicion.descripcion = dataGridVacaciones.CurrentRow.Cells[2].Value.ToString();
                formEdicion.empleada = dataGridVacaciones.CurrentRow.Cells[3].Value.ToString();
                formEdicion.fechaDesde = DateTime.Parse(dataGridVacaciones.CurrentRow.Cells[4].Value.ToString());
                formEdicion.fechaHasta = DateTime.Parse(dataGridVacaciones.CurrentRow.Cells[5].Value.ToString());
            }
            var result = formEdicion.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (esAlta)
                {
                    dataGridVacaciones.Rows.Add(Id, formEdicion.nombre, formEdicion.descripcion, formEdicion.empleada, formEdicion.fechaDesde.ToShortDateString(), formEdicion.fechaHasta.ToShortDateString()) ;
                    Id++;
                    habilitarCampos(true);
                }
                else
                {
                    dataGridVacaciones.CurrentRow.Cells[1].Value = formEdicion.nombre;
                    dataGridVacaciones.CurrentRow.Cells[2].Value = formEdicion.descripcion;
                    dataGridVacaciones.CurrentRow.Cells[3].Value = formEdicion.empleada;
                    dataGridVacaciones.CurrentRow.Cells[4].Value = formEdicion.fechaDesde.ToShortDateString();
                    dataGridVacaciones.CurrentRow.Cells[5].Value = formEdicion.fechaHasta.ToShortDateString();
                }
            }
        }
    }
}
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private int id = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar form = new FormAgregar();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                string nombre = form.nombre;
                string descripcion = form.descripcion;
                string email = form.email;
                string telefono = form.telefono;

                dataGridView1.Rows.Add(id, nombre, descripcion, email, telefono);
                id++;
            }
        }

        // BOTON MODIFICAR
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value != null)
            { //corrobora que la fila tenga datos
                FormAgregar form = new FormAgregar();
                form.nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                form.descripcion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                form.email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                form.telefono = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    dataGridView1.CurrentRow.Cells[1].Value = form.nombre;
                    dataGridView1.CurrentRow.Cells[2].Value = form.descripcion;
                    dataGridView1.CurrentRow.Cells[3].Value = form.email;
                    dataGridView1.CurrentRow.Cells[4].Value = form.telefono;
                }
            }
        }
        //BOTON ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {       // ELIMINA LA FILA SELECCIONANDO LA MISMA O ESTANDO POSICIONADO EN UNA CELDA CUALQUIERA
            // Crea una lista para agregar rows que se deletean
            List<DataGridViewRow> rowsAEliminar = new List<DataGridViewRow>();
            // Recorre todas las filas del DataGridView utilizando foreach
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    // Recorre todas las celdas de la fila actual
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // Comprueba si la celda actual está seleccionada
                        if (cell.Selected)
                        {
                            // Agrega la fila a la lista de filas a eliminar
                            rowsAEliminar.Add(row);
                            break; // Sale del bucle foreach de filas después de agregar la fila
                        }
                    }
                }
            }

            foreach (DataGridViewRow rowAEliminar in rowsAEliminar)
            {
                dataGridView1.Rows.Remove(rowAEliminar);
            }
        }
    }
}
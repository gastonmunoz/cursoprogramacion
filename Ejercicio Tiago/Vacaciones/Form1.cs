using System.Text.Json;
using System.Windows.Forms;

namespace Vacaciones
{
    public partial class Form1 : Form
    {
        private int Id = 1;
        private string carpetaActual = Path.GetDirectoryName(Application.ExecutablePath);
        private string nombreArchivoData;
        public List<Vacacion> lista = new List<Vacacion>();
        public Form1()
        {
            nombreArchivoData = $"{carpetaActual}\\data.json";
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
            else
            {
                mostrarError("No hay filas para modificar");
            }
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {       // ELIMINA LA FILA SELECCIONANDO LA MISMA O ESTANDO POSICIONADO EN UNA CELDA CUALQUIERA
            // Crea una lista para agregar rows que se deletean
            List<DataGridViewRow> rowsAEliminar = new List<DataGridViewRow>();
            // Recorre todas las filas del DataGridView utilizando foreach
            foreach (DataGridViewRow row in dataGridVacaciones.Rows)
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
                else if (dataGridVacaciones.CurrentCell.RowIndex == dataGridVacaciones.Rows.Count - 1)
                {
                    mostrarError("No se puede eliminar filas vacias");
                }
            }
            foreach (DataGridViewRow rowAEliminar in rowsAEliminar)
            {
                dataGridVacaciones.Rows.Remove(rowAEliminar);
            }
        }
        private void habilitarCampos(bool editado)
        {
            buttonEliminar.Enabled = editado;
            buttonModificar.Enabled = editado;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(nombreArchivoData))
            {
                string json = File.ReadAllText(nombreArchivoData);
                try
                {
                    lista = JsonSerializer.Deserialize<List<Vacacion>>(json);

                    foreach (var vacacion in lista)
                    {
                        dataGridVacaciones.Rows.Add(vacacion.id, vacacion.nombre, vacacion.descripcion, vacacion.empleada, vacacion.fechaDesde.ToShortDateString(), vacacion.fechaHasta.ToShortDateString());
                        Id = vacacion.id + 1;
                    }
                    habilitarCampos(true);
                }
                catch (Exception)
                {
                    mostrarError("Falló la carga del la base de datos");
                }
            }
            else
            {
                habilitarCampos(false);
            }
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
                    dataGridVacaciones.Rows.Add(Id, formEdicion.nombre, formEdicion.descripcion, formEdicion.empleada, formEdicion.fechaDesde.ToShortDateString(), formEdicion.fechaHasta.ToShortDateString());
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
        private void buttonExportar_Click(object sender, EventArgs e)
        {
            if (dataGridVacaciones.Rows.Count > 1 || (dataGridVacaciones.Rows.Count == 1 && MessageBox.Show("Esta seguro de guardar vacio?", "Cuidado!", MessageBoxButtons.OKCancel) == DialogResult.OK))
            {
                lista = new List<Vacacion>();
                //Recorrer toda la grilla, campo por campo, y guardarlo en un JSON.
                int fila = dataGridVacaciones.Rows.GetFirstRow(DataGridViewElementStates.None);
                while (fila < dataGridVacaciones.Rows.Count - 1)
                {
                    var row = dataGridVacaciones.Rows[fila];
                    Vacacion cadavacacion = new Vacacion();
                    cadavacacion.id = Int32.Parse(row.Cells[0].Value.ToString());
                    cadavacacion.nombre = row.Cells[1].Value.ToString();
                    cadavacacion.descripcion = row.Cells[2].Value.ToString();
                    cadavacacion.empleada = row.Cells[3].Value.ToString();
                    cadavacacion.fechaDesde = DateTime.Parse(row.Cells[4].Value.ToString());
                    cadavacacion.fechaHasta = DateTime.Parse(row.Cells[5].Value.ToString());
                    lista.Add(cadavacacion);
                    fila = dataGridVacaciones.Rows.GetNextRow(fila, DataGridViewElementStates.None);
                }
                //guardarlo en json
                string json = JsonSerializer.Serialize(lista);
                File.WriteAllText(nombreArchivoData, json);
                MessageBox.Show("Stock guardado correctamente", "Informacion");
            }
        }
        private void dataGridVacaciones_SelectionChanged(object sender, EventArgs e) 
        { 
            buttonModificar.Enabled = (dataGridVacaciones.SelectedRows.Count == 1) && (dataGridVacaciones.CurrentRow !=null) && (dataGridVacaciones.CurrentRow.Index != dataGridVacaciones.Rows.Count - 1);
        }
        private void mostrarError(string mensaje) 
        {
            MessageBox.Show(mensaje, "Error");
        }
    }
}
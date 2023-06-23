using System.IO;
using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const int INDEX_COLUMNA_NOMBRE = 0;
        private string carpetaActual = Path.GetDirectoryName(Application.ExecutablePath);
        private string nombreArchivoData;
        public int Index = -1;
        public List<Articulo> lista = new List<Articulo>();

        public Form1()
        {
            nombreArchivoData = $"{carpetaActual}\\data.json";
            InitializeComponent();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridArticulos.SelectedRows.Count > 0)
            {
                Index = dataGridArticulos.CurrentRow.Index;
                HabilitarCampos();
                HabilitarBotonesEdicion(true);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridArticulos.SelectedRows.Count > 0)
            {
                dataGridArticulos.Rows.RemoveAt(dataGridArticulos.CurrentRow.Index);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string productoABuscar = textBoxBuscar.Text.ToString().ToLower();

            foreach (DataGridViewRow row in dataGridArticulos.Rows)
            {
                if (row.Cells[INDEX_COLUMNA_NOMBRE].Value.ToString().ToLower().Contains(productoABuscar))
                {
                    dataGridArticulos.ClearSelection();
                    row.Selected = true;
                    break;
                }
            }
        }

        private void buttonGuardar_Click_1(object sender, EventArgs e)
        {
            //Leo los textbox que ingreso el usuario
            string nombre = textBoxNombre.Text;
            string descripcion = textBoxDescripcion.Text;
            string marca = textBoxMarca.Text;
            double precio = double.Parse(textBoxPrecio.Text);
            int stock = int.Parse(textBoxStock.Text);
            string deposito = comboBoxDeposito.Text;

            GuardarFila(Index, nombre, descripcion, marca, precio, stock, deposito);

            LimpiarCampos();
            DeshabilitarCampos();
            HabilitarBotonesEdicion(false);
        }

        private void DeshabilitarCampos()
        {
            textBoxNombre.Enabled = false;
            textBoxDescripcion.Enabled = false;
            textBoxMarca.Enabled = false;
            textBoxPrecio.Enabled = false;
            textBoxStock.Enabled = false;
            comboBoxDeposito.Enabled = false;
            
            textBoxBuscar.Enabled = true;
            buttonBuscar.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(nombreArchivoData))
            {
                string json = File.ReadAllText(nombreArchivoData);
                try
                {
                    lista = JsonSerializer.Deserialize<List<Articulo>>(json);

                    foreach(var articulo in lista)
                    {
                        GuardarFila(-1, articulo.Nombre, articulo.Descripcion, articulo.Marca, articulo.Precio, articulo.Stock, articulo.Deposito);
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Falló la conversión desde JSON");
                }
            }

            CargarDepositos();

            DeshabilitarCampos();
            HabilitarBotonesEdicion(false);
        }

        private void CargarDepositos()
        {
            string depositos = File.ReadAllText("C:\\depositos.txt");
            string[] renglones = depositos.Split('\n');
            foreach (string renglon in renglones)
            {
                comboBoxDeposito.Items.Add(renglon);
            }
        }

        private void GuardarFila(int index, string nombre, string descripcion, string marca, double precio, int stock, string deposito)
        {
            var objeto = new object[] { nombre, descripcion, marca, precio, stock, deposito };
            if (index == -1) //si estoy dando de alta
            {
                dataGridArticulos.Rows.Add(objeto);
            }
            else //sino, estoy modificando
            {
                dataGridArticulos.Rows.RemoveAt(index);
                dataGridArticulos.Rows.Insert(index, objeto);
                index = -1;
            }
        }

        private void dataGridArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarTextBoxs();
        }

        private void ActualizarTextBoxs()
        {
            textBoxNombre.Text = dataGridArticulos.CurrentRow.Cells[INDEX_COLUMNA_NOMBRE].Value?.ToString();
            textBoxDescripcion.Text = dataGridArticulos.CurrentRow.Cells[1].Value?.ToString();
            textBoxMarca.Text = dataGridArticulos.CurrentRow.Cells[2].Value?.ToString();
            textBoxPrecio.Text = dataGridArticulos.CurrentRow.Cells[3].Value?.ToString();
            textBoxStock.Text = dataGridArticulos.CurrentRow.Cells[4].Value?.ToString();
            comboBoxDeposito.Text = dataGridArticulos.CurrentRow.Cells[5].Value?.ToString();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            HabilitarCampos();
            HabilitarBotonesEdicion(true);
        }

        private void HabilitarBotonesEdicion(bool estaEditando)
        {
            buttonCancelar.Enabled = estaEditando;
            buttonGuardar.Enabled = estaEditando;

            buttonNuevo.Enabled = !estaEditando;
            buttonBuscar.Enabled = !estaEditando;
            buttonEditar.Enabled = !estaEditando;
            buttonEliminar.Enabled = !estaEditando;
            buttonExportar.Enabled = !estaEditando;
            dataGridArticulos.Enabled = !estaEditando;
        }

        private void LimpiarCampos()
        {
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            textBoxMarca.Clear();
            textBoxPrecio.Clear();
            textBoxStock.Clear();
            comboBoxDeposito.Text = "";
        }

        private void HabilitarCampos()
        {
            textBoxNombre.Enabled = true;
            textBoxDescripcion.Enabled = true;
            textBoxMarca.Enabled = true;
            textBoxPrecio.Enabled = true;
            textBoxStock.Enabled = true;
            comboBoxDeposito.Enabled = true;
            
            textBoxBuscar.Enabled = false;
            buttonBuscar.Enabled = false;
        }

        private void buttonExportar_Click(object sender, EventArgs e)
        {
            lista = new List<Articulo>();
            //Recorrer toda la grilla, campo por campo, y guardarlo en un JSON.
            int fila = dataGridArticulos.Rows.GetFirstRow(DataGridViewElementStates.None);
            while (fila >= 0 && (fila < dataGridArticulos.Rows.Count - 1))
            {
                var row = dataGridArticulos.Rows[fila];
                Articulo articulo = new Articulo();
                articulo.Nombre = row.Cells[INDEX_COLUMNA_NOMBRE].Value.ToString();
                articulo.Descripcion = row.Cells[1].Value.ToString();
                articulo.Marca = row.Cells[2].Value.ToString();
                articulo.Precio = double.Parse(row.Cells[3].Value.ToString());
                articulo.Stock = int.Parse(row.Cells[4].Value.ToString());
                articulo.Deposito = row.Cells[5].Value?.ToString();
                lista.Add(articulo);

                fila = dataGridArticulos.Rows.GetNextRow(fila, DataGridViewElementStates.None);
            }

            //guardarlo en json

            string json = JsonSerializer.Serialize(lista);
            File.WriteAllText(nombreArchivoData, json);
            MessageBox.Show("Stock guardado correctamente");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
            HabilitarBotonesEdicion(false);
        }

        private void buttonImportar_Click(object sender, EventArgs e)
        {
            //Abrir el buscador de archivos, y después buscar en el código la solución que ya está hecho.
        }
    }
}
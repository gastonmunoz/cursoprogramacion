namespace WinFormsApp1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private int idinterno = 1;
        private void AgregarNuevobutton_Click(object sender, EventArgs e)
        {
            mostrarFormEdicion(true);
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell.RowIndex >= 0 &&
                dataGridView1.CurrentCell.RowIndex < dataGridView1.Rows.Count)
            {
                mostrarFormEdicion(false);
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count > 1)             
            {   
                var eliminar = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(eliminar);
            }
            else
            {
                string mensaje = "Esta vacio, llenalo";
                string titulo = "BE CAREFUL";
                MessageBox.Show(mensaje, titulo);
            }
        }

        private void mostrarFormEdicion(bool esAlta)
        {
            FormAgregar formEdicion = new FormAgregar();
            if (!esAlta)
            {
                formEdicion.nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                formEdicion.direccion = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                formEdicion.googleMaps = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            var result = formEdicion.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (esAlta)
                {
                    dataGridView1.Rows.Add(idinterno, formEdicion.nombre, formEdicion.direccion, formEdicion.googleMaps);
                    idinterno++;
                }
                else
                {
                    dataGridView1.CurrentRow.Cells[1].Value = formEdicion.nombre;
                    dataGridView1.CurrentRow.Cells[2].Value = formEdicion.direccion;
                    dataGridView1.CurrentRow.Cells[3].Value = formEdicion.googleMaps;
                }
            }
        }
    }
}
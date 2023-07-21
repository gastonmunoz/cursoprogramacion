using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace modeloBaseSQL
{
    /*
    Tareas disponibles c#:
        Crear formulario de gestion de usuario
        Crear formulario de gestion de tareas
        btnBuscar_Click
        btnFilter_Click
        btnNuevaTarea_Click
        btnModificar_Click
        btnEliminar_Click
        btnCancelar_Click
        btnGuardar_Click
        Exportar
        Obtener lista de proyectos
        Obtener lista de usuarios
    SQL: 
        Creacion de logica de usuarios
        Creacion de logica de tareas
        Lista de proyectos
        Lista de tipo de tareas
        Usuarios
        Tipo de usuarios
        Vistas
        Stored procedures
        Log de registro de cambios
        Log inicio de sesion
    */
    public partial class SqlExample : Form
    {
        // creamos la cadena de conexion para nuestro MSSQL que se encuentra dentro de AWS RDS.
        // private string connectionString = "Data Source=<AWS_RDS_ENDPOINT>;Initial Catalog=<DATABASE_NAME>;User ID=<USERNAME>;Password=<PASSWORD>;";
        // Reemplazamos AWS_RDS_ENDPOINT por el endpoint que corresponda a nuestro servidor.
        // Reemplazamos DATABASE_NAME por el nombre de la base de datos a consultar.
        // Reemplazamos USERNAME por el nombre de usuario con el cual nos vamos a conectar.
        // Reemplazamos PASSWORD por la contraseña que corresponda al usuario con el cual nos vamos a conectar.
        private string connectionString = "";
        private DataTable dataTable = new DataTable();

        public SqlExample()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            // Obtenemos mediando una query, todos los datos que se encuentren dentro de la tabla Test. No usar *, dado que es poco performante, pero para el ejemplo, esta bien.
            dataTable = GetDataFromDatabase("SELECT * FROM TaskCurso");
            // Igualamos los datos de dataTable al dataGridView.
            dgvSql.DataSource = dataTable;
        }

        private DataTable GetDataFromDatabase(string query)
        {
            DataTable resultTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Conexión exitosa.");

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(resultTable);
                            connection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            return resultTable;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Este boton debera poder buscar segun la opcion seleccionada.
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Debera filtrar los datos que se muestran en pantalla dentro de la vista. 
        }

        private void btnNuevaTarea_Click(object sender, EventArgs e)
        {
            //Llamara al formulario de Nueva tarea, permitiendo asi el ingreso de una tarea nueva.
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Permitira modificar una tarea existente, pudiendo asi cambiar responsable, proyectos, el contenido de la tarea y la fecha de vencimiento.
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Elimina una tarea seleccionada.
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Cancela la ultima modificacion. 
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Guarda los cambios realizados en el formulario de Modificar.
        }
    }
}

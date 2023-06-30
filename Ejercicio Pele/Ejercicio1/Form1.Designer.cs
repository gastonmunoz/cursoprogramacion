namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            columnID = new DataGridViewTextBoxColumn();
            columnNombre = new DataGridViewTextBoxColumn();
            columnDescripcion = new DataGridViewTextBoxColumn();
            columnEmail = new DataGridViewTextBoxColumn();
            columnTelefono = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { columnID, columnNombre, columnDescripcion, columnEmail, columnTelefono });
            dataGridView1.Location = new Point(-8, 104);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(796, 244);
            dataGridView1.TabIndex = 0;
            // 
            // columnID
            // 
            columnID.HeaderText = "ID";
            columnID.Name = "columnID";
            // 
            // columnNombre
            // 
            columnNombre.HeaderText = "Nombre";
            columnNombre.Name = "columnNombre";
            // 
            // columnDescripcion
            // 
            columnDescripcion.HeaderText = "Descripcion";
            columnDescripcion.Name = "columnDescripcion";
            // 
            // columnEmail
            // 
            columnEmail.HeaderText = "Email";
            columnEmail.Name = "columnEmail";
            // 
            // columnTelefono
            // 
            columnTelefono.HeaderText = "Telefono";
            columnTelefono.Name = "columnTelefono";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Yellow;
            btnAgregar.Location = new Point(82, 382);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 40);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar Nuevo";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Yellow;
            btnModificar.Location = new Point(321, 382);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(152, 40);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Yellow;
            btnEliminar.Location = new Point(560, 382);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(152, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 4;
            label1.Text = "Empleados";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label label1;
        private DataGridViewTextBoxColumn columnID;
        private DataGridViewTextBoxColumn columnNombre;
        private DataGridViewTextBoxColumn columnDescripcion;
        private DataGridViewTextBoxColumn columnEmail;
        private DataGridViewTextBoxColumn columnTelefono;
    }
}
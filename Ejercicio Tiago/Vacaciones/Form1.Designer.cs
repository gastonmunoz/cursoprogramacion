namespace Vacaciones
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
            this.labelVacaciones = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridVacaciones = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpleada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVacaciones
            // 
            this.labelVacaciones.AutoSize = true;
            this.labelVacaciones.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVacaciones.Location = new System.Drawing.Point(27, 15);
            this.labelVacaciones.Name = "labelVacaciones";
            this.labelVacaciones.Size = new System.Drawing.Size(109, 25);
            this.labelVacaciones.TabIndex = 0;
            this.labelVacaciones.Text = "Vacaciones";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Yellow;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.Location = new System.Drawing.Point(29, 61);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(107, 25);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar nueva";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridVacaciones
            // 
            this.dataGridVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNombre,
            this.ColumnDescripcion,
            this.ColumnEmpleada,
            this.ColumnFechaDesde,
            this.ColumnFechaHasta});
            this.dataGridVacaciones.Location = new System.Drawing.Point(27, 101);
            this.dataGridVacaciones.Name = "dataGridVacaciones";
            this.dataGridVacaciones.ReadOnly = true;
            this.dataGridVacaciones.RowTemplate.Height = 25;
            this.dataGridVacaciones.Size = new System.Drawing.Size(647, 264);
            this.dataGridVacaciones.TabIndex = 2;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 30;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.HeaderText = "Descripcion";
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            // 
            // ColumnEmpleada
            // 
            this.ColumnEmpleada.HeaderText = "Empleada/o";
            this.ColumnEmpleada.Name = "ColumnEmpleada";
            this.ColumnEmpleada.ReadOnly = true;
            // 
            // ColumnFechaDesde
            // 
            this.ColumnFechaDesde.HeaderText = "Fecha desde";
            this.ColumnFechaDesde.Name = "ColumnFechaDesde";
            this.ColumnFechaDesde.ReadOnly = true;
            // 
            // ColumnFechaHasta
            // 
            this.ColumnFechaHasta.HeaderText = "Fecha hasta";
            this.ColumnFechaHasta.Name = "ColumnFechaHasta";
            this.ColumnFechaHasta.ReadOnly = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Yellow;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(439, 390);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(104, 25);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.Yellow;
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModificar.Location = new System.Drawing.Point(171, 390);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(104, 25);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.dataGridVacaciones);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelVacaciones);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelVacaciones;
        private Button buttonAgregar;
        private DataGridView dataGridVacaciones;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnEmpleada;
        private DataGridViewTextBoxColumn ColumnFechaDesde;
        private DataGridViewTextBoxColumn ColumnFechaHasta;
        private Button buttonEliminar;
        private Button buttonModificar;
    }
}
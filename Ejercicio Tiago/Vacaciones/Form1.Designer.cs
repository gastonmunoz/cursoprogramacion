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
            this.groupBoxVacaciones = new System.Windows.Forms.GroupBox();
            this.buttonExportar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridVacaciones = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmpleada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.groupBoxVacaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxVacaciones
            // 
            this.groupBoxVacaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxVacaciones.Controls.Add(this.buttonExportar);
            this.groupBoxVacaciones.Controls.Add(this.buttonModificar);
            this.groupBoxVacaciones.Controls.Add(this.buttonEliminar);
            this.groupBoxVacaciones.Controls.Add(this.dataGridVacaciones);
            this.groupBoxVacaciones.Controls.Add(this.buttonAgregar);
            this.groupBoxVacaciones.Location = new System.Drawing.Point(15, 13);
            this.groupBoxVacaciones.Name = "groupBoxVacaciones";
            this.groupBoxVacaciones.Size = new System.Drawing.Size(656, 441);
            this.groupBoxVacaciones.TabIndex = 0;
            this.groupBoxVacaciones.TabStop = false;
            this.groupBoxVacaciones.Text = "Vacaciones";
            // 
            // buttonExportar
            // 
            this.buttonExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportar.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExportar.Location = new System.Drawing.Point(536, 32);
            this.buttonExportar.Name = "buttonExportar";
            this.buttonExportar.Size = new System.Drawing.Size(104, 25);
            this.buttonExportar.TabIndex = 10;
            this.buttonExportar.Text = "Exportar";
            this.buttonExportar.UseVisualStyleBackColor = false;
            this.buttonExportar.Click += new System.EventHandler(this.buttonExportar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModificar.BackColor = System.Drawing.Color.Yellow;
            this.buttonModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModificar.Location = new System.Drawing.Point(123, 391);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(104, 25);
            this.buttonModificar.TabIndex = 8;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEliminar.BackColor = System.Drawing.Color.Yellow;
            this.buttonEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEliminar.Location = new System.Drawing.Point(391, 391);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(104, 25);
            this.buttonEliminar.TabIndex = 7;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridVacaciones
            // 
            this.dataGridVacaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridVacaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVacaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVacaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNombre,
            this.ColumnDescripcion,
            this.ColumnEmpleada,
            this.ColumnFechaDesde,
            this.ColumnFechaHasta});
            this.dataGridVacaciones.Location = new System.Drawing.Point(6, 74);
            this.dataGridVacaciones.Name = "dataGridVacaciones";
            this.dataGridVacaciones.ReadOnly = true;
            this.dataGridVacaciones.RowTemplate.Height = 25;
            this.dataGridVacaciones.Size = new System.Drawing.Size(644, 294);
            this.dataGridVacaciones.TabIndex = 6;
            this.dataGridVacaciones.SelectionChanged += new System.EventHandler(this.dataGridVacaciones_SelectionChanged);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
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
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Yellow;
            this.buttonAgregar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAgregar.Location = new System.Drawing.Point(6, 32);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(107, 25);
            this.buttonAgregar.TabIndex = 5;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 469);
            this.Controls.Add(this.groupBoxVacaciones);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimumSize = new System.Drawing.Size(707, 508);
            this.Name = "Form1";
            this.Text = "Planilla de Vacaciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxVacaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVacaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxVacaciones;
        private Button buttonModificar;
        private Button buttonEliminar;
        private DataGridView dataGridVacaciones;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnDescripcion;
        private DataGridViewTextBoxColumn ColumnEmpleada;
        private DataGridViewTextBoxColumn ColumnFechaDesde;
        private DataGridViewTextBoxColumn ColumnFechaHasta;
        private Button buttonAgregar;
        private Button buttonExportar;
    }
}
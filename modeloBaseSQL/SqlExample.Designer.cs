namespace modeloBaseSQL
{
    partial class SqlExample
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
            dgvSql = new DataGridView();
            menu = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            exportarToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            altaToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnNuevaTarea = new Button();
            rbTarea = new RadioButton();
            rbResponsable = new RadioButton();
            gbFilters = new GroupBox();
            cbxResponsable = new ComboBox();
            btnFilter = new Button();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            cbxProjecto = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            rbProjecto = new RadioButton();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvSql).BeginInit();
            menu.SuspendLayout();
            groupBox1.SuspendLayout();
            gbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSql
            // 
            dgvSql.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvSql.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSql.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSql.Location = new Point(6, 91);
            dgvSql.Name = "dgvSql";
            dgvSql.RowTemplate.Height = 25;
            dgvSql.Size = new Size(1065, 375);
            dgvSql.TabIndex = 1;
            // 
            // menu
            // 
            menu.GripStyle = ToolStripGripStyle.Visible;
            menu.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem, usuariosToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(1101, 24);
            menu.TabIndex = 2;
            menu.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportarToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(69, 20);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // exportarToolStripMenuItem
            // 
            exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            exportarToolStripMenuItem.Size = new Size(118, 22);
            exportarToolStripMenuItem.Text = "Exportar";
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaToolStripMenuItem });
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(64, 20);
            usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(177, 22);
            altaToolStripMenuItem.Text = "Gestion de usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnNuevaTarea);
            groupBox1.Controls.Add(rbTarea);
            groupBox1.Controls.Add(rbResponsable);
            groupBox1.Controls.Add(gbFilters);
            groupBox1.Controls.Add(rbProjecto);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Controls.Add(txtBuscar);
            groupBox1.Controls.Add(dgvSql);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1077, 508);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tareas ";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(729, 472);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 23);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Location = new Point(970, 472);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 23);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new Point(488, 472);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 23);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new Point(247, 472);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 23);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnNuevaTarea
            // 
            btnNuevaTarea.Location = new Point(6, 472);
            btnNuevaTarea.Name = "btnNuevaTarea";
            btnNuevaTarea.Size = new Size(100, 23);
            btnNuevaTarea.TabIndex = 15;
            btnNuevaTarea.Text = "Nueva tarea";
            btnNuevaTarea.UseVisualStyleBackColor = true;
            btnNuevaTarea.Click += btnNuevaTarea_Click;
            // 
            // rbTarea
            // 
            rbTarea.AutoSize = true;
            rbTarea.Location = new Point(298, 56);
            rbTarea.Name = "rbTarea";
            rbTarea.Size = new Size(52, 19);
            rbTarea.TabIndex = 14;
            rbTarea.TabStop = true;
            rbTarea.Text = "Tarea";
            rbTarea.UseVisualStyleBackColor = true;
            // 
            // rbResponsable
            // 
            rbResponsable.AutoSize = true;
            rbResponsable.Location = new Point(204, 56);
            rbResponsable.Name = "rbResponsable";
            rbResponsable.Size = new Size(88, 19);
            rbResponsable.TabIndex = 8;
            rbResponsable.TabStop = true;
            rbResponsable.Text = "responsable";
            rbResponsable.UseVisualStyleBackColor = true;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(cbxResponsable);
            gbFilters.Controls.Add(btnFilter);
            gbFilters.Controls.Add(dtpFecha);
            gbFilters.Controls.Add(label3);
            gbFilters.Controls.Add(cbxProjecto);
            gbFilters.Controls.Add(label2);
            gbFilters.Controls.Add(label1);
            gbFilters.Location = new Point(479, 12);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(592, 73);
            gbFilters.TabIndex = 7;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filtros";
            // 
            // cbxResponsable
            // 
            cbxResponsable.FormattingEnabled = true;
            cbxResponsable.Location = new Point(6, 40);
            cbxResponsable.Name = "cbxResponsable";
            cbxResponsable.Size = new Size(121, 23);
            cbxResponsable.TabIndex = 6;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(466, 14);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(117, 48);
            btnFilter.TabIndex = 13;
            btnFilter.Text = "Filtrar";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(260, 40);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 22);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 12;
            label3.Text = "Fecha";
            // 
            // cbxProjecto
            // 
            cbxProjecto.FormattingEnabled = true;
            cbxProjecto.Location = new Point(133, 40);
            cbxProjecto.Name = "cbxProjecto";
            cbxProjecto.Size = new Size(121, 23);
            cbxProjecto.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 22);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 11;
            label2.Text = "Proyecto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 10;
            label1.Text = "Responsable";
            // 
            // rbProjecto
            // 
            rbProjecto.AutoSize = true;
            rbProjecto.Location = new Point(129, 56);
            rbProjecto.Name = "rbProjecto";
            rbProjecto.Size = new Size(72, 19);
            rbProjecto.TabIndex = 4;
            rbProjecto.TabStop = true;
            rbProjecto.Text = "proyecto";
            rbProjecto.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(356, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(117, 63);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 26);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(344, 23);
            txtBuscar.TabIndex = 2;
            // 
            // SqlExample
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1101, 547);
            Controls.Add(groupBox1);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menu;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SqlExample";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL Example";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSql).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvSql;
        private MenuStrip menu;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem exportarToolStripMenuItem;
        private GroupBox groupBox1;
        private RadioButton rbTarea;
        private RadioButton rbResponsable;
        private GroupBox gbFilters;
        private ComboBox cbxResponsable;
        private Button btnFilter;
        private DateTimePicker dtpFecha;
        private Label label3;
        private ComboBox cbxProjecto;
        private Label label2;
        private Label label1;
        private RadioButton rbProjecto;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnNuevaTarea;
        private Button btnCancelar;
        private Button btnGuardar;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem altaToolStripMenuItem;
    }
}
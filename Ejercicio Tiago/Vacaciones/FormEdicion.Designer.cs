namespace Vacaciones
{
    partial class FormEdicion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxNuevas = new System.Windows.Forms.GroupBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelHasta = new System.Windows.Forms.Label();
            this.comboBoxEmpleadas = new System.Windows.Forms.ComboBox();
            this.labelDesde = new System.Windows.Forms.Label();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.labelEmpleada = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxNuevas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxNuevas
            // 
            this.groupBoxNuevas.Controls.Add(this.buttonAceptar);
            this.groupBoxNuevas.Controls.Add(this.textBoxNombre);
            this.groupBoxNuevas.Controls.Add(this.buttonCancelar);
            this.groupBoxNuevas.Controls.Add(this.textBoxDescripcion);
            this.groupBoxNuevas.Controls.Add(this.labelHasta);
            this.groupBoxNuevas.Controls.Add(this.comboBoxEmpleadas);
            this.groupBoxNuevas.Controls.Add(this.labelDesde);
            this.groupBoxNuevas.Controls.Add(this.dateTimeDesde);
            this.groupBoxNuevas.Controls.Add(this.labelEmpleada);
            this.groupBoxNuevas.Controls.Add(this.dateTimeHasta);
            this.groupBoxNuevas.Controls.Add(this.labelDescripcion);
            this.groupBoxNuevas.Controls.Add(this.labelNombre);
            this.groupBoxNuevas.Location = new System.Drawing.Point(14, 12);
            this.groupBoxNuevas.Name = "groupBoxNuevas";
            this.groupBoxNuevas.Size = new System.Drawing.Size(245, 417);
            this.groupBoxNuevas.TabIndex = 0;
            this.groupBoxNuevas.TabStop = false;
            this.groupBoxNuevas.Text = "Nuevas Vacaciones";
            this.groupBoxNuevas.UseWaitCursor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Yellow;
            this.buttonAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptar.Location = new System.Drawing.Point(6, 360);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(105, 32);
            this.buttonAceptar.TabIndex = 25;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.UseWaitCursor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(6, 59);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(230, 23);
            this.textBoxNombre.TabIndex = 14;
            this.textBoxNombre.UseWaitCursor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Yellow;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(133, 360);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(105, 32);
            this.buttonCancelar.TabIndex = 24;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.UseWaitCursor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(6, 117);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(230, 23);
            this.textBoxDescripcion.TabIndex = 15;
            this.textBoxDescripcion.UseWaitCursor = true;
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(6, 284);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(69, 15);
            this.labelHasta.TabIndex = 23;
            this.labelHasta.Text = "Fecha hasta";
            this.labelHasta.UseWaitCursor = true;
            // 
            // comboBoxEmpleadas
            // 
            this.comboBoxEmpleadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpleadas.FormattingEnabled = true;
            this.comboBoxEmpleadas.Items.AddRange(new object[] {
            "Pele",
            "Luis",
            "Gato"});
            this.comboBoxEmpleadas.Location = new System.Drawing.Point(6, 179);
            this.comboBoxEmpleadas.Name = "comboBoxEmpleadas";
            this.comboBoxEmpleadas.Size = new System.Drawing.Size(229, 23);
            this.comboBoxEmpleadas.TabIndex = 16;
            this.comboBoxEmpleadas.UseWaitCursor = true;
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(6, 223);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(72, 15);
            this.labelDesde.TabIndex = 22;
            this.labelDesde.Text = "Fecha desde";
            this.labelDesde.UseWaitCursor = true;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CustomFormat = "dd/MM/YYYY";
            this.dateTimeDesde.Location = new System.Drawing.Point(6, 241);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(232, 23);
            this.dateTimeDesde.TabIndex = 17;
            this.dateTimeDesde.UseWaitCursor = true;
            // 
            // labelEmpleada
            // 
            this.labelEmpleada.AutoSize = true;
            this.labelEmpleada.Location = new System.Drawing.Point(6, 161);
            this.labelEmpleada.Name = "labelEmpleada";
            this.labelEmpleada.Size = new System.Drawing.Size(71, 15);
            this.labelEmpleada.TabIndex = 21;
            this.labelEmpleada.Text = "Empleada/o";
            this.labelEmpleada.UseWaitCursor = true;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(6, 302);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(232, 23);
            this.dateTimeHasta.TabIndex = 18;
            this.dateTimeHasta.UseWaitCursor = true;
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(6, 99);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(69, 15);
            this.labelDescripcion.TabIndex = 20;
            this.labelDescripcion.Text = "Descripcion";
            this.labelDescripcion.UseWaitCursor = true;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(8, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 19;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.UseWaitCursor = true;
            // 
            // FormEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 440);
            this.Controls.Add(this.groupBoxNuevas);
            this.Name = "FormEdicion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEdicion_Load);
            this.groupBoxNuevas.ResumeLayout(false);
            this.groupBoxNuevas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxNuevas;
        private Button buttonAceptar;
        private TextBox textBoxNombre;
        private Button buttonCancelar;
        private TextBox textBoxDescripcion;
        private Label labelHasta;
        private ComboBox comboBoxEmpleadas;
        private Label labelDesde;
        private DateTimePicker dateTimeDesde;
        private Label labelEmpleada;
        private DateTimePicker dateTimeHasta;
        private Label labelDescripcion;
        private Label labelNombre;
    }
}
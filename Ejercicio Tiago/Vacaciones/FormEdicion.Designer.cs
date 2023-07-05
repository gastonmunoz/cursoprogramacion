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
            this.labelNuevasVacaciones = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxEmpleadas = new System.Windows.Forms.ComboBox();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelEmpleada = new System.Windows.Forms.Label();
            this.labelDesde = new System.Windows.Forms.Label();
            this.labelHasta = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNuevasVacaciones
            // 
            this.labelNuevasVacaciones.AutoSize = true;
            this.labelNuevasVacaciones.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNuevasVacaciones.Location = new System.Drawing.Point(16, 16);
            this.labelNuevasVacaciones.Name = "labelNuevasVacaciones";
            this.labelNuevasVacaciones.Size = new System.Drawing.Size(184, 23);
            this.labelNuevasVacaciones.TabIndex = 0;
            this.labelNuevasVacaciones.Text = "Nuevas Vacaciones";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(16, 70);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(230, 23);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(16, 128);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(230, 23);
            this.textBoxDescripcion.TabIndex = 2;
            // 
            // comboBoxEmpleadas
            // 
            this.comboBoxEmpleadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpleadas.FormattingEnabled = true;
            this.comboBoxEmpleadas.Items.AddRange(new object[] {
            "Pele",
            "Luis",
            "Gato"});
            this.comboBoxEmpleadas.Location = new System.Drawing.Point(16, 190);
            this.comboBoxEmpleadas.Name = "comboBoxEmpleadas";
            this.comboBoxEmpleadas.Size = new System.Drawing.Size(229, 23);
            this.comboBoxEmpleadas.TabIndex = 3;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.CustomFormat = "dd/MM/YYYY";
            this.dateTimeDesde.Location = new System.Drawing.Point(16, 252);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(232, 23);
            this.dateTimeDesde.TabIndex = 4;
            this.dateTimeDesde.ValueChanged += new System.EventHandler(this.dateTimeDesde_ValueChanged);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(16, 313);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(232, 23);
            this.dateTimeHasta.TabIndex = 5;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(18, 52);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(51, 15);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(16, 110);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(69, 15);
            this.labelDescripcion.TabIndex = 7;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelEmpleada
            // 
            this.labelEmpleada.AutoSize = true;
            this.labelEmpleada.Location = new System.Drawing.Point(16, 172);
            this.labelEmpleada.Name = "labelEmpleada";
            this.labelEmpleada.Size = new System.Drawing.Size(71, 15);
            this.labelEmpleada.TabIndex = 8;
            this.labelEmpleada.Text = "Empleada/o";
            // 
            // labelDesde
            // 
            this.labelDesde.AutoSize = true;
            this.labelDesde.Location = new System.Drawing.Point(16, 234);
            this.labelDesde.Name = "labelDesde";
            this.labelDesde.Size = new System.Drawing.Size(72, 15);
            this.labelDesde.TabIndex = 9;
            this.labelDesde.Text = "Fecha desde";
            // 
            // labelHasta
            // 
            this.labelHasta.AutoSize = true;
            this.labelHasta.Location = new System.Drawing.Point(16, 295);
            this.labelHasta.Name = "labelHasta";
            this.labelHasta.Size = new System.Drawing.Size(69, 15);
            this.labelHasta.TabIndex = 10;
            this.labelHasta.Text = "Fecha hasta";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.Color.Yellow;
            this.buttonCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCancelar.Location = new System.Drawing.Point(143, 371);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(105, 32);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.BackColor = System.Drawing.Color.Yellow;
            this.buttonAceptar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAceptar.Location = new System.Drawing.Point(16, 371);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(105, 32);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = false;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // FormEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 441);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelHasta);
            this.Controls.Add(this.labelDesde);
            this.Controls.Add(this.labelEmpleada);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.comboBoxEmpleadas);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.labelNuevasVacaciones);
            this.Name = "FormEdicion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEdicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelNuevasVacaciones;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private ComboBox comboBoxEmpleadas;
        private DateTimePicker dateTimeDesde;
        private DateTimePicker dateTimeHasta;
        private Label labelNombre;
        private Label labelDescripcion;
        private Label labelEmpleada;
        private Label labelDesde;
        private Label labelHasta;
        private Button buttonCancelar;
        private Button buttonAceptar;
    }
}
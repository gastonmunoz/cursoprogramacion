namespace WinFormsApp1
{
    partial class FormPrincipal
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
            AgregarNuevobutton = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            GoogleMaps = new DataGridViewTextBoxColumn();
            Eliminar = new Button();
            Modificar = new Button();
            Locales = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AgregarNuevobutton
            // 
            AgregarNuevobutton.Location = new Point(12, 103);
            AgregarNuevobutton.Name = "AgregarNuevobutton";
            AgregarNuevobutton.Size = new Size(118, 23);
            AgregarNuevobutton.TabIndex = 0;
            AgregarNuevobutton.Text = "AgregarNuevo";
            AgregarNuevobutton.UseVisualStyleBackColor = true;
            AgregarNuevobutton.Click += AgregarNuevobutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, Nombre, Direccion, GoogleMaps });
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 197);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // GoogleMaps
            // 
            GoogleMaps.HeaderText = "GoogleMaps";
            GoogleMaps.Name = "GoogleMaps";
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.Yellow;
            Eliminar.Location = new Point(151, 389);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(118, 49);
            Eliminar.TabIndex = 3;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Modificar
            // 
            Modificar.BackColor = Color.Yellow;
            Modificar.ForeColor = Color.Black;
            Modificar.Location = new Point(12, 389);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(119, 49);
            Modificar.TabIndex = 4;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = false;
            Modificar.Click += Modificar_Click;
            // 
            // Locales
            // 
            Locales.AutoSize = true;
            Locales.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            Locales.Location = new Point(12, 23);
            Locales.Name = "Locales";
            Locales.Size = new Size(118, 42);
            Locales.TabIndex = 5;
            Locales.Text = "Locales";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Locales);
            Controls.Add(Modificar);
            Controls.Add(Eliminar);
            Controls.Add(dataGridView1);
            Controls.Add(AgregarNuevobutton);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AgregarNuevobutton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn GoogleMaps;
        private Button Eliminar;
        private Button Modificar;
        private Label Locales;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
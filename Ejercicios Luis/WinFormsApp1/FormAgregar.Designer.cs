namespace WinFormsApp1
{
    partial class FormAgregar
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
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textboxCancelar = new Button();
            textboxAceptar = new Button();
            textboxGoogleMaps = new TextBox();
            textboxDireccion = new TextBox();
            textboxNombre = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textboxCancelar);
            groupBox1.Controls.Add(textboxAceptar);
            groupBox1.Controls.Add(textboxGoogleMaps);
            groupBox1.Controls.Add(textboxDireccion);
            groupBox1.Controls.Add(textboxNombre);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 155);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nuevos Locales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 92);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 16;
            label4.Text = "GoogleMaps";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 63);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 34);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre";
            // 
            // textboxCancelar
            // 
            textboxCancelar.Location = new Point(237, 118);
            textboxCancelar.Name = "textboxCancelar";
            textboxCancelar.Size = new Size(125, 23);
            textboxCancelar.TabIndex = 13;
            textboxCancelar.Text = "Cancelar";
            textboxCancelar.UseVisualStyleBackColor = true;
            textboxCancelar.Click += textboxCancelar_Click;
            // 
            // textboxAceptar
            // 
            textboxAceptar.Location = new Point(91, 118);
            textboxAceptar.Name = "textboxAceptar";
            textboxAceptar.Size = new Size(140, 23);
            textboxAceptar.TabIndex = 12;
            textboxAceptar.Text = "Aceptar";
            textboxAceptar.UseVisualStyleBackColor = true;
            textboxAceptar.Click += textboxAceptar_Click;
            // 
            // textboxGoogleMaps
            // 
            textboxGoogleMaps.Location = new Point(91, 89);
            textboxGoogleMaps.Name = "textboxGoogleMaps";
            textboxGoogleMaps.Size = new Size(271, 23);
            textboxGoogleMaps.TabIndex = 11;
            // 
            // textboxDireccion
            // 
            textboxDireccion.Location = new Point(91, 60);
            textboxDireccion.Name = "textboxDireccion";
            textboxDireccion.Size = new Size(271, 23);
            textboxDireccion.TabIndex = 10;
            // 
            // textboxNombre
            // 
            textboxNombre.Location = new Point(91, 31);
            textboxNombre.Name = "textboxNombre";
            textboxNombre.Size = new Size(271, 23);
            textboxNombre.TabIndex = 9;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 179);
            Controls.Add(groupBox1);
            Name = "FormAgregar";
            Text = "Form2";
            Load += FormAgregar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button textboxCancelar;
        private Button textboxAceptar;
        private TextBox textboxGoogleMaps;
        private TextBox textboxDireccion;
        private TextBox textboxNombre;
    }
}
namespace Ejercicio1
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
            labelEmpleado = new Label();
            textBoxNombre = new TextBox();
            textBoxDescripcion = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTelefono = new TextBox();
            btnCancelar = new Button();
            btnAceptar = new Button();
            labelNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labelEmpleado
            // 
            labelEmpleado.AutoSize = true;
            labelEmpleado.Location = new Point(140, 46);
            labelEmpleado.Name = "labelEmpleado";
            labelEmpleado.Size = new Size(98, 15);
            labelEmpleado.TabIndex = 0;
            labelEmpleado.Text = "Nuevo Empleado";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(140, 128);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(200, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescripcion.Location = new Point(140, 173);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(200, 23);
            textBoxDescripcion.TabIndex = 2;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(140, 218);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 3;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.BorderStyle = BorderStyle.FixedSingle;
            textBoxTelefono.Location = new Point(140, 263);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(200, 23);
            textBoxTelefono.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(238, 374);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 37);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(127, 374);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(111, 37);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNombre.Location = new Point(36, 130);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(75, 21);
            labelNombre.TabIndex = 9;
            labelNombre.Text = "Nombre*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(36, 175);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 10;
            label2.Text = "Descripcion*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 220);
            label3.Name = "label3";
            label3.Size = new Size(55, 21);
            label3.TabIndex = 11;
            label3.Text = "Email*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(36, 265);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 12;
            label4.Text = "Telefono*";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelNombre);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(textBoxTelefono);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxDescripcion);
            Controls.Add(textBoxNombre);
            Controls.Add(labelEmpleado);
            Name = "FormAgregar";
            Text = "Form2";
            Load += FormAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEmpleado;
        private TextBox textBoxNombre;
        private TextBox textBoxDescripcion;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefono;
        private TextBox textBox5;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label labelNombre;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
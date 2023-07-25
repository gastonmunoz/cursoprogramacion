namespace ValorantApp.App
{
    partial class FormAcceptedInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAcceptedInfo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelDayHour = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.textBoxDayHour = new System.Windows.Forms.TextBox();
            this.textBoxRol = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.labelRol);
            this.groupBox1.Controls.Add(this.labelDayHour);
            this.groupBox1.Controls.Add(this.labelRegion);
            this.groupBox1.Controls.Add(this.labelUser);
            this.groupBox1.Controls.Add(this.textBoxRegion);
            this.groupBox1.Controls.Add(this.textBoxDayHour);
            this.groupBox1.Controls.Add(this.textBoxRol);
            this.groupBox1.Controls.Add(this.textBoxUser);
            this.groupBox1.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lobby accepted";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.AntiqueWhite;
            this.buttonClose.Location = new System.Drawing.Point(118, 255);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(90, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRol.Location = new System.Drawing.Point(7, 161);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(42, 14);
            this.labelRol.TabIndex = 8;
            this.labelRol.Text = "Rol :";
            // 
            // labelDayHour
            // 
            this.labelDayHour.AutoSize = true;
            this.labelDayHour.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDayHour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDayHour.Location = new System.Drawing.Point(7, 207);
            this.labelDayHour.Name = "labelDayHour";
            this.labelDayHour.Size = new System.Drawing.Size(105, 14);
            this.labelDayHour.TabIndex = 7;
            this.labelDayHour.Text = "Day and hour :";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRegion.Location = new System.Drawing.Point(7, 110);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(63, 14);
            this.labelRegion.TabIndex = 5;
            this.labelRegion.Text = "Region :";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelUser.Location = new System.Drawing.Point(7, 52);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(49, 14);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "User :";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(118, 102);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.ReadOnly = true;
            this.textBoxRegion.Size = new System.Drawing.Size(180, 22);
            this.textBoxRegion.TabIndex = 3;
            // 
            // textBoxDayHour
            // 
            this.textBoxDayHour.Location = new System.Drawing.Point(118, 199);
            this.textBoxDayHour.Name = "textBoxDayHour";
            this.textBoxDayHour.ReadOnly = true;
            this.textBoxDayHour.Size = new System.Drawing.Size(180, 22);
            this.textBoxDayHour.TabIndex = 2;
            // 
            // textBoxRol
            // 
            this.textBoxRol.Location = new System.Drawing.Point(118, 153);
            this.textBoxRol.Name = "textBoxRol";
            this.textBoxRol.ReadOnly = true;
            this.textBoxRol.Size = new System.Drawing.Size(180, 22);
            this.textBoxRol.TabIndex = 1;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(118, 44);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(180, 22);
            this.textBoxUser.TabIndex = 0;
            // 
            // FormAcceptedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(336, 315);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(352, 354);
            this.MinimumSize = new System.Drawing.Size(352, 354);
            this.Name = "FormAcceptedInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Information";
            this.Load += new System.EventHandler(this.FormAcceptedInfo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxRegion;
        private TextBox textBoxDayHour;
        private TextBox textBoxRol;
        private TextBox textBoxUser;
        private Button buttonClose;
        private Label labelRol;
        private Label labelDayHour;
        private Label labelRegion;
        private Label labelUser;
    }
}
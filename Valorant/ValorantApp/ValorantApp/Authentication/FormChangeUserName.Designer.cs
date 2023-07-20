namespace ValorantApp.Authentication
{
    partial class FormChangeUserName
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.acceptButton = new System.Windows.Forms.Button();
            this.textboxUserName = new System.Windows.Forms.TextBox();
            this.labelUserPassword = new System.Windows.Forms.Label();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewUser = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelChangeUsername = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelUserName.Location = new System.Drawing.Point(121, 21);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 15);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "Username";
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(240, 294);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(97, 40);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // textboxUserName
            // 
            this.textboxUserName.Location = new System.Drawing.Point(121, 39);
            this.textboxUserName.Multiline = true;
            this.textboxUserName.Name = "textboxUserName";
            this.textboxUserName.Size = new System.Drawing.Size(193, 27);
            this.textboxUserName.TabIndex = 2;
            // 
            // labelUserPassword
            // 
            this.labelUserPassword.AutoSize = true;
            this.labelUserPassword.Location = new System.Drawing.Point(121, 85);
            this.labelUserPassword.Name = "labelUserPassword";
            this.labelUserPassword.Size = new System.Drawing.Size(57, 15);
            this.labelUserPassword.TabIndex = 4;
            this.labelUserPassword.Text = "Password";
            // 
            // textboxPassword
            // 
            this.textboxPassword.Location = new System.Drawing.Point(121, 103);
            this.textboxPassword.Multiline = true;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.PasswordChar = '*';
            this.textboxPassword.Size = new System.Drawing.Size(193, 27);
            this.textboxPassword.TabIndex = 5;
            // 
            // textBoxNewUser
            // 
            this.textBoxNewUser.Location = new System.Drawing.Point(121, 167);
            this.textBoxNewUser.Multiline = true;
            this.textBoxNewUser.Name = "textBoxNewUser";
            this.textBoxNewUser.Size = new System.Drawing.Size(193, 27);
            this.textBoxNewUser.TabIndex = 6;
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(121, 235);
            this.textBoxNewPassword.Multiline = true;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(193, 27);
            this.textBoxNewPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Password";
            // 
            // cancelChangeUsername
            // 
            this.cancelChangeUsername.Location = new System.Drawing.Point(371, 294);
            this.cancelChangeUsername.Name = "cancelChangeUsername";
            this.cancelChangeUsername.Size = new System.Drawing.Size(97, 40);
            this.cancelChangeUsername.TabIndex = 10;
            this.cancelChangeUsername.Text = "Cancel";
            this.cancelChangeUsername.UseVisualStyleBackColor = true;
            this.cancelChangeUsername.Click += new System.EventHandler(this.cancelChangeUsername_Click);
            // 
            // FormChangeUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 366);
            this.Controls.Add(this.cancelChangeUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxNewUser);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.labelUserPassword);
            this.Controls.Add(this.textboxUserName);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.labelUserName);
            this.Name = "FormChangeUserName";
            this.Text = "FormChangeUserName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelUserName;
        private Button acceptButton;
        private TextBox textboxUserName;
        private Label labelUserPassword;
        private TextBox textboxPassword;
        private TextBox textBoxNewUser;
        private TextBox textBoxNewPassword;
        private Label label1;
        private Label label2;
        private Button cancelChangeUsername;
    }
}
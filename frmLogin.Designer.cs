
namespace MyStoreWinApp
{
    partial class frmLogin
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
            label1 = new System.Windows.Forms.Label();
            Email = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbEmail = new System.Windows.Forms.TextBox();
            tbPassword = new System.Windows.Forms.TextBox();
            btLogin = new System.Windows.Forms.Button();
            btQuit = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(38, 50);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(311, 38);
            label1.TabIndex = 0;
            label1.Text = "Member Management";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Email.Location = new System.Drawing.Point(13, 124);
            Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Email.Name = "Email";
            Email.Size = new System.Drawing.Size(58, 25);
            Email.TabIndex = 1;
            Email.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(13, 161);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 25);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Location = new System.Drawing.Point(106, 118);
            tbEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new System.Drawing.Size(273, 31);
            tbEmail.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new System.Drawing.Point(106, 159);
            tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new System.Drawing.Size(273, 31);
            tbPassword.TabIndex = 4;
            // 
            // btLogin
            // 
            btLogin.BackColor = System.Drawing.Color.LimeGreen;
            btLogin.Location = new System.Drawing.Point(225, 214);
            btLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btLogin.Name = "btLogin";
            btLogin.Size = new System.Drawing.Size(104, 31);
            btLogin.TabIndex = 5;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            btLogin.Click += btLogin_Click;
            // 
            // btQuit
            // 
            btQuit.BackColor = System.Drawing.Color.Red;
            btQuit.Location = new System.Drawing.Point(57, 214);
            btQuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btQuit.Name = "btQuit";
            btQuit.Size = new System.Drawing.Size(104, 31);
            btQuit.TabIndex = 6;
            btQuit.Text = "Quit";
            btQuit.UseVisualStyleBackColor = false;
            btQuit.Click += btQuit_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(416, 278);
            Controls.Add(btQuit);
            Controls.Add(btLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btQuit;
    }
}
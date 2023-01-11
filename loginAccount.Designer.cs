using System;

namespace Perpustakaan_admin
{
    partial class loginAccount
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
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_daftar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_header = new System.Windows.Forms.Label();
            this.txt_idAdm = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(118, 181);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(155, 25);
            this.txt_pass.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.btn_login);
            this.panel2.Controls.Add(this.btn_daftar);
            this.panel2.Location = new System.Drawing.Point(12, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 67);
            this.panel2.TabIndex = 68;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.Location = new System.Drawing.Point(18, 20);
            this.btn_login.Name = "btn_login";
            this.btn_login.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_login.Size = new System.Drawing.Size(87, 32);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_daftar
            // 
            this.btn_daftar.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_daftar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_daftar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_daftar.FlatAppearance.BorderSize = 0;
            this.btn_daftar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_daftar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_daftar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_daftar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_daftar.Location = new System.Drawing.Point(114, 20);
            this.btn_daftar.Name = "btn_daftar";
            this.btn_daftar.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_daftar.Size = new System.Drawing.Size(80, 32);
            this.btn_daftar.TabIndex = 10;
            this.btn_daftar.Text = "Daftar";
            this.btn_daftar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_daftar.UseVisualStyleBackColor = false;
            this.btn_daftar.Click += new System.EventHandler(this.btn_daftar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Controls.Add(this.txt_idAdm);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 63);
            this.panel1.TabIndex = 63;
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(12, 19);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(183, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Masukan akun anda";
            // 
            // txt_idAdm
            // 
            this.txt_idAdm.Location = new System.Drawing.Point(45, 19);
            this.txt_idAdm.Multiline = true;
            this.txt_idAdm.Name = "txt_idAdm";
            this.txt_idAdm.Size = new System.Drawing.Size(138, 20);
            this.txt_idAdm.TabIndex = 71;
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(118, 122);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(237, 25);
            this.txt_nama.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Username";
            // 
            // loginAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 312);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label3);
            this.Name = "loginAccount";
            this.Text = "loginAccount";
            this.Load += new System.EventHandler(this.loginAccount_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void loginAccount_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        public System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_daftar;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label_header;
        public System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_idAdm;
    }
}
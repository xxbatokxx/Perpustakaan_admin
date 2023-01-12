namespace Perpustakaan_admin
{
    partial class peminjamanForm
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
            this.btn_simpan_pinjam = new System.Windows.Forms.Button();
            this.txt_idNim = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txt_namaUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kelas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tgl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idBuku = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_simpan_pinjam
            // 
            this.btn_simpan_pinjam.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_simpan_pinjam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_simpan_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_simpan_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_simpan_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_simpan_pinjam.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simpan_pinjam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_simpan_pinjam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_simpan_pinjam.Location = new System.Drawing.Point(281, 385);
            this.btn_simpan_pinjam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_simpan_pinjam.Name = "btn_simpan_pinjam";
            this.btn_simpan_pinjam.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_simpan_pinjam.Size = new System.Drawing.Size(113, 44);
            this.btn_simpan_pinjam.TabIndex = 52;
            this.btn_simpan_pinjam.Text = "SIMPAN";
            this.btn_simpan_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan_pinjam.UseVisualStyleBackColor = false;
            this.btn_simpan_pinjam.Click += new System.EventHandler(this.btn_simpan_pinjam_Click);
            // 
            // txt_idNim
            // 
            this.txt_idNim.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idNim.Location = new System.Drawing.Point(181, 185);
            this.txt_idNim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idNim.Name = "txt_idNim";
            this.txt_idNim.Size = new System.Drawing.Size(213, 29);
            this.txt_idNim.TabIndex = 23;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(35, 185);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(36, 22);
            this.label.TabIndex = 22;
            this.label.Text = "Nim";
            // 
            // txt_namaUser
            // 
            this.txt_namaUser.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namaUser.Location = new System.Drawing.Point(181, 132);
            this.txt_namaUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_namaUser.Name = "txt_namaUser";
            this.txt_namaUser.Size = new System.Drawing.Size(213, 29);
            this.txt_namaUser.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 132);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Nama user";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(16, 23);
            this.label_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(208, 31);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Form Peminjaman";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 78);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Kelas";
            // 
            // txt_kelas
            // 
            this.txt_kelas.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelas.Location = new System.Drawing.Point(181, 239);
            this.txt_kelas.Margin = new System.Windows.Forms.Padding(4);
            this.txt_kelas.Name = "txt_kelas";
            this.txt_kelas.Size = new System.Drawing.Size(213, 29);
            this.txt_kelas.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 55;
            this.label2.Text = "Tanggal pinjam";
            // 
            // txt_tgl
            // 
            this.txt_tgl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgl.Location = new System.Drawing.Point(181, 289);
            this.txt_tgl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.Size = new System.Drawing.Size(213, 29);
            this.txt_tgl.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 335);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "Id buku";
            // 
            // txt_idBuku
            // 
            this.txt_idBuku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idBuku.Location = new System.Drawing.Point(181, 335);
            this.txt_idBuku.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idBuku.Name = "txt_idBuku";
            this.txt_idBuku.Size = new System.Drawing.Size(213, 29);
            this.txt_idBuku.TabIndex = 58;
            // 
            // peminjamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 442);
            this.Controls.Add(this.txt_idBuku);
            this.Controls.Add(this.btn_simpan_pinjam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tgl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idNim);
            this.Controls.Add(this.txt_namaUser);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "peminjamanForm";
            this.Text = "peminjamanForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_simpan_pinjam;
        public System.Windows.Forms.TextBox txt_idNim;
        private System.Windows.Forms.Label label;
        public System.Windows.Forms.TextBox txt_namaUser;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_kelas;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txt_tgl;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_idBuku;
    }
}
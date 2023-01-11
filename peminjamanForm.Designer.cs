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
            this.txt_id_buku = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tgl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.txt_idUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btn_simpan_pinjam.Location = new System.Drawing.Point(181, 290);
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
            // txt_id_buku
            // 
            this.txt_id_buku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_buku.Location = new System.Drawing.Point(181, 227);
            this.txt_id_buku.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_id_buku.Name = "txt_id_buku";
            this.txt_id_buku.Size = new System.Drawing.Size(213, 29);
            this.txt_id_buku.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(35, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 22);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID Buku";
            // 
            // txt_tgl
            // 
            this.txt_tgl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgl.Location = new System.Drawing.Point(181, 171);
            this.txt_tgl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.Size = new System.Drawing.Size(213, 29);
            this.txt_tgl.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tanggal Pinjam";
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
            // txt_idUser
            // 
            this.txt_idUser.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idUser.Location = new System.Drawing.Point(181, 124);
            this.txt_idUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idUser.Name = "txt_idUser";
            this.txt_idUser.Size = new System.Drawing.Size(213, 29);
            this.txt_idUser.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "ID user";
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
            // peminjamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 372);
            this.Controls.Add(this.btn_simpan_pinjam);
            this.Controls.Add(this.txt_id_buku);
            this.Controls.Add(this.txt_tgl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idUser);
            this.Controls.Add(this.label3);
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
        public System.Windows.Forms.TextBox txt_id_buku;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_tgl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label_header;
        public System.Windows.Forms.TextBox txt_idUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
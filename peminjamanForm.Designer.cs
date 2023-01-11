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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_simpan_pinjam = new System.Windows.Forms.Button();
            this.dgv_buku_pinjam = new System.Windows.Forms.DataGridView();
            this.txt_id_buku = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_pinjam = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_tgl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.txt_idUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).BeginInit();
            this.panel_pinjam.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.btn_simpan_pinjam.Location = new System.Drawing.Point(403, 139);
            this.btn_simpan_pinjam.Name = "btn_simpan_pinjam";
            this.btn_simpan_pinjam.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_simpan_pinjam.Size = new System.Drawing.Size(85, 36);
            this.btn_simpan_pinjam.TabIndex = 52;
            this.btn_simpan_pinjam.Text = "SIMPAN";
            this.btn_simpan_pinjam.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_simpan_pinjam.UseVisualStyleBackColor = false;
            this.btn_simpan_pinjam.Click += new System.EventHandler(this.btn_simpan_pinjam_Click);
            // 
            // dgv_buku_pinjam
            // 
            this.dgv_buku_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_buku_pinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_buku_pinjam.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_buku_pinjam.Location = new System.Drawing.Point(15, 17);
            this.dgv_buku_pinjam.MultiSelect = false;
            this.dgv_buku_pinjam.Name = "dgv_buku_pinjam";
            this.dgv_buku_pinjam.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_buku_pinjam.RowHeadersWidth = 40;
            this.dgv_buku_pinjam.RowTemplate.Height = 28;
            this.dgv_buku_pinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buku_pinjam.Size = new System.Drawing.Size(682, 235);
            this.dgv_buku_pinjam.TabIndex = 44;
            // 
            // txt_id_buku
            // 
            this.txt_id_buku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_buku.Location = new System.Drawing.Point(403, 101);
            this.txt_id_buku.Name = "txt_id_buku";
            this.txt_id_buku.Size = new System.Drawing.Size(123, 25);
            this.txt_id_buku.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(330, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID Buku";
            // 
            // panel_pinjam
            // 
            this.panel_pinjam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_pinjam.Controls.Add(this.panel4);
            this.panel_pinjam.Location = new System.Drawing.Point(12, 187);
            this.panel_pinjam.Name = "panel_pinjam";
            this.panel_pinjam.Size = new System.Drawing.Size(757, 372);
            this.panel_pinjam.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.dgv_buku_pinjam);
            this.panel4.Location = new System.Drawing.Point(17, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 328);
            this.panel4.TabIndex = 1;
            // 
            // txt_tgl
            // 
            this.txt_tgl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgl.Location = new System.Drawing.Point(136, 139);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.Size = new System.Drawing.Size(161, 25);
            this.txt_tgl.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tanggal Pinjam";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(12, 19);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(164, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Form Peminjaman";
            // 
            // txt_idUser
            // 
            this.txt_idUser.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idUser.Location = new System.Drawing.Point(136, 101);
            this.txt_idUser.Name = "txt_idUser";
            this.txt_idUser.Size = new System.Drawing.Size(161, 25);
            this.txt_idUser.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "ID user";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 63);
            this.panel1.TabIndex = 43;
            // 
            // peminjamanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 583);
            this.Controls.Add(this.btn_simpan_pinjam);
            this.Controls.Add(this.panel_pinjam);
            this.Controls.Add(this.txt_id_buku);
            this.Controls.Add(this.txt_tgl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_idUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "peminjamanForm";
            this.Text = "peminjamanForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).EndInit();
            this.panel_pinjam.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_simpan_pinjam;
        public System.Windows.Forms.DataGridView dgv_buku_pinjam;
        public System.Windows.Forms.TextBox txt_id_buku;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.Panel panel_pinjam;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txt_tgl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label_header;
        public System.Windows.Forms.TextBox txt_idUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}
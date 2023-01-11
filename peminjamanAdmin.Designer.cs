namespace Perpustakaan_admin
{
    partial class peminjamanAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_page = new System.Windows.Forms.Label();
            this.txt_page = new System.Windows.Forms.TextBox();
            this.btn_next_page = new System.Windows.Forms.Button();
            this.btn_prev_page = new System.Windows.Forms.Button();
            this.cmb_length = new System.Windows.Forms.ComboBox();
            this.cmb_kategori_cari = new System.Windows.Forms.ComboBox();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.txt_cari = new System.Windows.Forms.TextBox();
            this.dgv_data_pinjam = new System.Windows.Forms.DataGridView();
            this.label_info = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_pinjam)).BeginInit();
            this.SuspendLayout();
            // 
            // label_page
            // 
            this.label_page.AutoSize = true;
            this.label_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_page.Location = new System.Drawing.Point(907, 623);
            this.label_page.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_page.Name = "label_page";
            this.label_page.Size = new System.Drawing.Size(30, 24);
            this.label_page.TabIndex = 63;
            this.label_page.Text = "/ 1";
            // 
            // txt_page
            // 
            this.txt_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_page.Location = new System.Drawing.Point(848, 619);
            this.txt_page.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_page.Name = "txt_page";
            this.txt_page.Size = new System.Drawing.Size(55, 30);
            this.txt_page.TabIndex = 62;
            this.txt_page.Text = "1";
            // 
            // btn_next_page
            // 
            this.btn_next_page.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_next_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_next_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_next_page.FlatAppearance.BorderSize = 0;
            this.btn_next_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next_page.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_next_page.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_next_page.Location = new System.Drawing.Point(973, 618);
            this.btn_next_page.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_next_page.Name = "btn_next_page";
            this.btn_next_page.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_next_page.Size = new System.Drawing.Size(87, 32);
            this.btn_next_page.TabIndex = 61;
            this.btn_next_page.Text = "NEXT";
            this.btn_next_page.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_next_page.UseVisualStyleBackColor = false;
            // 
            // btn_prev_page
            // 
            this.btn_prev_page.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_prev_page.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_prev_page.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prev_page.FlatAppearance.BorderSize = 0;
            this.btn_prev_page.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev_page.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prev_page.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_prev_page.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prev_page.Location = new System.Drawing.Point(749, 619);
            this.btn_prev_page.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_prev_page.Name = "btn_prev_page";
            this.btn_prev_page.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_prev_page.Size = new System.Drawing.Size(91, 32);
            this.btn_prev_page.TabIndex = 60;
            this.btn_prev_page.Text = "PREV";
            this.btn_prev_page.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_prev_page.UseVisualStyleBackColor = false;
            // 
            // cmb_length
            // 
            this.cmb_length.FormattingEnabled = true;
            this.cmb_length.Items.AddRange(new object[] {
            "5",
            "10",
            "20",
            "50"});
            this.cmb_length.Location = new System.Drawing.Point(105, 624);
            this.cmb_length.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_length.Name = "cmb_length";
            this.cmb_length.Size = new System.Drawing.Size(53, 24);
            this.cmb_length.TabIndex = 59;
            this.cmb_length.Text = "10";
            // 
            // cmb_kategori_cari
            // 
            this.cmb_kategori_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_kategori_cari.FormattingEnabled = true;
            this.cmb_kategori_cari.Items.AddRange(new object[] {
            "id_pinjam",
            "id_member",
            "tgl_pinjam"});
            this.cmb_kategori_cari.Location = new System.Drawing.Point(747, 129);
            this.cmb_kategori_cari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_kategori_cari.Name = "cmb_kategori_cari";
            this.cmb_kategori_cari.Size = new System.Drawing.Size(124, 28);
            this.cmb_kategori_cari.TabIndex = 58;
            this.cmb_kategori_cari.Text = "id_pinjam";
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(16, 126);
            this.btn_kembali.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Padding = new System.Windows.Forms.Padding(7, 0, 3, 0);
            this.btn_kembali.Size = new System.Drawing.Size(223, 39);
            this.btn_kembali.TabIndex = 57;
            this.btn_kembali.Text = "PEMINJAMAN BUKU";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // txt_cari
            // 
            this.txt_cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cari.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.txt_cari.Location = new System.Drawing.Point(884, 128);
            this.txt_cari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cari.Name = "txt_cari";
            this.txt_cari.Size = new System.Drawing.Size(172, 29);
            this.txt_cari.TabIndex = 56;
            // 
            // dgv_data_pinjam
            // 
            this.dgv_data_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pinjam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data_pinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pinjam.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data_pinjam.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_data_pinjam.Location = new System.Drawing.Point(9, 185);
            this.dgv_data_pinjam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_data_pinjam.MultiSelect = false;
            this.dgv_data_pinjam.Name = "dgv_data_pinjam";
            this.dgv_data_pinjam.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data_pinjam.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data_pinjam.RowHeadersWidth = 40;
            this.dgv_data_pinjam.RowTemplate.Height = 28;
            this.dgv_data_pinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_data_pinjam.Size = new System.Drawing.Size(1052, 412);
            this.dgv_data_pinjam.TabIndex = 54;
            this.dgv_data_pinjam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_pinjam_CellContentClick);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(0, 624);
            this.label_info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(14, 20);
            this.label_info.TabIndex = 53;
            this.label_info.Text = " ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(16, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 1);
            this.panel1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Peminjaman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 628);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "Menampilkan                  Data Buku.";
            // 
            // peminjamanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 711);
            this.Controls.Add(this.label_page);
            this.Controls.Add(this.txt_page);
            this.Controls.Add(this.btn_next_page);
            this.Controls.Add(this.btn_prev_page);
            this.Controls.Add(this.cmb_length);
            this.Controls.Add(this.cmb_kategori_cari);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.txt_cari);
            this.Controls.Add(this.dgv_data_pinjam);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "peminjamanAdmin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.peminjamanAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data_pinjam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_page;
        public System.Windows.Forms.TextBox txt_page;
        public System.Windows.Forms.Button btn_next_page;
        public System.Windows.Forms.Button btn_prev_page;
        public System.Windows.Forms.ComboBox cmb_length;
        private System.Windows.Forms.ComboBox cmb_kategori_cari;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.TextBox txt_cari;
        private System.Windows.Forms.DataGridView dgv_data_pinjam;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
namespace Perpustakaan_admin
{
    partial class pengembalianForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.check_denda = new System.Windows.Forms.CheckBox();
            this.dgv_buku_pinjam = new System.Windows.Forms.DataGridView();
            this.panel_pinjam = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.txt_denda = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_tgl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_header = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_namaAdm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).BeginInit();
            this.panel_pinjam.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // check_denda
            // 
            this.check_denda.AutoSize = true;
            this.check_denda.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_denda.Location = new System.Drawing.Point(168, 284);
            this.check_denda.Name = "check_denda";
            this.check_denda.Size = new System.Drawing.Size(83, 20);
            this.check_denda.TabIndex = 45;
            this.check_denda.Text = "Buku Hilang";
            this.check_denda.UseVisualStyleBackColor = true;
            // 
            // dgv_buku_pinjam
            // 
            this.dgv_buku_pinjam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_buku_pinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_buku_pinjam.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_buku_pinjam.Location = new System.Drawing.Point(15, 17);
            this.dgv_buku_pinjam.MultiSelect = false;
            this.dgv_buku_pinjam.Name = "dgv_buku_pinjam";
            this.dgv_buku_pinjam.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_buku_pinjam.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_buku_pinjam.RowHeadersWidth = 40;
            this.dgv_buku_pinjam.RowTemplate.Height = 28;
            this.dgv_buku_pinjam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_buku_pinjam.Size = new System.Drawing.Size(679, 235);
            this.dgv_buku_pinjam.TabIndex = 44;
            // 
            // panel_pinjam
            // 
            this.panel_pinjam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_pinjam.Controls.Add(this.panel4);
            this.panel_pinjam.Location = new System.Drawing.Point(12, 187);
            this.panel_pinjam.Name = "panel_pinjam";
            this.panel_pinjam.Size = new System.Drawing.Size(757, 372);
            this.panel_pinjam.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.check_denda);
            this.panel4.Controls.Add(this.dgv_buku_pinjam);
            this.panel4.Controls.Add(this.txt_denda);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(17, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 328);
            this.panel4.TabIndex = 1;
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_kembali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_kembali.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_kembali.Location = new System.Drawing.Point(364, 113);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Padding = new System.Windows.Forms.Padding(5, 0, 2, 0);
            this.btn_kembali.Size = new System.Drawing.Size(98, 33);
            this.btn_kembali.TabIndex = 42;
            this.btn_kembali.Text = "KEMBALIKAN";
            this.btn_kembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_kembali.UseVisualStyleBackColor = false;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // txt_denda
            // 
            this.txt_denda.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_denda.Location = new System.Drawing.Point(61, 281);
            this.txt_denda.Name = "txt_denda";
            this.txt_denda.ReadOnly = true;
            this.txt_denda.Size = new System.Drawing.Size(99, 25);
            this.txt_denda.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Denda";
            // 
            // txt_tgl
            // 
            this.txt_tgl.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tgl.Location = new System.Drawing.Point(170, 139);
            this.txt_tgl.Name = "txt_tgl";
            this.txt_tgl.ReadOnly = true;
            this.txt_tgl.Size = new System.Drawing.Size(161, 25);
            this.txt_tgl.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tanggal pemgembalian";
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_header.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_header.Location = new System.Drawing.Point(12, 19);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(181, 25);
            this.label_header.TabIndex = 0;
            this.label_header.Text = "Form Pengembalian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "Nama user";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label_header);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 63);
            this.panel1.TabIndex = 44;
            // 
            // txt_namaAdm
            // 
            this.txt_namaAdm.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_namaAdm.Location = new System.Drawing.Point(164, 98);
            this.txt_namaAdm.Name = "txt_namaAdm";
            this.txt_namaAdm.ReadOnly = true;
            this.txt_namaAdm.Size = new System.Drawing.Size(167, 25);
            this.txt_namaAdm.TabIndex = 50;
            // 
            // pengembalianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 577);
            this.Controls.Add(this.panel_pinjam);
            this.Controls.Add(this.txt_tgl);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_namaAdm);
            this.Name = "pengembalianForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_buku_pinjam)).EndInit();
            this.panel_pinjam.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox check_denda;
        public System.Windows.Forms.DataGridView dgv_buku_pinjam;
        public System.Windows.Forms.Panel panel_pinjam;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Button btn_kembali;
        public System.Windows.Forms.TextBox txt_denda;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txt_tgl;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label_header;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txt_namaAdm;
    }
}
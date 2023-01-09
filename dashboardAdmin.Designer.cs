using System;
using System.Windows.Forms;

namespace Perpustakaan_admin
{
    partial class dashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboardAdmin));
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_content = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_buku = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_pinjam = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_account = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.status_bar = new System.Windows.Forms.StatusStrip();
            this.status_id = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_nama = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_level = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu_bar = new System.Windows.Forms.MenuStrip();
            this.tentangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel_content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_account.SuspendLayout();
            this.status_bar.SuspendLayout();
            this.menu_bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.keluarToolStripMenuItem.Text = "&Keluar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_content);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(254, 107);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.panel2.Size = new System.Drawing.Size(840, 620);
            this.panel2.TabIndex = 16;
            // 
            // panel_content
            // 
            this.panel_content.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_content.Controls.Add(this.button1);
            this.panel_content.Controls.Add(this.pictureBox4);
            this.panel_content.Controls.Add(this.btn_buku);
            this.panel_content.Controls.Add(this.pictureBox1);
            this.panel_content.Controls.Add(this.btn_kembali);
            this.panel_content.Controls.Add(this.btn_pinjam);
            this.panel_content.Controls.Add(this.pictureBox2);
            this.panel_content.Controls.Add(this.pictureBox3);
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_content.Location = new System.Drawing.Point(20, 0);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(820, 600);
            this.panel_content.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(100, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ubah profile";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(100, 329);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(164, 135);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // btn_buku
            // 
            this.btn_buku.BackColor = System.Drawing.Color.LightGray;
            this.btn_buku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buku.FlatAppearance.BorderSize = 0;
            this.btn_buku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buku.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buku.Location = new System.Drawing.Point(100, 229);
            this.btn_buku.Name = "btn_buku";
            this.btn_buku.Size = new System.Drawing.Size(164, 37);
            this.btn_buku.TabIndex = 8;
            this.btn_buku.Text = "Data Buku";
            this.btn_buku.UseVisualStyleBackColor = false;
            this.btn_buku.Click += new System.EventHandler(this.btn_buku_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_kembali
            // 
            this.btn_kembali.BackColor = System.Drawing.Color.LightGray;
            this.btn_kembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kembali.FlatAppearance.BorderSize = 0;
            this.btn_kembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kembali.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.Location = new System.Drawing.Point(511, 229);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(164, 37);
            this.btn_kembali.TabIndex = 11;
            this.btn_kembali.Text = "Pemgembalian";
            this.btn_kembali.UseVisualStyleBackColor = false;
            // 
            // btn_pinjam
            // 
            this.btn_pinjam.BackColor = System.Drawing.Color.LightGray;
            this.btn_pinjam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pinjam.FlatAppearance.BorderSize = 0;
            this.btn_pinjam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pinjam.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pinjam.Location = new System.Drawing.Point(511, 451);
            this.btn_pinjam.Name = "btn_pinjam";
            this.btn_pinjam.Size = new System.Drawing.Size(164, 37);
            this.btn_pinjam.TabIndex = 10;
            this.btn_pinjam.Text = "Peminjaman";
            this.btn_pinjam.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(511, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(511, 329);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 135);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_id);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_nama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 620);
            this.panel1.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 43);
            this.panel5.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(62, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "User Account";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(17, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID admin :";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_id.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_id.Location = new System.Drawing.Point(100, 69);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(51, 20);
            this.lbl_id.TabIndex = 9;
            this.lbl_id.Text = "000001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(17, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nama :";
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nama.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_nama.Location = new System.Drawing.Point(73, 100);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(84, 20);
            this.lbl_nama.TabIndex = 11;
            this.lbl_nama.Text = "Kahfi Baidowi";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 107);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 20);
            this.panel3.Size = new System.Drawing.Size(1439, 620);
            this.panel3.TabIndex = 17;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel_account
            // 
            this.panel_account.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel_account.Controls.Add(this.label2);
            this.panel_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_account.Location = new System.Drawing.Point(0, 30);
            this.panel_account.Name = "panel_account";
            this.panel_account.Size = new System.Drawing.Size(1439, 77);
            this.panel_account.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selamat datang di dashboard admin perpus GUI";
            // 
            // status_bar
            // 
            this.status_bar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_bar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_id,
            this.status_nama,
            this.status_level});
            this.status_bar.Location = new System.Drawing.Point(0, 727);
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(1439, 31);
            this.status_bar.TabIndex = 12;
            this.status_bar.Text = "status_bar";
            // 
            // status_id
            // 
            this.status_id.Name = "status_id";
            this.status_id.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_id.Size = new System.Drawing.Size(49, 26);
            this.status_id.Text = "987654";
            // 
            // status_nama
            // 
            this.status_nama.Name = "status_nama";
            this.status_nama.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_nama.Size = new System.Drawing.Size(82, 26);
            this.status_nama.Text = "status_nama";
            // 
            // status_level
            // 
            this.status_level.Name = "status_level";
            this.status_level.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.status_level.Size = new System.Drawing.Size(75, 26);
            this.status_level.Text = "status_level";
            // 
            // menu_bar
            // 
            this.menu_bar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menu_bar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_bar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tentangToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menu_bar.Location = new System.Drawing.Point(0, 0);
            this.menu_bar.Name = "menu_bar";
            this.menu_bar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_bar.Size = new System.Drawing.Size(1439, 30);
            this.menu_bar.Stretch = false;
            this.menu_bar.TabIndex = 11;
            this.menu_bar.Text = "menu_bar";
            // 
            // tentangToolStripMenuItem
            // 
            this.tentangToolStripMenuItem.Name = "tentangToolStripMenuItem";
            this.tentangToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tentangToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.tentangToolStripMenuItem.Text = "&Tentang";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(12, 328);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(224, 39);
            this.button6.TabIndex = 13;
            this.button6.Text = "Member/Anggota";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 758);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_account);
            this.Controls.Add(this.status_bar);
            this.Controls.Add(this.menu_bar);
            this.Controls.Add(this.button6);
            this.Name = "dashboardAdmin";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel_content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_account.ResumeLayout(false);
            this.panel_account.PerformLayout();
            this.status_bar.ResumeLayout(false);
            this.status_bar.PerformLayout();
            this.menu_bar.ResumeLayout(false);
            this.menu_bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_content;
        private System.Windows.Forms.Button btn_buku;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_pinjam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_account;
        public System.Windows.Forms.StatusStrip status_bar;
        public System.Windows.Forms.ToolStripStatusLabel status_id;
        public System.Windows.Forms.ToolStripStatusLabel status_nama;
        private System.Windows.Forms.MenuStrip menu_bar;
        private System.Windows.Forms.ToolStripMenuItem tentangToolStripMenuItem;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolStripStatusLabel status_level;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}


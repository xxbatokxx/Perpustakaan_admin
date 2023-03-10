using Perpustakaan_admin.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_admin
{
    public partial class peminjamanForm : Form
    {
        public peminjamanForm()
        {
            InitializeComponent();
        }

        peminjaman Peminjaman = new peminjaman();
        Buku buku = new Buku();

        private void btn_simpan_pinjam_Click(object sender, EventArgs e)
        {
            
            string nama_user = txt_namaUser.Text;
            string nim = txt_idNim.Text;
            string kelas = txt_kelas.Text;
            string tgl_pinjam = txt_tgl.Text;
            string id_buku = txt_idBuku.Text;


            if (nama_user.Trim().Equals("") )
            {
                MessageBox.Show("Masukan id user terlebih dahulu!",
                    "User baru",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (Peminjaman.addPeminjaman(nama_user, nim, kelas, tgl_pinjam, id_buku) == 1)
                {
                    MessageBox.Show("Ada yang baru pinjam buku",
                    "New Genre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                new peminjamanAdmin().Show();
                this.Hide();
            }
        }
    }
}

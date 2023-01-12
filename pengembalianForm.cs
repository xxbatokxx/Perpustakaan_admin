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
    public partial class pengembalianForm : Form
    {
        public pengembalianForm()
        {
            InitializeComponent();
        }

        pengembalian Pengembalian = new pengembalian();

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void showBukuPinjam()
        {
            
        }
        private void btn_kembali_Click(object sender, EventArgs e)
        {
            string nama_user = txt_namaUser.Text;
            string tgl_kembali = txt_tgl.Text;
            string id_buku = txt_idBuku.Text;

            if (nama_user.Trim().Equals(""))
            {
                MessageBox.Show("Masukan nama terlebih dahulu");
                MessageBox.Show("Masukan id user terlebih dahulu!",
                    "User baru",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (Pengembalian.addKembali(nama_user, tgl_kembali, id_buku) == 1)
                {
                    MessageBox.Show("Ada yang baru kembalikan buku",
                    "New Genre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                new pengembalianAdmin().Show();
                this.Hide();
            }
        }

            
        
    }
}

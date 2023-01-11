using MySql.Data.MySqlClient;
using Perpustakaan;
using Perpustakaan_admin.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Perpustakaan_admin
{
    public partial class formBuku : Form
    {

        Buku buku = new Buku();

        public formBuku()
        {
            InitializeComponent();
        }


        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string id_buku = txt_id.Text;
            string judul = txt_judul.Text;
            string pengarang = txt_pengarang.Text;
            string penerbit = txt_penerbit.Text;
            string status = cmb_status.Text;

            if (id_buku.Trim().Equals(""))
            {
                MessageBox.Show("masukan id terlebih dahulu terlebih dahulu", "penerbit kosong",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (judul.Trim().Equals(""))
            {
                   MessageBox.Show("isi judul buku terlebih dahulu", "judul buku kosong",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            else if(pengarang.Trim().Equals(""))
            {
                  MessageBox.Show("Isi pengarang terlebih dahulu","pengarang kosong",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
            else if (penerbit.Trim().Equals(""))
            {
                MessageBox.Show("Isi penerbit terlebih dahulu", "penerbit kosong",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
               if (buku.addBuku(id_buku, judul, pengarang, penerbit, status) == 1)
                {
                    MessageBox.Show("New buku sudah ditambah!",
                    "New Genre",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
               else
                {
                    MessageBox.Show("data tidak terisi", "data kosong",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                }
               this.Hide();
               new bukuAdmin().Show();
                
            }
           
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            string id_buku = txt_id.Text;
            string judul = txt_judul.Text;
            string pengarang = txt_pengarang.Text;
            string penerbit = txt_penerbit.Text;
            string status = cmb_status.Text;

            if (buku.updateBuku(id_buku, judul, pengarang, penerbit, status) == 1)
            {
                MessageBox.Show("Buku sudah di update!",
                "Buku baru",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("data tidak terisi", "data kosong",
           MessageBoxButtons.OK,
           MessageBoxIcon.Error);
            }
            this.Hide();
            new bukuAdmin().Show();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            string id_buku = txt_id.Text;

            if (buku.RemoveBuku(id_buku) == 1)
            {
                MessageBox.Show("Data buku sudah dihapus!",
                    "hapus buku",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txt_id.Text = "";
                txt_judul.Text = "";
                txt_penerbit.Text = "";
                txt_pengarang.Text = "";
                cmb_status.Text = "";
            }
            else
            {
                MessageBox.Show("Data buku tidak terhapus",
                "Delete Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            this.Hide();
            new bukuAdmin().Show();

        }
    }
}

using MySql.Data.MySqlClient;
using Perpustakaan;
using Perpustakaan_admin.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perpustakaan_admin
{
    public partial class userForm : Form
    {

        
        public userForm()
        {
            InitializeComponent();
        }

        Users userss = new Users();


        private void btn_tambah_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(txt_id.Text);
            string nama = txt_nama.Text;
            int nim = Convert.ToInt32(txt_nim.Text);
            string kelas = txt_kelas.Text;

            if (nama.Trim().Equals(""))
            {
                MessageBox.Show("masukan nama terlebih dahulu", "nama kosong",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (kelas.Trim().Equals(""))
            {
                MessageBox.Show("Isi pengarang terlebih dahulu", "pengarang kosong",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (userss.addUsers(id_user, nama, nim, kelas) == 1)
                {
                    MessageBox.Show("User baru sudah ditambah!",
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
                new user().Show();
                this.Hide();
                    

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(txt_id.Text);
            string nama = txt_nama.Text;
            int nim = Convert.ToInt32(txt_nim.Text);
            string kelas = txt_kelas.Text;

            if (userss.updateUsers(id_user, nama, nim, kelas) == 1)
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
            new user().Show();
            this.Hide();
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(txt_id.Text);

            if (userss.RemoveUser(id_user) == 1)
            {
                MessageBox.Show("Data buku sudah dihapus!",
                    "hapus buku",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txt_id.Text = "";
                txt_nama.Text = "";
                txt_nim.Text = "";
            }
            else
            {
                MessageBox.Show("Data buku tidak terhapus",
                "Delete Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            new user().Show();
            this.Hide();
        }
    }
       

}

using MySql.Data.MySqlClient;
using System;
using System.Data.Entity;
using Perpustakaan_admin;
using System.Windows.Forms;
using Perpustakaan_admin.model;

namespace Perpustakaan_admin
{
    public partial class daftarAccount : Form
    {
        admin adm = new admin();

        public daftarAccount(dashboardAdmin dashboardAdmin)
        {
            InitializeComponent();
        }

        private void daftarAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {

            int id_admin = Convert.ToInt32(txt_id.Text);
   
            string username = txt_nama.Text;
            string password_admin = txt_pass.Text;


            if (username.Trim().Equals(""))
            {
                MessageBox.Show("masukan nama terlebih dahulu terlebih dahulu", "username sudah terdaftar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (password_admin.Trim().Equals(""))
            {
                MessageBox.Show("buat password terlebih dahulu", "password sudah terdaftar",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }

            else
            {
                if (adm.addAdmin( id_admin, username, password_admin) == 1)
                {
                    MessageBox.Show("New Data Added Successfully!",
                    "New Data",
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

            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            new loginAccount().Show();
            this.Hide();

        }

        private void txt_Id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Perpustakaan_admin
{
    public partial class daftarAccount : Form
    {
        public daftarAccount(dashboardAdmin dashboardAdmin)
        {
            InitializeComponent();
        }

        public daftarAccount()
        {
        }

        private void daftarAccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {  
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

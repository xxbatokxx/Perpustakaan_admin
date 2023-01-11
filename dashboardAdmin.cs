using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Perpustakaan_admin
{
    public partial class dashboardAdmin : Form
    {
        public dashboardAdmin()
        {
            InitializeComponent();
        }

        private model.Users pg = new model.Users();
        private void btn_buku_Click(object sender, EventArgs e)
        {
            bukuAdmin buku= new bukuAdmin();
            buku.Show();
            this.Hide();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
              

        }

        private void dashboardAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            new pengembalianAdmin().Show();
            this.Hide();
        }

        private void btn_pinjam_Click(object sender, EventArgs e)
        {
            new peminjamanAdmin().Show();
            this.Hide();
        }
    }
}

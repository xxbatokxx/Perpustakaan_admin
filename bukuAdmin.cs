using MySql.Data.MySqlClient;
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
    public partial class bukuAdmin : Form
    {
        

        public bukuAdmin()
        {
            InitializeComponent();
        }

        

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            new formBuku().Show();
            this.Hide();
        }

        public void tampil_buku()
        {
           
        }

        private void dgv_data_buku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bukuAdmin_Load(object sender, EventArgs e)
        {
           
        }


    }
}

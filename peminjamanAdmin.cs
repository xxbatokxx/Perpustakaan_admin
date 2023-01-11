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
    public partial class peminjamanAdmin : Form
    {
        public peminjamanAdmin()
        {
            InitializeComponent();
        }

        peminjaman Peminjaman = new peminjaman();

        private void dgv_data_pinjam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            new peminjamanForm().Show();
            this.Hide();
        }

        private void peminjamanAdmin_Load(object sender, EventArgs e)
        {
            dgv_data_pinjam.DataSource = Peminjaman.viewPinjam();
            dgv_data_pinjam.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_data_pinjam.EnableHeadersVisualStyles = false;
        }
    }
}

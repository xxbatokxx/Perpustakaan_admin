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

        private void dgv_data_pinjam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            new peminjamanForm().Show();
            this.Hide();
        }
    }
}

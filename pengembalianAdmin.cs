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
    public partial class pengembalianAdmin : Form
    {
        public pengembalianAdmin()
        {
            InitializeComponent();
        }

        pengembalian Pengembalian = new pengembalian();
        private void btn_kembali_Click(object sender, EventArgs e)
        {
            new pengembalianForm().Show();
            this.Hide();
        }

        private void pengembalianAdmin_Load(object sender, EventArgs e)
        {
            dgv_data_kembali.DataSource = Pengembalian.viewPengembalian();
            dgv_data_kembali.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_data_kembali.EnableHeadersVisualStyles = false;
        }
    }
}

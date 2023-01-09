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
    public partial class dashboardAdmin : Form
    {
        public dashboardAdmin()
        {
            InitializeComponent();
        }

        private void btn_buku_Click(object sender, EventArgs e)
        {
            bukuAdmin buku= new bukuAdmin();
            buku.Show();
            this.Hide();
        }
    }
}

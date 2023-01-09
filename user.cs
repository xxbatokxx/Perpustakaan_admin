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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void label_info_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            new userForm().Show();
            this.Hide();
        }
    }
}

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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }
        
        Users userss = new Users();

        private void label_info_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            new userForm().Show();
            this.Hide();
        }

        private void dgv_data_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void user_Load(object sender, EventArgs e)
        {
            dgv_data_member.DataSource = userss.viewUser();
            dgv_data_member.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv_data_member.EnableHeadersVisualStyles = false;
        }

        

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            new userForm().Show();
            this.Hide();
        }


    }
}

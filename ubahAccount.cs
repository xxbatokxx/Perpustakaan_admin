using Perpustakaan_admin.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Perpustakaan_admin
{
    public partial class ubahAccount : Form
    {

        private readonly admin _admin;
        private int id_admin;
        private string username;

        public ubahAccount()
        {
            InitializeComponent();
             _admin = new admin();
           
        }
        private void UpdateAccountForm_Load(object sender, System.EventArgs e)
        {
            // Load data from the database and display it in the textboxes
            var admin = _admin.GetAccount(id_admin);
            txt_nama.Text = admin.username;
            txt_pass.Text = admin.password_admin;
        }



        private void btn_update_Click(object sender, EventArgs e)
        {
            _admin.id_admin = id_admin;
            _admin.username = username;

            //adm.UpdateAccount(Convert.ToInt32(txt_id.Text), txt_nama.Text, txt_pass.Text);
            MessageBox.Show("Berhasil Mengubah Data Admin.!", "Message");
            this.Hide();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
        }
    }
}

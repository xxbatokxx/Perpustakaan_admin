using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Perpustakaan;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySqlX.XDevAPI.Common;

namespace Perpustakaan_admin
{
    public partial class loginAccount : Form
    {

        public loginAccount()
        {
            InitializeComponent();
        }


        private void btn_daftar_Click(object sender, EventArgs e)
        {
            new daftarAccount().Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string nama = txt_nama.Text;
            string password = txt_pass.Text;
            string id_admin = txt_idAdm.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(

            "SELECT * FROM `admin` WHERE `username`=@username AND `password_admin`=@password_admin", db.GetConnection());

            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = nama;
            command.Parameters.Add("@password_admin", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);
      
           

            if (table.Rows.Count == 1)
            {
                
                this.Hide();
               
            }
            else
            {
                if (nama.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your nama to login", "Empty nama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your password to login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    MessageBox.Show("Wrong your nama r password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}

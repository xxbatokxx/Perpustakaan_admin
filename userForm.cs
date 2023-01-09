using MySql.Data.MySqlClient;
using Perpustakaan;
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
    public partial class userForm : Form
    {
        public userForm()
        {
            InitializeComponent();
        }

       

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                Console.WriteLine("Connected to MySql database!");
                string queryString = "INSERT INTO buku VALUES (@id_user, @nama, @nim, @kelas)";

                MySqlCommand command = new MySqlCommand(queryString, conn);

                command.Parameters.AddWithValue("@id_user", txt_idUser.Text);
                command.Parameters.AddWithValue("@nama", txt_nama.Text);
                command.Parameters.AddWithValue("@nim", txt_nim.Text);
                command.Parameters.AddWithValue("@kelas", txt_kelas.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Sukses simpan data");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {


                this.Hide();
                conn.Close();

            }
        }
    }
}

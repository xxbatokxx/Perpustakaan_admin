using MySql.Data.MySqlClient;
using Perpustakaan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Perpustakaan_admin
{
    public partial class formBuku : Form
    {

        Database db = new Database();

        public formBuku()
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
                string queryString = "INSERT INTO buku VALUES (@id_buku, @judul, @pengarang, @penerbit, @status)";
                
                MySqlCommand command = new MySqlCommand(queryString, conn);

                command.Parameters.AddWithValue("@id_Buku", txt_id.Text);
                command.Parameters.AddWithValue("@judul", txt_judul.Text);
                command.Parameters.AddWithValue("@pengarang", txt_pengarang.Text);
                command.Parameters.AddWithValue("@penerbit", txt_penerbit.Text);
                command.Parameters.AddWithValue("@status", cmb_kategori.Text);
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

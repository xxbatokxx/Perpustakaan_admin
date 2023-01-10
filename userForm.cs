using MySql.Data.MySqlClient;
using Perpustakaan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
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
                string queryString = "INSERT INTO users VALUES (@id_user, @nama, @nim, @kelas)";

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
            //catch (namaException ex)
            //{
                //MessageBox.Show("Masukan nama terlebih dahulu");
            //}
            finally 
            {
                this.Hide();
                conn.Close();

            }
        }

       

        private void button_Click(object sender, EventArgs e)
        {

            Database db = new Database();
            string connectionString = "server=localhost;port=3306;username=root;password=;database=perpustakaan";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();


            string queryString = "UPDATE users SET nama=@nama, nim=@nim, kelas=@kelas WHERE nim=@nim ";

            MySqlCommand command = new MySqlCommand(queryString, conn);

            command.Parameters.AddWithValue("@id_user", txt_idUser.Text);
            command.Parameters.AddWithValue("@nama", txt_nama.Text);
            command.Parameters.AddWithValue("@nim", txt_nim.Text);
            command.Parameters.AddWithValue("@kelas", txt_kelas.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Sukses edit data");
            conn.Close();
            
        }
    }

    [Serializable]
    internal class namaException : Exception
    {
        public namaException()
        {
        }

        public namaException(string message) : base(message)
        {
        }

        public namaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected namaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

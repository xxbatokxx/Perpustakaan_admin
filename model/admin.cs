using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Perpustakaan_admin.model
{
    public class admin
    {

        Database db = new Database();
        private readonly MySqlConnection connect;

        public int id_admin { get; set; }

        public string username { get; set; }

        public string password_admin { get; set; }

       // public string count_search(string k, string q)
      //  {
           // var result = db.("select count(*) from admin");
           // return result.Rows[0][0].ToString();
       // }

        public int addAdmin(int id_admin, string username, string password_admin)
        {
            string queryString = "INSERT INTO admin VALUES (@id_admin, @username, @password_admin)";
            MySqlParameter[] parameters = new MySqlParameter[3];

            parameters[0] = new MySqlParameter("@id_admin", MySqlDbType.Int32);
            parameters[1] = new MySqlParameter("@username", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@password_admin", MySqlDbType.VarChar);
           

            parameters[0].Value = id_admin;
            parameters[1].Value = username;
            parameters[2].Value = password_admin;
           

            return db.setData(queryString, parameters);

        }

       
           
          
        

        public void UpdateAccount(int id_admin, string username, string password_admin)
        {
            // Update the account information in the database
            string updateQuery = "UPDATE admin SET username = @username, password_admin = @password WHERE id_admin = @id_admin";
            MySqlCommand command = new MySqlCommand(updateQuery, connect);
            command.Parameters.AddWithValue("@id_admin", id_admin);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password_admin);
            try
            {
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public admin GetAccount(int id_admin)
        {
            // Load data from the database
            string selectQuery = "SELECT * FROM admin WHERE id_admin = @id_admin";
            MySqlCommand command = new MySqlCommand(selectQuery, connect);
            command.Parameters.AddWithValue("@id_admin", id_admin);
            MySqlDataReader reader;
            try
            {
                connect.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return new admin()
                    {
                        id_admin = Convert.ToInt32(reader["id_admin"]),
                        username = reader["username"].ToString(),
                        password_admin = reader["password_admin"].ToString()
                    };
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }

}


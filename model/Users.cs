using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Perpustakaan_admin.model
{
    internal class Users
    {
        Database db = new Database();
        public int id_user { get; set; }
        public string nama { get; set; }
        public int nim { get; set; }
        public string kelas { get; set; }

        public int addUsers(int id_user, string nama, int nim, string kelas)
        {
            string queryString = "INSERT INTO users VALUES (@id_user, @nama, @nim, kelas)";
            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@id_user", MySqlDbType.Int32);
            parameters[1] = new MySqlParameter("@nama", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@nim", MySqlDbType.Int32);
            parameters[3] = new MySqlParameter("@kelas", MySqlDbType.VarChar);

            parameters[0].Value = id_user;
            parameters[1].Value = nama;
            parameters[2].Value = nim;
            parameters[3].Value = kelas;

            return db.setData(queryString, parameters);
        }

        public int updateUsers(int id_user, string nama, int nim, string kelas)
        {
            string queryString = "UPDATE users SET id_user=@id_user, nama=@nama, nim=@nim, kelas=@kelas WHERE id_user=@id_user";

            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@id_user", MySqlDbType.Int32);
            parameters[1] = new MySqlParameter("@nama", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@nim", MySqlDbType.Int32);
            parameters[3] = new MySqlParameter("@kelas", MySqlDbType.VarChar);

            parameters[0].Value = id_user;
            parameters[1].Value = nama;
            parameters[2].Value = nim;
            parameters[3].Value = kelas;

            return db.setData(queryString, parameters);
        }

        public int RemoveUser(int id_user)
        {
            string queryString = "DELETE FROM users WHERE id_user=@id_user";

            MySqlParameter[] parameters = new MySqlParameter[1];

            parameters[0] = new MySqlParameter("@id_user", MySqlDbType.Int32);
            parameters[0].Value = id_user;

            return db.setData(queryString, parameters);

        }

        public DataTable viewUser()
        {
            DataTable dt = new DataTable();
            dt = db.getData("SELECT * FROM users", null);

            return dt;
        }
    }
}

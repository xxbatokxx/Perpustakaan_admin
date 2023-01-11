using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_admin.model
{
    internal class pengembalian
    {
        Database db = new Database();

        public int id_user { get; set; }

        public string nama { get; set; }
        public int id_pinjam { get; set; }
        public string tgl_kembali { get; set; }

        public int addKembali(int id_user, string nama, int id_pinjam, string tgl_kembali)
        {
            string queryString = "INSERT INTO pinjam VALUES (@id_user, @nama, @id_pinjam, @tgl_pinjam)";
            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@id_user", MySqlDbType.Int32);
            parameters[1] = new MySqlParameter("@nama", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@id_pinjam", MySqlDbType.Int32);
            parameters[3] = new MySqlParameter("@tgl_kembali", MySqlDbType.VarChar);

            parameters[0].Value = id_user;
            parameters[2].Value = nama;
            parameters[1].Value = id_pinjam;
            parameters[2].Value = tgl_kembali;

            return db.setData(queryString, parameters);
        }
    }
}

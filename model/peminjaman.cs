using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan_admin.model
{
    internal class peminjaman
    {
        Database db = new Database();

        public int id_pinjam { get; set; }

        public string id_user { get; set; }

        public string tgl_pinjam { get; set; }

        public string id_buku { get; set; }

        public string status { get; set; }

        public int addPeminjaman(string id_user, string tgl_pinjam, string id_buku)
        {
            string queryString = "INSERT INTO pinjam VALUES (@id_pinjam, @id_user, @tgl_pinjam, @id_buku, 'Di pinjam')";
            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@id_pinjam", MySqlDbType.VarChar);
            parameters[1] = new MySqlParameter("@id_user", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@tgl_pinjam", MySqlDbType.VarChar);
            parameters[3] = new MySqlParameter("@id_buku", MySqlDbType.VarChar);
          

            parameters[1].Value = id_user;
            parameters[2].Value = tgl_pinjam;
            parameters[3].Value = id_buku;

            return db.setData(queryString, parameters);
        }
    }
}

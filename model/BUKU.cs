using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Perpustakaan_admin.model
{
    public class Buku
    {
        Database db = new Database();
        public string id_buku { get; set; }
        public string judul { get; set; }
        public string pengarang { get; set; }
        public string penerbit { get; set; }
        public string status { get; set; }


        

        public int addBuku(string id_buku, string judul, string pengarang, string penerbit, string status)
        {
            string queryString = "INSERT INTO buku VALUES (@id_buku, @judul, @pengarang, @penerbit, @status)";
            MySqlParameter[] parameters = new MySqlParameter[5];

            parameters[0] = new MySqlParameter("@id_buku", MySqlDbType.VarChar);
            parameters[1] = new MySqlParameter("@judul", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@pengarang", MySqlDbType.VarChar);
            parameters[3] = new MySqlParameter("@penerbit", MySqlDbType.VarChar);
            parameters[4] = new MySqlParameter("@status", MySqlDbType.VarChar);

            parameters[0].Value  = id_buku;
            parameters[1].Value = judul;
            parameters[2].Value = pengarang;
            parameters[3].Value = penerbit;
            parameters[4].Value = status;

            return db.setData(queryString, parameters);
            
        }

    }
}

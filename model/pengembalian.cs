using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan_admin.model
{
    internal class pengembalian
    {
        Database db = new Database();

        public int id { get; set; }

        public string nama_user { get; set; }
        public string tgl_kembali { get; set; }

        public string id_buku { get; set; }
       

        public int addKembali(string nama_user, string tgl_kembali, string id_buku)
        {
            string queryString = @"INSERT INTO kembali VALUES (@id, @nama_user, @tgl_kembali, @id_buku);     
            UPDATE buku SET status = 'Tersedia' WHERE id_buku=@id_buku";
            MySqlParameter[] parameters = new MySqlParameter[4];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.Int32);
            parameters[1] = new MySqlParameter("@nama_user", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@tgl_kembali", MySqlDbType.VarChar);
            parameters[3] = new MySqlParameter("@id_buku", MySqlDbType.VarChar);

            parameters[1].Value = nama_user;
            parameters[2].Value = tgl_kembali;
            parameters[3].Value = id_buku;



            return db.setData(queryString, parameters);
        }

        public DataTable viewPengembalian()
        {
            DataTable dt = new DataTable();
            dt = db.getData("SELECT * FROM kembali", null);

            return dt;
        }


    }
}

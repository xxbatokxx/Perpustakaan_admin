using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan_admin.model
{
    internal class peminjaman
    {
        Database db = new Database();
        Buku buku = new Buku();
        
        

        public int id_pinjam { get; set; }

        public string nama_user { get; set; }

        public string nim { get; set; }

        public string kelas { get; set; }

        public string tgl_pinjam { get; set; }

        public string id_buku { get; set; }

        public string status { get; set; }

        public int addPeminjaman(string nama_user, string nim, string kelas, string tgl_pinjam, string id_buku)
        {  
            string queryString = @"INSERT INTO pinjam VALUES (@id, @nama_user, @nim, @kelas, @tgl_pinjam, @id_buku, 'Di pinjam');
            UPDATE buku set status = 'kosong' WHERE id_buku=@id_buku";
            MySqlParameter[] parameters = new MySqlParameter[6];

            parameters[0] = new MySqlParameter("@id", MySqlDbType.VarChar);
            parameters[1] = new MySqlParameter("@nama_user", MySqlDbType.VarChar);
            parameters[2] = new MySqlParameter("@nim", MySqlDbType.VarChar);
            parameters[3] = new MySqlParameter("@kelas", MySqlDbType.VarChar);
            parameters[4] = new MySqlParameter("@tgl_pinjam", MySqlDbType.VarChar);
            parameters[5] = new MySqlParameter("@id_buku", MySqlDbType.VarChar);

            parameters[1].Value = nama_user;
            parameters[2].Value = nim;
            parameters[3].Value = kelas;
            parameters[4].Value = tgl_pinjam;
            parameters[5].Value = id_buku;


            return db.setData(queryString, parameters);
        }

        public DataTable viewPinjam()
        {
            DataTable dt = new DataTable();
            dt = db.getData("SELECT * FROM pinjam", null);

            return dt;
        }
    }
}

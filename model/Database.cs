using MySql.Data.MySqlClient;
using System;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Perpustakaan_admin.model
{
    internal class Database
    {
        private MySqlConnection connection = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=;database=perpustakaan");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnction()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnction()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public int setData(string query, MySqlParameter[] parameters)
        {

            MySqlCommand command = new MySqlCommand(query, getConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnction();

            int commandState = command.ExecuteNonQuery();

            closeConnction();

            return commandState;
        }
    }
}
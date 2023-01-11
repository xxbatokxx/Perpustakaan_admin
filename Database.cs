using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Perpustakaan
{
    public class Database : DbContext
    {
        // Your context has been configured to use a 'Database' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Perpustakaan.Database' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Database' 
        // connection string in the application configuration file.
        public Database()
            : base("name=Database")
        {
        }

        private MySqlConnection connection = new MySqlConnection(
            "server=localhost;port=3306;username=root;password=;database=perpustakaan");

        public void openConnction()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnction()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public DataTable GetData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, GetConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dt);
            return dt;
        }


        internal static void execute(string v)
        {
            throw new NotImplementedException();
        }

        







        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
using System.Data.SQLite;

namespace KSolRDPManager.Data
{
    public static class DatabaseHelper
    {
        private static string _connectionString = "Data Source=ksol.db;Version=3;";

        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.entity
{
    internal class DBConnection
    {
        public static DBConnection instance;
        private SqlConnection connection;
        private DBConnection()
        {
            connection = new SqlConnection("Server=localhost\\SQLEXPRESS;"
            + "Database=database;"
            + "Integrated Security=true;"
            + "TrustServerCertificate=true;");
        }
        public static DBConnection GetInstance()
        {
            if (instance == null)
            {
                instance = new DBConnection();
            }
            return instance;
        }
        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}

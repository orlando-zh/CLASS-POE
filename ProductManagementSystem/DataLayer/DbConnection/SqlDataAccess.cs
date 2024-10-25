using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DbConnection
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {
            _connectionString = "Data Source=ENVY\\SQLEXPRESS;Initial Catalog=ProductsDB;Integrated Security=True;Encrypt=False";
        }

        public IDbConnection GetConnection() => new SqlConnection(_connectionString);

        //public IDbConnection GetConnection()
        //{
        //    return new SqlConnection(_connectionString);
        //}
    }
}

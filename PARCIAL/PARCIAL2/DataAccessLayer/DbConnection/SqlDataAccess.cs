﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnection
{
    public class SqlDataAccess
    {
        private readonly string _connectionString;

        public SqlDataAccess()
        {

            _connectionString = "Data Source=LAPTOP-KFDQNCRJ\\SQLEXPRESS;Initial Catalog=CarSalesBusiness;Integrated Security=True;Trust Server Certificate=True";

        }

        public SqlConnection GetConnection()
        {

            return new SqlConnection(_connectionString);
        }
    }
}

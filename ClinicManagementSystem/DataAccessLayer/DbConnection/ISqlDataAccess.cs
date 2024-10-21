using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DbConnection
{
    internal interface ISqlDataAccess
    {
        SqlConnection GetSqlConnection();
    }
}

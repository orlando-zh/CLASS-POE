using System.Data;

namespace DataLayer.DbConnection
{
    public interface ISqlDataAccess
    {
        IDbConnection GetConnection();
    }
}
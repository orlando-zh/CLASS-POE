using DataAccessLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Doctors
{
    public class DoctorRepository
    {
        private SqlDataAccess _dbConnection;

        public DoctorRepository()
        {
            _dbConnection = new SqlDataAccess();
        }
    }
}

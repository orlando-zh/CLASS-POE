using DataAccessLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Patients
{
    public class PatientRepository
    {
        private SqlDataAccess _dbConnection;

        public PatientRepository()
        {
            _dbConnection = new SqlDataAccess();
        }
    }
}

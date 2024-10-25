using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Doctors
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ISqlDataAccess _dbConnection;

        public DoctorRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void AddDoctor(Doctor doctor)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "INSERT INTO Doctor VALUES(@FirstName, @LastName)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                command.Parameters.AddWithValue("@LastName", doctor.LastName);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public void DeleteDoctor(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Doctor WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public DataTable GetAllDoctor()
        {
            DataTable doctorsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Id, FirstName, LastName FROM Doctor";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                doctorsTable.Load(reader);
            }

            return doctorsTable;
        }

        public void UpdateDoctor(Doctor doctor)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "UPDATE Doctor SET FirstName = @FirstName," +
                    " LastName = @LastName WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", doctor.FirstName);
                command.Parameters.AddWithValue("@LastName", doctor.LastName);
                command.Parameters.AddWithValue("@Id", doctor.Id);
                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}

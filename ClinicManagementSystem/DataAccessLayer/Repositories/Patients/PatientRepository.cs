using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Patients
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ISqlDataAccess _dbConnection;

        public PatientRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void AddPatient(Patient patient)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Patients(FirstName, LastName, Age, DoctorId)
                                VALUES(@FirstName, @LastName, @Age, @DoctorId)";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", patient.LastName);
                    sqlCommand.Parameters.AddWithValue("@Age", patient.Age);
                    sqlCommand.Parameters.AddWithValue("@DoctorId", patient.DoctorId);

                    sqlCommand.ExecuteNonQuery();

                }
            }
        }

        public void DeletePatient(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Patients WHERE PatientId = @PatientId";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@PatientId", id);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public void EditPatient(Patient patient)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Patients
                                 SET FirstName = @FirstName,
                                 LastName = @LastName,
                                 Age = @Age,
                                 DoctorId = @DoctorId
                                WHERE PatientId = @PatientId";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    sqlCommand.Parameters.AddWithValue("@FirstName", patient.FirstName);
                    sqlCommand.Parameters.AddWithValue("@LastName", patient.LastName);
                    sqlCommand.Parameters.AddWithValue("@Age", patient.Age);
                    sqlCommand.Parameters.AddWithValue("@DoctorId", patient.DoctorId);
                    sqlCommand.Parameters.AddWithValue("@PatientId", patient.PatientId);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllPatients()
        {
            DataTable patientsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT 
                                    p.PatientId, 
                                    p.FirstName, 
                                    p.LastName, 
                                    p.Age,
                                    CONCAT(d.FirstName, ' ', d.LastName) AS Doctor 
                                FROM Patients AS p 
                                INNER JOIN Doctor AS d ON p.DoctorId = d.Id";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        patientsTable.Load(reader);
                    }
                }
            }

            return patientsTable;
        }

        public DataTable GetDoctors()
        {
            DataTable doctorsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT Id, CONCAT(FirstName, ' ', LastName) AS Doctor FROM Doctor";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        doctorsTable.Load(reader);
                    }
                }
            }

            return doctorsTable;
        }
    }
}

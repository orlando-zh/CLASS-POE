using CommonLayer.Entities;
using DataAccessLayer.DbConnection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CarRepository
    {
        private SqlDataAccess _dbConnection;

        public CarRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        // Método para obtener todos los carros
        public DataTable GetCars()
        {
            DataTable carsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT CarID, Model, Price FROM Car";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        carsTable.Load(reader);
                    }
                }
            }

            return carsTable;
        }

        // Método para agregar un nuevo carro
        public void AddCar(Car car)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Car (Model, Price) 
                             VALUES (@Model, @Price)";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@Model", car.Model);
                    sqlCommand.Parameters.AddWithValue("@Price", car.Price);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un carro por ID
        public void DeleteCar(int carId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Car WHERE CarID = @CarID";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@CarID", carId);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar un carro existente
        public void UpdateCar(Car car)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Car
                             SET Model = @Model,
                                 Price = @Price
                             WHERE CarID = @CarID";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@CarID", car.CarID);
                    sqlCommand.Parameters.AddWithValue("@Model", car.Model);
                    sqlCommand.Parameters.AddWithValue("@Price", car.Price);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}


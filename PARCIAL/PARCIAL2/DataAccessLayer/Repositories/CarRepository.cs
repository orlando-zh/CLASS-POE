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
                try
                {
                    // Verificar si el CarID ya existe
                    if (!CarExists(car.CarID))
                    {
                        // CarID no existe, proceder con la inserción
                        string insertQuery = @"INSERT INTO Car (Model, Price)
                                               VALUES (@Model, @Price)";
                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            connection.Open();
                            insertCommand.Parameters.AddWithValue("@Model", car.Model);
                            insertCommand.Parameters.AddWithValue("@Price", car.Price);
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("El CarID ya existe. No se puede agregar el carro.");
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al agregar el carro: " + ex.Message);
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

        public bool CarExists(int carId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Car WHERE CarID = @CarID";
                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@CarID", carId);
                    connection.Open();
                    int count = (int)sqlCommand.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
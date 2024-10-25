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
    public class SaleRepository
    {
        private SqlDataAccess _dbConnection;

        public SaleRepository()
        {
            _dbConnection = new SqlDataAccess();
        }

        public DataTable GetSales()
        {
            DataTable salesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT SaleID, SaleDate, Quantity, TotalAmount, CarID FROM Sale";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        salesTable.Load(reader);
                    }
                }
            }

            return salesTable;
        }

        public int AddCar(Car car)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Car (Model, Price) OUTPUT INSERTED.CarID VALUES (@Model, @Price)", connection))
                {
                    command.Parameters.AddWithValue("@Model", car.Model);
                    command.Parameters.AddWithValue("@Price", car.Price);

                    return (int)command.ExecuteScalar(); // Obtiene el CarID insertado
                }
            }

        }




        // Método para agregar una nueva venta
        public void AddSale(Sale sale)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                try
                {
                    // Verificar si el CarID existe antes de insertar la venta
                    CarRepository carRepository = new CarRepository();
                    if (carRepository.CarExists(sale.CarID))
                    {
                        string query = @"INSERT INTO Sale (SaleDate, Quantity, TotalAmount, CarID) 
                                 VALUES (@SaleDate, @Quantity, @TotalAmount, @CarID)";

                        using (var sqlCommand = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            sqlCommand.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                            sqlCommand.Parameters.AddWithValue("@Quantity", sale.Quantity);
                            sqlCommand.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
                            sqlCommand.Parameters.AddWithValue("@CarID", sale.CarID);

                            sqlCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("El CarID especificado no existe. No se puede registrar la venta.");
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de excepciones
                    Console.WriteLine("Error al agregar la venta: " + ex.Message);
                }
            }
        }


        // Método para eliminar una venta por ID
        public void DeleteSale(int saleId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Sale WHERE SaleID = @SaleID";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@SaleID", saleId);
                    sqlCommand.ExecuteNonQuery();
                }
            }
        }

        // Método para actualizar una venta existente
        public void UpdateSale(Sale sale)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Sale
                             SET SaleDate = @SaleDate,
                                 Quantity = @Quantity,
                                 TotalAmount = @TotalAmount,
                                 CarID = @CarID
                             WHERE SaleID = @SaleID";

                using (var sqlCommand = new SqlCommand(query, connection))
                {
                    connection.Open();
                    sqlCommand.Parameters.AddWithValue("@SaleID", sale.SaleID);
                    sqlCommand.Parameters.AddWithValue("@SaleDate", sale.SaleDate);
                    sqlCommand.Parameters.AddWithValue("@Quantity", sale.Quantity);
                    sqlCommand.Parameters.AddWithValue("@TotalAmount", sale.TotalAmount);
                    sqlCommand.Parameters.AddWithValue("@CarID", sale.CarID);

                    sqlCommand.ExecuteNonQuery();
                }
            }
        }
    }
}


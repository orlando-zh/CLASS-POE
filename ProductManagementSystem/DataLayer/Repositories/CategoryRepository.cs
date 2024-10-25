using CommonLayer.Entities;
using Dapper;
using DataLayer.DbConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ISqlDataAccess _dbConnection;

        public CategoryRepository(ISqlDataAccess dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<Category> GetCategories()
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT Id, CategoryName FROM Categories";

                return connection.Query<Category>(query);
            }
        }

        public void AddCategory(Category category)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Categories(CategoryName) 
                                 VALUES(@CategoryName)";

                connection.Query<Category>(query, new { category.CategoryName });
            }
        }

        public void EditCategory(Category category)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Categories SET CategoryName = @CategoryName
                                 WHERE Id = @Id";

                connection.Query<Category>(query, category);
            }
        }

        public void DeleteCategory(int id)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Categories WHERE Id = @Id";

                connection.Query<Category>(query, new { id });
            }
        }
    }
}

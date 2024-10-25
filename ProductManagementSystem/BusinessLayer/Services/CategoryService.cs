using CommonLayer.Entities;
using DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAllCategories() => _categoryRepository.GetCategories();

        public void AddCategory(Category category) => _categoryRepository.AddCategory(category);

        public void EditCategory(Category category) => _categoryRepository.EditCategory(category);

        public void DeleteCategory(int id) => _categoryRepository.DeleteCategory(id);

    }
}

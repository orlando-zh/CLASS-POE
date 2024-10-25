using CommonLayer.Entities;

namespace BusinessLayer.Services
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        void EditCategory(Category category);
        IEnumerable<Category> GetAllCategories();
    }
}
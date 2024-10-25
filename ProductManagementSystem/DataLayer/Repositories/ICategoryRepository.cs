using CommonLayer.Entities;

namespace DataLayer.Repositories
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void DeleteCategory(int id);
        void EditCategory(Category category);
        IEnumerable<Category> GetCategories();
    }
}
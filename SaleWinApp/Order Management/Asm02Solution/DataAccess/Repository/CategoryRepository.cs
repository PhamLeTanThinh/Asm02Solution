using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System.Collections.Generic;

 
namespace DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private CategoryDAO _categoryDAO = CategoryDAO.Instance;
        public void AddCategory(Category _category) => _categoryDAO.AddCategory(_category);

        public IEnumerable<Category> FilterCategoryList(string name) => _categoryDAO.FilterCategoryList(name);

        public Category GetCategoryById(int id) => _categoryDAO.GetCategoryById(id);

        public IEnumerable<Category> GetCategoryList() => _categoryDAO.GetCategoryList();

        public void RemoveCategory(Category _category) => _categoryDAO.RemoveCategory(_category);

        public void UpdateCategory(Category _category) => _categoryDAO.UpdateCategory(_category);
    }
}

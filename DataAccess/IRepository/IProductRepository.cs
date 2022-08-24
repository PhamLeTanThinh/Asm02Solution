using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Category> GetCategories();
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        Product GetProductById(int id);
        IEnumerable<Product> GetProductByName(String productName);
        IEnumerable<Product> GetProductByUnitPrice(int unitPrice);
        IEnumerable<Product> GetProductByUnitsInStock(int unitsInStock);
    }
}

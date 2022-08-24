using BussinessObject.Models;
using DataAccess.DAO;
using DataAccess.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ProductDAO _productDAO = ProductDAO.Instance;
        public void AddProduct(Product _Product) => _productDAO.AddProduct(_Product);

        public IEnumerable<Product> FilterProductListByName(string name) => _productDAO.FilterProductListByName(name);

        public IEnumerable<Product> FilterProductListById(string id) => _productDAO.FilterProductListById(id);

        public Product GetProductById(int id) => _productDAO.GetProductById(id);

        public IEnumerable<Product> GetProductList() => _productDAO.GetProductList();

        public void RemoveProduct(Product _Product) => _productDAO.RemoveProduct(_Product);

        public void UpdateProduct(Product _Product) => _productDAO.UpdateProduct(_Product);

        public IEnumerable<Product> FilterProductListByPrice(string price) => _productDAO.FilterProductListByPrice(price);

        public IEnumerable<Product> FilterProductListByNoInstock(string stock) => _productDAO.FilterProductListByNoInstock(stock);
    }
}

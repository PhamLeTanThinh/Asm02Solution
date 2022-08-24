using BussinessObject.Context;
using BussinessObject.Models;
using System;
using System.Collections.Generic;

namespace DataAccess.Repository
{
    public class ProductRepository: IProductRepository
    {
        public void AddProduct(Product Product)
        {
            try
            {
                var product_Sub = GetProductById(Product.ProductId);
                if (product_Sub != null)
                {
                    throw new Exception("This Product Id is existed!");
                }
                using (var context = new SaleManagementContext())
                {
                    context.Products.Add(Product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } 
        public void DeleteProduct(Product Product)
        {
            try
            {
                using (var context = new SaleManagementContext())
                {
                    var _member = context.Products.SingleOrDefault(value => value.ProductId == Product.ProductId);
                    context.Products.Remove(Product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Product GetProductById(int ProductId) 
        {
            IEnumerable<Product> ProductList = GetProducts();
            Product product = ProductList.SingleOrDefault(product_sub => product_sub.ProductId == ProductId);
            return product;
        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products;

            try
            {
                using (var context = new SaleManagementContext())
                {
                    products = context.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return products;
        }
        public IEnumerable<Category> GetCategories()
        {
            IEnumerable<Category> categories;

            try
            {
                using (var context = new SaleManagementContext())
                {
                    categories = context.Categories.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return categories;
        }
        public IEnumerable<Product> GetProductByName(String productName)
        {
            IEnumerable<Product> ProductList = GetProducts();
            IEnumerable<Product> ProductList_Sub = ProductList.Where(product => product.ProductName.ToLower().Contains(productName.ToLower())).ToList();
            return ProductList_Sub;
        }
        public IEnumerable<Product> GetProductByUnitPrice(int unitPrice)
        {
            IEnumerable<Product> ProductList = GetProducts();
            IEnumerable<Product> ProductList_Sub = ProductList.Where(product => product.UnitPrice == unitPrice).ToList();
            return ProductList_Sub;
        }
        
        public IEnumerable<Product> GetProductByUnitsInStock(int unitsInStock)
        {
            IEnumerable<Product> ProductList = GetProducts();
            IEnumerable<Product> ProductList_Sub = ProductList.Where(product => product.UnitsInStock == unitsInStock).ToList();
            return ProductList_Sub;
        }
        public void UpdateProduct(Product Product)
        {
            try
            {
                using (var context = new SaleManagementContext())
                {
                    context.Entry<Product>(Product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

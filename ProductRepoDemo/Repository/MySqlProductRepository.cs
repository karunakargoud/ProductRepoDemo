using ProductRepoDemo.IRespository;
using ProductRepoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductRepoDemo.Repository
{
    public class MySqlProductRepository : IProductRepository
    {
        public void AddProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(string id)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(Product p)
        {
            throw new NotImplementedException();
        }

        public Product FindProduct(string id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
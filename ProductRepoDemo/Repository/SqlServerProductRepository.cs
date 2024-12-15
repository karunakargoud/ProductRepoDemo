using ProductRepoDemo.DAL;
using ProductRepoDemo.IRespository;
using ProductRepoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductRepoDemo.Repository
{
    public class SqlServerProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public SqlServerProductRepository()
        {
            _context = new ProductContext();
        }
        public void AddProduct(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
        }

        public void DeleteProduct(string id)
        {
            Product p = _context.Products.Find(id);
            _context.Products.Remove(p);
            _context.SaveChanges();
        }

        public void EditProduct(Product p)
        {
            Product x = _context.Products.Find(p.ProductId);
            x.ProductName = p.ProductName;
            x.Quantity = p.Quantity;
            x.Price = p.Price;
            _context.SaveChanges();
        }

        public Product FindProduct(string id)
        {
            Product p = _context.Products.Find(id);
            return p;
        }

        public List<Product> GetAllProducts()
        {
            //List<Product> plist = _context.Products.ToList();
            //return plist;
            return _context.Products.ToList();
        }
    }
}
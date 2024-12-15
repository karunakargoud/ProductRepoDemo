using ProductRepoDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRepoDemo.IRespository
{
   public interface IProductRepository
    {
        void AddProduct(Product p);
        void EditProduct(Product p);
        void DeleteProduct(string id);
        Product FindProduct(string id);

        List<Product> GetAllProducts();


    }
}

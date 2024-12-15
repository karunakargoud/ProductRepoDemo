using Microsoft.Ajax.Utilities;
using ProductRepoDemo.DAL;
using ProductRepoDemo.IRespository;
using ProductRepoDemo.Models;
using ProductRepoDemo.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductRepoDemo.Controllers
{
    public class ProductController : Controller
    {
      private readonly IProductRepository repo ;

        public ProductController(IProductRepository mil)
        {
            repo= mil;
        }
        public ActionResult Index()
        {
            List<Product> plist=repo.GetAllProducts();
            return View(plist); 
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product p)
        {
            if (ModelState.IsValid)
            {
                repo.AddProduct(p);
                List<Product> plist = repo.GetAllProducts();
                return View("Index",plist);
            }
            else
            {
                return View(p);
            }
        }
        [HttpGet]
        public ActionResult Edit(string id)
        
        {
                Product p = repo.FindProduct(id);
               return View(p);
        }
        [HttpPost]
        public ActionResult Edit(Product p)
        {
            repo.EditProduct(p);
            List<Product> plist = repo.GetAllProducts();
            return View("Index",plist);
        }
        public ActionResult Details(string id)
        {
            Product p = repo.FindProduct(id);
            return View(p);
        }
        public ActionResult Delete(string id)
        {
            Product p = repo.FindProduct(id);
            repo.DeleteProduct(id);
            List<Product> plist = repo.GetAllProducts();
            return View("Index", plist);
        }
    }

}
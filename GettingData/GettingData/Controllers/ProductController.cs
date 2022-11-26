using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Products> products = new List<Products>()
        {
            new Products{ID=1 , category = "Elektronik",  productName = "Televizyon"},
            new Products{ID=2 , category = "Ev Eşyaları", productName = "Sandalye"},
            new Products{ID=3 , category = "Elektronik",  productName = "Bilgisayar"},
            new Products{ID=4 , category = "Mutfak",      productName = "Mutfak Robotu"},

        };

        public IActionResult GetAllProducts()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            Products product = products.Find(x => x.ID == id);
            if (product == null)
            {
                ViewBag.Error = "Aradığınız aralıkta bir ürün bulunmamaktadır!";
            }
            return View(product);
        }

        public IActionResult GetAllCategory()
        {
            return View(products);
        }

        public IActionResult GetCategoryByRoute(string cat)
        {
            List<Products> product = products.FindAll(x => x.category == cat);

            if (product.Count == 0)
            {
                ViewBag.Error = "Aradığınız kategoride bir ürün bulunmamaktadır.";
            }
            return View(product);
        }


    }
}

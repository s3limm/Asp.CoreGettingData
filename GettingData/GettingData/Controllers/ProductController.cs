using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Products> products = new List<Products>()
        {
            new Products{ID=1 , productName="Televizyon"},
            new Products{ID=2 , productName="Kulaklık"},
            new Products{ID=3 , productName="Bilgisayar"},
            new Products{ID=4 , productName="Telefon"},
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
    }
}

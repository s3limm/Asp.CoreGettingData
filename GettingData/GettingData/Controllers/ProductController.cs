using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {
        List<Products> products = new List<Products>()
        {
<<<<<<< HEAD
            new Products{ID=1 , category ="Elektronik" , productName="Televizyon"},
            new Products{ID=2 , category ="Ev Eşyaları" , productName="Kitap"},
            new Products{ID=3 , category ="Elektronik" , productName="Bilgisayar"},
            new Products{ID=4 , category ="Mutfak" , productName="Mutfak Robotu"},
=======
            new Products{ID=1 , category = "Elektronik",  productName = "Televizyon"},
            new Products{ID=2 , category = "Ev Eşyaları", productName = "Sandalye"},
            new Products{ID=3 , category = "Elektronik",  productName = "Bilgisayar"},
            new Products{ID=4 , category = "Mutfak",      productName = "Mutfak Robotu"},
>>>>>>> 786a8be2b3d39bd197c0e030f744d15c9deb4593
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

<<<<<<< HEAD
        public IActionResult GetPrductsCategory()
        {
            return View();
        }
=======
           public IActionResult GetAllCategory()
        {
            return View(products);
        }

             public IActionResult GetCategoryById(string cat)
        {
            Products product = products.Find(x => x.category == cat)
                
            if (product == null)
            {
                ViewBag.Error = "Aradığınız kategoride bir ürün bulunmamaktadır."
            }
            return View(product);
        }
            
        


>>>>>>> 786a8be2b3d39bd197c0e030f744d15c9deb4593
    }
}

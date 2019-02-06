using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheEverythingStore.Models;

namespace TheEverythingStore.Controllers
{
    public class HomeController : Controller
    {

        //connect to db

        private DbModel db=new DbModel();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Products()
        {
            /*var products = new List<string>;
            //create mock products
            for(int i = 1; i < 10; i++)
            {
                products.Add("products" + i.ToString());
            }

            //pass mock products to the view for dusplay
            ViewBag.Products = products;*/

            //creating 10 product objects(instances)


            //use the product model to retriev the entire list of products from SQL Server
            var products = db.Products.ToList();

            //load the view and pass the product list to it
            return View(products);
        }

        public ActionResult ViewProduct(string ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}
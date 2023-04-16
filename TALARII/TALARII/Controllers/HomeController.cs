using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using TALARII.Models;

namespace TALARII.Controllers
{
    public class HomeController : Controller
    {

        Context db;
        public HomeController(Context context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CardList()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }
<<<<<<< HEAD
=======

>>>>>>> 6e21befc66071194c6b87944e578ca6c95a0f72e

        public IActionResult Services()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetCard()
        {

            var cards = from c in db.Models
                        select new
                        {
                            c.Id,
                            c.Name,
                            c.Brand,
                            c.Link,
                            c.Price
                        };

            return Json(cards);

        }
        [HttpPost]
        public JsonResult Basket(int modelid, int cookie)
        {


            if (db.Baskets.FirstOrDefault(q => q.Cookie == cookie) == null)
            {
                var newbasket = new Basket { Cookie = cookie };

                db.Add(newbasket);

                db.SaveChanges();
            }


            var basket = db.Baskets.FirstOrDefault(q => q.Cookie == cookie);

            basket.IdListModels

            //Model model = db.Models.FirstOrDefault(q => q.Id == modelid);

            //basket.ModelList.Add(model);

            //db.Update(basket);

            //db.SaveChanges();


            return Json(0);


        }

        
    }
}
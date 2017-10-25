using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstMVC5Entity.Models;//подключаем пространство имен моделей

namespace FirstMVC5Entity.Controllers
{
    public class HomeController : Controller
    {
        // создаем объект контекста данных
        BookContext db = new BookContext();

        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Book> books = db.Books;
            // передаем все объекты в динамическое свойство Books в ViewBag
            ViewBag.Books = books;  //ViewBag представляет такой объект, который позволяет определить любую переменную и передать ей некоторое значение, а затем в представлении извлечь это значение
            // возвращаем представление
            return View();
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]//принимает переданную ему в запросе POST модель purchase и добавляет ее в базу данных
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
    }
}
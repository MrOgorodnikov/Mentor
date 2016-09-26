using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Mentor> mentors = db.Mentors;
            ViewBag.Mentors = mentors;
            return View();
        }
        //[HttpGet]
        //public ActionResult Buy(int id)
        //{
        //    ViewBag.BookId = id;
        //    return View();
        //}
        //[HttpPost]
        //public string Buy(Purchase purhase)
        //{
        //    purhase.Date = DateTime.Now;
            
        //    db.Purchases.Add(purhase);
        //    db.SaveChanges();

        //    return "Спасибо," + purhase.Person + ", за покупку!";
        //}

        //[HttpGet]
        //public ActionResult Add()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public void Add(Book book)
        //{
        //    db.Books.Add(new Book { Name = book.Name, Author = book.Author, Price = book.Price });
        //    db.SaveChanges();
        //    Response.Redirect("/Home");
        //    //return Redirect("/Home");
        //}

        
        //public void Delete(int id)
        //{
        //    Book book = db.Books.Find(id);
        //    db.Books.Remove(book);
        //    db.SaveChanges();
        //    Response.Redirect("/Home");
        //}

        

        
    }
}
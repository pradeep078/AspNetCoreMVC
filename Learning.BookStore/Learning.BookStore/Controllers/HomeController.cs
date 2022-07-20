using Learning.BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learning.BookStore.Controllers
{
    public class HomeController:Controller
    {
        [ViewData]
        public string Title { get; set; }
        public ViewResult Index()
        {
            Title = "Home page from Controller";
            return View();
        }
        public ViewResult AboutUs()
        {
            Title = "AboutUs";
            return View();
        }
        public ViewResult ContactUs()
        {
            Title = "ContactUs";
            return View();
        }
    }
}

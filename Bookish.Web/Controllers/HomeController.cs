﻿using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess.DataModels;
using Bookish.DataAccess.Services;
using Bookish.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using PagedList;

namespace Bookish.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var userManager = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            if (User.Identity.IsAuthenticated)
            {
                var userId = userManager.FindById(User.Identity.GetUserId()).Email;
                var usersFirstName = UserService.RetriveFirstName(userId);
                var userBooks = BookService.BooksForUser(userId);
                return View(new HomeViewModel{
                    Books = userBooks,
                    FirstName = usersFirstName
                });
            }

            return View(new HomeViewModel
            {
                Books = new List<BookBorrows>()
            });
        }

        public ActionResult Library(int page = 1, int pagesize = 2)
        {
            var title = BookService.listTitles();
            PagedList<BookTitle> model = new PagedList<BookTitle>(title, page, pagesize);
            return View(model);
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

        public ActionResult BookDetails(int titleId)
        {
            var copies = BookService.CopiesOfBooks(titleId);
            return View(copies);
        }
    }
}

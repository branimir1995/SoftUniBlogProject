using Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog.Models;
using Microsoft.AspNet.Identity;
using Blog.Models.Posts;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            var db = new BlogDbContext();

            var posts = db.Posts
                .OrderByDescending(c => c.Id)
                .Take(3)
                .Select(c => new HomeIndexPostModel
                {
                    Id = c.Id,
                    Title = c.Title,
                    ImageUrl = c.ImageUrl,
                    Recipe = c.Recipe,
                    MakeMethod = c.MakeMethod


                })
                .ToList();

            return View(posts);
        }

        
    }
}
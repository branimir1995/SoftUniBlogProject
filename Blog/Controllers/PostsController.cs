using Blog.Data;
using Blog.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreatePostModels postModel)
        {
            if (postModel != null && this.ModelState.IsValid)
            {
                var publisherId = this.User.Identity.GetUserId();

                var post = new Post
                {
                    Title = postModel.Title,
                    ImageUrl = postModel.ImageUrl,
                    MakeMethod = postModel.MakeMethod,
                    PublisherId = publisherId,
                    Recipe = postModel.Recipe
                };

                var db = new BlogDbContext();
                db.Posts.Add(post);
                db.SaveChanges();

                return RedirectToAction("Details", new { id = post.Id });
            }

            return View(postModel);
        }
    }
}
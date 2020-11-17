using CleanBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanBlog.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<PostVM> posts = new List<PostVM>();

            PostVM post1 = new PostVM();
            post1.Title = "ıvır zıvır";
            post1.UserName="hande";
            post1.AddDate = "11 Kasım";

            PostVM post2 = new PostVM();
            post2.Title = "ıvır zıvır ıvır zıvır";
            post2.UserName = "bilge";
            post2.AddDate = "06 Kasım";

            posts.Add(post1);
            posts.Add(post2);


            return View(posts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Post()
        {
            return View();
        }
    }
}

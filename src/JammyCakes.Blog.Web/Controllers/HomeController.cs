using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JammyCakes.Blog.Core.Models;
using JammyCakes.Blog.Core.Queries;

namespace JammyCakes.Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private IBlogContext context;

        public HomeController(IBlogContext context)
        {
            this.context = context;
        }

        //
        // GET: /Home/
        public ActionResult Index(PostsQuery query)
        {
            var posts = query.GetPosts(context.Posts);
            return View(posts);
        }
	}
}
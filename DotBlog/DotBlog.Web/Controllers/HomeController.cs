using System;
using System.Web.Mvc;
using DotBlog.Core.Objects;
using DotBlog.Core.Repository;

namespace DotBlog.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            var repo = new Repository<ListType, Guid>(new DotBlogContext());

            return "Hello " + repo.Count();
        }

        

    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Blog Related Information Details" };
        }

        public IActionResult Posts(string id)
        {
            return new ContentResult { Content = string.Format("Blog Post Title : {0}", id) };
        }

        public IActionResult PostCount(int id)
        {
            return new ContentResult { Content = string.Format("Blog Post Count : {0}", id.ToString()) };
        }

        [Route("blog/post/{year:int}/{month:int}/{title}")]
        public IActionResult Post(int year, int month, string title)
        {
            return new ContentResult { Content = string.Format("Blog Post Details : Year {0} Month: {1} Title: {2}", year, month, title) };
        }
    }
}

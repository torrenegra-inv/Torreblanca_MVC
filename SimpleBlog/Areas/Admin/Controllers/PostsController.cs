using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("Admin Post!!!");
        }
    }
}
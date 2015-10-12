using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return Content("Admin Post!!!");
        }
    }
}
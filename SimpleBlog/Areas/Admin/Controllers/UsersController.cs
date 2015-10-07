using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return Content("USERS!!!");
        }
    }
}
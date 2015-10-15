using System.Web.Mvc;
using SimpleBlog.Infrastructure;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("Users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
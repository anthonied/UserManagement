using System.Web.Mvc;

namespace UserManagement.Mvc5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}
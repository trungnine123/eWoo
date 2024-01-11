using Microsoft.AspNetCore.Mvc;

namespace eWoo.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}

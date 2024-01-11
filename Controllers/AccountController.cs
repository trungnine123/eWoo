using Microsoft.AspNetCore.Mvc;

namespace eWoo.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "manager")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }
        }
        
        public ActionResult InvalidLogin() 
        {
            //Test
            return View();
        }
    }
}

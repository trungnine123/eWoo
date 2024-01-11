using eWoo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eWoo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View("Products");
        }

        public IActionResult Contact()
        {
            return View();
        }

        public ActionResult GetEmpName(int EmpId)
        {
            var employess = new[]
            {
                new {EmpId = 1, EmpName = "Sang", Salary = 1234},
                new {EmpId = 2, EmpName = "Hiep", Salary = 4321},
                new {EmpId = 3, EmpName = "Duc", Salary = 1234}
            };

            string matchEmpName = null;
            foreach (var item in employess)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }
            //return new ContentResult() { Content = matchEmpName, ContentType = "text/plain" };
            return Content(matchEmpName, "text/plain");
        }
        
        public ActionResult GetSalary(int EmpId)
        {
            string fileName = "~/salary-table-" + EmpId + ".pdf";
            return File(fileName, fileName, "application/pdf");
        }

        public ActionResult EmpFbPage(int EmpId)
        {
            var employess = new[]
            {
                new {EmpId = 1, EmpName = "Sang", Salary = 1234},
                new {EmpId = 2, EmpName = "Hiep", Salary = 4321},
                new {EmpId = 3, EmpName = "Duc", Salary = 1234}
            };
            string fbUrl = null;
            foreach (var item in employess)
            {
                if(item.EmpId == EmpId) 
                {
                    fbUrl = "https://https://www.facebook.com/emp" + EmpId;
                }
            }
            if (fbUrl == null)
            {
                return Content("Invalid emp ID");
            }
            else
            {
                return Redirect(fbUrl);
            }
        }

        public ActionResult EmpDetail()
        {
            ViewBag.EmpId = 01;
            ViewBag.Name = "Sang";
            ViewBag.Salary = 1234;
            ViewBag.Gender = "M";

            return View();
        }
    } 
}



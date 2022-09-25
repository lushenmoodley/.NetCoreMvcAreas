using Microsoft.AspNetCore.Mvc;
using UrlRouting.Areas.Employees.Models;
using UrlRouting.Areas.Sales.Models;

namespace UrlRouting.Areas.Employees.Controllers
{
    public class HomeController : Controller
    {
        [Area("Employees")]
        public IActionResult Index()
        {
     
            Workers[] employees = new Workers[]
            {
                new Workers{FullName="Lushen Moodley", Occupation="Software Developer", Salary=10.00},
                new Workers {FullName="Zack Moodley", Occupation="Security Guard",Salary=20.00 },
                new Workers{FullName="Kevin Jennings",Occupation="Scrum Master",Salary=30.00}
            };

            return View(employees);
        }


        
        
        }



    }


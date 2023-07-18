using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WindowsAuthenticationDemo.Models;

namespace WindowsAuthenticationDemo.Controllers
{
    [Authorize(Users = @"SF-LAP-874\rikesh, SF-LAP-874\install")]
    //[Authorize]
    public class HomeController : Controller
    {
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult About()
            {
                ViewBag.Message = "Your application description page.";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "Your contact page.";

                return View();
            }

            [Authorize(Users = @"SF-LAP-874\install")]
            public ActionResult admin()
            {
                return View();
            }

            [Authorize(Users = @"SF-LAP-874\rikesh, SF-LAP-874\install")]
            public ActionResult user()
            {
                return View();
            }

            public ActionResult GetAllStudents()
            {
                List<Student> s1= new List<Student>()
                {
                        new Student {id=1, name="ABC", course="MBA", department="FOM" },

                        new Student {id=2, name="DEF",course="BCA",department="FOM"},

                        new Student {id=3,name="XYZ",course="B.Tech",department="ENGG"},
                };

                return View(s1);
            }
        }
    }
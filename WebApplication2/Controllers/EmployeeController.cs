using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.BAL;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult index1()
        {
            EmployeeBAL b = new EmployeeBAL();
            List<EmployeeVM> elist = b.GetEmpList();
            return View(elist);

        }

    }
}
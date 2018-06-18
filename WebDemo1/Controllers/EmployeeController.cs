using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDemo1.Models;

namespace WebDemo1.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            var E = new Employee() { Eid = 1, EmpName = "Maz Trainer" };
            return View(E);
        }
    }
}
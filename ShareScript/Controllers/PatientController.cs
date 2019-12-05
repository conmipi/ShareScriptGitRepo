using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ShareScript.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShareScript.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShareScript.Controllers
{
    public class PatientSelectController : Controller
    {
        Patient patient = new Patient();
        // GET: /<controller>/
        public ActionResult Index()
        {

            return View(patient);
        }


        public ActionResult PatientPass(Patient patient)
        {
            TempData["Patient"] = patient;
            return RedirectToAction("Index", "PrescriptionCreationController");
        }



    }
}

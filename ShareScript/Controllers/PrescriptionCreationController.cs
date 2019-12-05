using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShareScript.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShareScript.Controllers
{
    public class PrescriptionCreationController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            Patient patient = (Patient) TempData["Patient"];
            return View(patient);
        }

        [HttpPost]
        public ActionResult Index(string drugName, float dosage, bool controlledSub)
        {
            System.Diagnostics.Debug.WriteLine("Hitting Index");
            Patient patient = (Patient)TempData["Patient"];
            //Prescription prescription = new Prescription(000000, drugName, dosage, "00000", "0000", "DoctorName", null, patient.FirstName, patient.DOB1, null, controlledSub);

            //patient.Prescriptions.Add(prescription);
            System.Diagnostics.Debug.WriteLine(patient);
            System.Diagnostics.Debug.WriteLine("Patient Info");
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShareScript.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShareScript.Controllers
{
    public class PrescriptionCreationController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(Patient patient)
        {
            TempData["patientData"] = JsonConvert.SerializeObject(patient);
            return View();
        }


        [HttpPost]
        public ActionResult Index(Prescription prescription)
        {
            Patient patient = JsonConvert.DeserializeObject<Patient>((string)TempData["patientData"]);
            Prescription pres = new Prescription(000000, prescription.DrugName, prescription.Dosage, "00000", "0000", "DoctorName", null, "Fn", "Dob", null, prescription.ControlledSub);
            //patient.CreatePrescription(pres);
            patient.CreatePrescription(pres);
            TempData["updatedPatient"] = JsonConvert.SerializeObject(patient);
            return RedirectToAction("Index","PatientSelect");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShareScript.Models;

namespace ShareScript.Controllers
{
    public class PatientController : Controller
    {
        static List<Patient> patientList;
        public ActionResult Index()
        {
            patientList = new List<Patient>();
            if (patientList.Count == 0)
            {
                patientList.Add(new Patient());
            }
            Patient currPatient = patientList[0];
            return View(currPatient);
        }

        public ActionResult PatientSelect()
        {
            return View(patientList[0]);
        }

        public ActionResult CreatePrescription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPrescription(Prescription prescription)
        {
            Prescription pres = new Prescription(000000, prescription.DrugName, prescription.Dosage, "00000", "0000", "DoctorName", null, "Fn", "Dob", null, prescription.ControlledSub);
            //patient.CreatePrescription(pres);
            patientList[0].CreatePrescription(pres);
            //TempData["updatedPatient"] = JsonConvert.SerializeObject(patient);
            return RedirectToAction("PatientSelect");
        }
    }
}

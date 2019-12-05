using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShareScript.Models;

namespace ShareScript.Controllers
{
    public class ViewPrescriptionController : Controller
    {
        public IActionResult Index()
        {
            List<Prescription> prescriptionList = new List<Prescription>();

            return View(prescriptionList);
        }
    }
}
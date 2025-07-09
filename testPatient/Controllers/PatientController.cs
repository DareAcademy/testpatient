using Microsoft.AspNetCore.Mvc;
using testPatient.Models;
using testPatient.services;

namespace testPatient.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientService patientService;

        public PatientController(IPatientService _patientService)
        {
            patientService = _patientService;
        }
        public IActionResult Edit(int Id)
        {
            PatientDTO patient= patientService.GetPatient(Id);
            return View("Index", patient);
        }

        public IActionResult Save(PatientDTO patient)
        {
            int Id = patientService.AddPatient(patient);
            PatientDTO patientdetails = patientService.GetPatient(Id);
            return View("Index", patientdetails);
        }
    }
}

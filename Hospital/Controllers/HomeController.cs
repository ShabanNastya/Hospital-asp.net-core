using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hospital.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hospital.Models;
using Hospital.ViewModels;


namespace Hospital.Controllers
{

    public class HomeController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _doctorRepository.GetAllDoctor();
            return View(model);
        }


        public ViewResult Details(int? id)
        {
            Doctor doctor = _doctorRepository.GetDoctorById(id.Value);

            if (doctor == null)
            {
                Response.StatusCode = 404;
                return View("DoctorNotFound", id.Value);
            }
            
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Doctor = _doctorRepository.GetDoctorById(id ?? 1),
                PageTitle = "Doctor Details"
            };

            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        
        
        [HttpPost]
        public RedirectToActionResult Create(Doctor doctor)
        {
            Doctor newDoctor =   _doctorRepository.Add(doctor);
            return RedirectToAction("Details", new {id = newDoctor.DoctorId});
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}
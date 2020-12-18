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

        [HttpGet]
        [HttpPost]
        public IActionResult Details(int id)
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Doctor = _doctorRepository.GetDoctorById(id),
                PageTitle = "Doctor Details"
            };
            return View(homeDetailsViewModel);
        }

        public ViewResult Create()
        {
            return View();
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
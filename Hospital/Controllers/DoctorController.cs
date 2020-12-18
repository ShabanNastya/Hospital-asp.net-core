using Hospital.Interfaces;
using Hospital.Models;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Hospital.Controllers
{
    public class DoctorController:Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IDoctorRepository _doctorRepository;
        
        public DoctorController(IDoctorRepository doctorRepository, ICategoryRepository categoryRepository)
        {
            _doctorRepository = doctorRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "BestDoctor";
            //return View(_doctorRepository.GetAllDoctor);
            
            var doctorListViewModel = new DoctorListViewModel();
            //doctorListViewModel.Doctors = _doctorRepository.GetAllDoctor;
            doctorListViewModel.CurrentCategory = "BestDoctor";
            return View(doctorListViewModel);
        }
    }
}
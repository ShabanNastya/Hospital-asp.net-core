using Hospital.Interfaces;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class MedicinesController : Controller
    {
        private readonly IMedicinesRepository _medicinesRepository;
        private readonly ICategoryMedRepository _categoryMedRepository;

        public MedicinesController(IMedicinesRepository medicinesRepository,
            ICategoryMedRepository categoryMedRepository)
        {
            _medicinesRepository = medicinesRepository;
            _categoryMedRepository = categoryMedRepository;
        }

        public ViewResult Schedule()
        {
            var medicinesListViewModel = new MedicinesViewModel();
            medicinesListViewModel.Medicineses = _medicinesRepository.GetAllMedicines;
            medicinesListViewModel.CurrentCategory = "BestSellers";
            return View(medicinesListViewModel);
        }

        public IActionResult Details(int id)
        {
            var medicines = _medicinesRepository.GetMedicinesById(id);
            if (medicines == null)
                return NotFound();
            
            return View(medicines);

        }
    }
}
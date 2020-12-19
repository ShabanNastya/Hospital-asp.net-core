using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Hospital.Interfaces;

namespace Hospital.Models
{
    public class MedicinesRepository : IMedicinesRepository
    {
        private readonly ICategoryMedRepository _categoryMedRepository = new CategoryMedRepository();

        public IEnumerable<Medicines> GetAllMedicines => new List<Medicines>
        {
            new Medicines
            {
                MedicinesId = 1, Name = "Амоксиклав", Price = 10.98M, Description = "Антибиотик широкого спектра действия. Активен в отношении г+и г- бактерий, в том числе продуцирующих b-лактомазу... Показан для лечения бактериальных инфекций у детей и взрослых",
                CategoryMed = _categoryMedRepository.GetAllCategoryMeds.ToList()[0], Country = "Словения",ImageUrl = "", IsOnStock = true,
                IsOnSale = false
            },
            new Medicines
            {
                MedicinesId = 2, Name = "Календулы настойка", Price = 1.00M, Description = "Антисептик для наружного применения. Показан для лечения заболеваний горла и полости рта, небольших поверхностных ран кожи",
                CategoryMed = _categoryMedRepository.GetAllCategoryMeds.ToList()[3], Country = "Борисовский завод медпрепаратов, Республика Беларусь",ImageUrl = "", IsOnStock = true,
                IsOnSale = false
            },
            new Medicines
            {
                MedicinesId = 3, Name = "Гидрокортизон", Price = 2.41M, Description = "Гормон из группы глюкокортикостероидов. Показан для лечения аллегрических поражений глаз",
                CategoryMed = _categoryMedRepository.GetAllCategoryMeds.ToList()[1], Country = "Ельфа, Польша",ImageUrl = "", IsOnStock = false,
                IsOnSale = false
            },
            new Medicines
            {
                MedicinesId = 4, Name = "Антиксикапс с цинком", Price = 3.80M, Description = "Витамины в комбинации с минеральным веществом. Показан при дефиците витаминов А,С,Е и цинка",
                CategoryMed = _categoryMedRepository.GetAllCategoryMeds.ToList()[2], Country = "Минскинтеркапс, Республика Беларусь",ImageUrl = "", IsOnStock = true,
                IsOnSale = true
            },
        };


        public IEnumerable<Medicines> GetMedicinesOnSale => throw new NotImplementedException();
        
        public Medicines GetMedicinesById(int medicinesId)
        {
            return GetAllMedicines.FirstOrDefault(c => c.MedicinesId == medicinesId);
        }
    }
}
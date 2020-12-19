using System.Collections.Generic;
using Hospital.Interfaces;

namespace Hospital.Models
{
    public class CategoryMedRepository : ICategoryMedRepository
    {
        public IEnumerable<CategoryMed> GetAllCategoryMeds => new List<CategoryMed>
        {
            new CategoryMed
            {
                CategoryMedId = 1, CategoryMedName = "Antibiotics"
            },
            new CategoryMed
            {
                CategoryMedId = 2, CategoryMedName = "Hormones"
            },
            new CategoryMed {CategoryMedId = 3, CategoryMedName = "Vitamins"},
            
            new CategoryMed{CategoryMedId = 3, CategoryMedName = "Antiseptic"}
        };
    }
}
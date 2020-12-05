using System;
using System.Collections;
using System.Collections.Generic;
using Hospital.Interfaces;

namespace Hospital.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category
            {
                CategoryId = 1, CategoryName = "Therapist"
            },
            new Category
            {
                CategoryId = 2, CategoryName = "Dentist"
            },
            new Category
            {
                CategoryId = 3, CategoryName = "Pediatrician"
            }
        };
    }

}
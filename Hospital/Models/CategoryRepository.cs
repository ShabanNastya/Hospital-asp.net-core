using System;
using System.Collections;
using System.Collections.Generic;
using Hospital.Interfaces;

namespace Hospital.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
        
    }

}
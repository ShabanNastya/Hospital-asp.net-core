using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
        
        
    }
}
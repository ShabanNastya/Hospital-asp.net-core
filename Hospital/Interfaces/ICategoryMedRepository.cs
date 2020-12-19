using System.Collections.Generic;
using Hospital.Models;

namespace Hospital.Interfaces
{
    public interface ICategoryMedRepository
    {
        IEnumerable<CategoryMed> GetAllCategoryMeds { get; }
    }
}
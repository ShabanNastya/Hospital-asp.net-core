using System.Collections.Generic;

namespace Hospital.Models
{
    public class CategoryMed
    {
        public int CategoryMedId { get; set; }
        
        public string CategoryMedName { get; set; }
        
        public string CategoryAnnotation { get; set; }

        public List<Medicines> Medicineses { get; set; }
    }
}
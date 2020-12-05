using System.Collections.Generic;

namespace Hospital.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        
        public string CategoryName { get; set; }
        
        //public string CategoryDescription { get; set; }

        public List<Doctor> Doctors { get; set; }
    }
}
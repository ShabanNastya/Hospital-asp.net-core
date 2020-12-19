namespace Hospital.Models
{
    public class Medicines
    {
        public int MedicinesId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        
        public decimal Price { get; set; }
        
        public string Country { get; set; }

        public string ImageUrl { get; set; }
        
        public string ImageThumbnailUrl { get; set; }
        
        public bool IsOnSale { get; set; }

        public bool IsOnStock { get; set;}

        public int CategoryId { get; set; }
        
        public CategoryMed CategoryMed { get; set; }
    }
}
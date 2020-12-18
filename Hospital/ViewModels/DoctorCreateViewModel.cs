using System.ComponentModel.DataAnnotations;
using Hospital.Models;
using Microsoft.AspNetCore.Http;

namespace Hospital.ViewModels
{
    public class DoctorCreateViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }
        [Required]
        public Categ? Department { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;

namespace Hospital.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace Hospital.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace TeleMedicine.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace SeedAPI.Models.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
    }
}
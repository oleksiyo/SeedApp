using Microsoft.AspNetCore.Identity;

namespace SeedAPI.Models.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
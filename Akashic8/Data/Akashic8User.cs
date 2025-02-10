using Microsoft.AspNetCore.Identity;

namespace Akashic8.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Akashic8User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace DataMonitoring.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Departement { get; set; }
        public byte[]? ProfilePicture { get; set; }


    }
}

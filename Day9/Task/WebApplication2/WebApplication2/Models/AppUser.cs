using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models
{
    public enum Education { First,Second,Third,Fourth }
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public Education EducationLevel { get; set; }
    }
}

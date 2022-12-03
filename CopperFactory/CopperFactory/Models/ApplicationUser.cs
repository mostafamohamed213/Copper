using Microsoft.AspNetCore.Identity;

namespace CopperFactory.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string SeconedName { get; set; }

 

    }
}

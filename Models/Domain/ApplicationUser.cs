using Microsoft.AspNetCore.Identity;

namespace Eseries.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}

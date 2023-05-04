using Microsoft.AspNetCore.Identity;

namespace WebApplicationCoreGLSI_C.Models
{
    public class ApplicationUser : IdentityUser
    {
        public  string City { get; set; }
    }
}

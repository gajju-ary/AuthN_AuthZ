using Microsoft.AspNetCore.Identity;

namespace AuthN_AuthZ.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsHR { get; set; }

        public string Department { get; set; }

        public bool IsActive { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;

namespace ApiCall.BusinessLogic
{
    public class ApplicationUser : IdentityUser
    {
        public string UniqueCode { get; set; }
    }
}

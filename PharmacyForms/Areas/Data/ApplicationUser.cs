using System;
using Microsoft.AspNetCore.Identity;

namespace PharmacyForms.Areas.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string ?PharmacyName { get; set; }
    }
}

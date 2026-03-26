using Microsoft.AspNetCore.Identity;
using System;

namespace WebApp1.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

        public DateTime DOB { get; set; }
    }
}
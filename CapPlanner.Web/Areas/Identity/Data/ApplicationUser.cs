using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapPlanner.Web.Areas.Identity.Data
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
    }
}

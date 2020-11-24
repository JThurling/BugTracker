using System.Collections.Generic;
using Core.Models.Bugs;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.Shared.Models
{
    public class ApplicationUser : IdentityUser
    {

        public List<BugEntity> Bug { get; set; }
    }
}

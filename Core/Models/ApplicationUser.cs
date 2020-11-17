using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models.Bugs;
using Microsoft.AspNetCore.Identity;

namespace Core.Models
{
    public class ApplicationUser : IdentityUser
    {

        public List<BugEntity> Bug { get; set; }

        public int BugEntityId { get; set; }
    }
}

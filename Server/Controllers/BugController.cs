using System.Threading.Tasks;
using Core.Models.Inputs.Bug;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Server.Controllers
{
    public class BugController : BaseApiController
    {
        [HttpPost]
        public async Task<ActionResult<BugInput>> CreateBug([FromBody]BugInput bug)
        {
            return Ok(bug);
        }
    }
}

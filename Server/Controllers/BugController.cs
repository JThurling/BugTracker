using System.Collections.Generic;
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

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BugInput>>> GetBugs()
        {
            return Ok();
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<BugInput>> GetSingleBug(int id)
        {
            return Ok();
        }

        [HttpDelete]
        public async Task<ActionResult<BugInput>> DeleteBug()
        {
            return Ok();
        }
    }
}

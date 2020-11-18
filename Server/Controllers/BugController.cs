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
        public async Task<ActionResult<List<BugInput>>> GetBugs([FromBody] BugInput bugs)
        {
            return Ok(bugs);
        }

        [HttpGet("/{id}")]
        public async Task<ActionResult<BugInput>> GetSingleBug([FromBody] BugInput bugs)
        {
            return Ok(bugs);
        }

        [HttpDelete]
        public async Task<ActionResult<BugInput>> DeleteBug([FromBody] BugInput bug)
        {
            return Ok(bug);
        }
    }
}

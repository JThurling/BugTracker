using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using Core.Models.Output.Bug;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Server.Controllers
{
    public class BugController : BaseApiController
    {
        private readonly IBugService _bug;
        private readonly IMapper _mapper;

        public BugController(IBugService bug, IMapper mapper)
        {
            _bug = bug;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<BugInput>> CreateBug([FromBody]BugInput bug)
        {
            if (!ModelState.IsValid) return BadRequest();

            var map = _mapper.Map<BugInput, BugEntity>(bug);

            var result = await _bug.AddBug(map);

            if (result.Equals(0)) return BadRequest();

            return Ok(bug);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BugOutput>>> GetBugs()
        {
            var bugs = await _bug.GetAll();

            var map = _mapper.Map<IEnumerable<BugEntity>, IEnumerable<BugOutput>>(bugs);

            return Ok(map);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BugOutput>> GetSingleBug(int id)
        {
            var bugs = await _bug.GetOne(id);

            var map = _mapper.Map<BugEntity, BugOutput>(bugs);

            return Ok(map);
        }

        [HttpDelete]
        public async Task<ActionResult<BugInput>> DeleteBug()
        {
            return Ok();
        }
    }
}

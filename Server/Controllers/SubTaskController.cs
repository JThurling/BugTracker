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
    public class SubTaskController : BaseApiController
    {
        private readonly ISubService _subService;
        private readonly IMapper _mapper;

        public SubTaskController(ISubService subService, IMapper mapper)
        {
            _subService = subService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddComment([FromBody] SubTaskInput input)
        {
            if (!ModelState.IsValid) return BadRequest();

            var map = _mapper.Map<SubTaskInput, SubTask>(input);

            var result = await _subService.AddSubTask(map);

            if (result.Equals(0)) return BadRequest();

            return Ok(map);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<CommentOutput>>> GetAllCommentsForTask(int id)
        {
            if (id.Equals(null)) return BadRequest();
            var subTasks = await _subService.ListOfSubTasks(id);

            var map = _mapper.Map<IEnumerable<SubTask>, IEnumerable<SubTaskOutput>>(subTasks);

            return Ok(map);
        }
    }
}

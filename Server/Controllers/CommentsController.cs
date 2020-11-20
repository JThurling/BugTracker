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
    public class CommentsController : BaseApiController
    {
        private readonly ICommentService _comments;
        private readonly IMapper _mapper;

        public CommentsController(ICommentService comments, IMapper mapper)
        {
            _comments = comments;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddComment([FromBody] CommentInput input)
        {
            if (!ModelState.IsValid) return BadRequest();

            var map = _mapper.Map<CommentInput, Comments>(input);

            var result = await _comments.AddComment(map);

            if (result.Equals(0)) return BadRequest();

            return Ok(map);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<CommentOutput>>> GetAllCommentsForTask(int id)
        {
            if (id.Equals(null)) return BadRequest();
            var comments = await _comments.ListOfComments(id);

            var map = _mapper.Map<IEnumerable<Comments>, IEnumerable<CommentOutput>>(comments);

            return Ok(map);
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Microsoft.AspNetCore.Mvc;

namespace BugTracker.Server.Controllers
{
    public class CommentsController : BaseApiController
    {
        private readonly ICommentService _comments;

        public CommentsController(ICommentService comments)
        {
            _comments = comments;
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddComment()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<List<Comments>> GetAllCommentsForTask()
        {
            return Ok();
        }
    }
}

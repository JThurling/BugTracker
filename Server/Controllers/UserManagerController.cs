using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BugTracker.Shared.Interfaces.Services.User;
using BugTracker.Shared.Models;
using BugTracker.Shared.Models.Inputs;
using BugTracker.Shared.Models.Output.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Server.Controllers
{
    public class UserManagerController : BaseApiController
    {
        private readonly UserManager<ApplicationUser> _users;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserManagerController(UserManager<ApplicationUser> users, IMapper mapper, IUserService userService)
        {
            _users = users;
            _mapper = mapper;
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserOutput>>> GetAllUsers()
        {
            var users = await _users.Users.ToListAsync();

            var map = _mapper.Map<List<UserOutput>>(users);

            return Ok(map);
        }

        [HttpDelete]
        public async Task<ActionResult<string>> DeleteUser([FromQuery] Guid id)
        {
            var user = await _userService.FindUser(id);

            var result = await _userService.DeleteUser(user);

            if (result.Equals(0)) return BadRequest("Something went wrong please try again later.");

            return Ok("You have successfully removed the user.");
        }

        [HttpPost]
        public async Task<ActionResult<ApplicationUser>> CreateNewUser( [FromBody] UserInput newUser)
        {
            if (!ModelState.IsValid) return BadRequest("Please enter valid information.");

            var user = _mapper.Map<ApplicationUser>(newUser);

            var result = await _userService.CreateUser(user, newUser);

            if (result == null) return BadRequest("There was an issue creating a new user please try again later");

            return Ok(result);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BugTracker.Shared.Models;
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

        public UserManagerController(UserManager<ApplicationUser> users, IMapper mapper)
        {
            _users = users;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserOutput>>> GetAllUsers()
        {
            var users = await _users.Users.ToListAsync();

            var map = _mapper.Map<List<UserOutput>>(users);

            return Ok(map);
        }

        [HttpDelete]
        public async Task<ActionResult<ApplicationUser>> DeleteUser([FromQuery] Guid id)
        {
            var user = _users.FindByIdAsync(id.ToString());

            return Ok(user);
        }
    }
}
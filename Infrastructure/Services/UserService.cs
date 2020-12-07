using System;
using System.Threading.Tasks;
using BugTracker.Shared.Interfaces.Services.User;
using BugTracker.Shared.Models;
using BugTracker.Shared.Models.Inputs;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _users;

        public UserService(UserManager<ApplicationUser> users)
        {
            _users = users;
        }

        public async Task<ApplicationUser> FindUser(Guid id)
        {
            var user = await _users.FindByIdAsync(id.ToString());

            return user;
        }

        public async Task<int> DeleteUser(ApplicationUser user)
        {
            var result = await _users.DeleteAsync(user);

            if (result.Succeeded) return 1;
            return 0;
        }

        public async Task<ApplicationUser> CreateUser(ApplicationUser user, UserInput input)
        {
            var result = await _users.CreateAsync(user, input.Password);

            if (result.Succeeded) return user;

            return null;
        }
    }
}

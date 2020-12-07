using System;
using System.Threading.Tasks;
using BugTracker.Shared.Models;

namespace BugTracker.Shared.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<ApplicationUser> FindUser(Guid id);

        Task<int> DeleteUser(ApplicationUser user);
    }
}

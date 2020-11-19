using System.Threading.Tasks;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;

namespace Core.Interfaces.Services
{
    public interface IBugService
    {
        Task<int> AddBug(BugEntity input);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;

namespace Core.Interfaces.Services
{
    public interface IBugService
    {
        Task<int> AddBug(BugEntity input);

        Task<IEnumerable<BugEntity>> GetAll();

        Task<BugEntity> GetOne(int id);

        Task<int> DeleteBug(int id);
    }
}

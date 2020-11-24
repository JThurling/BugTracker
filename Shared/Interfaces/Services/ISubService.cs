using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models.Bugs;

namespace Core.Interfaces.Services
{
    public interface ISubService
    {
        Task<int> AddSubTask(SubTask task);

        Task<List<SubTask>> ListOfSubTasks(int id);
    }
}

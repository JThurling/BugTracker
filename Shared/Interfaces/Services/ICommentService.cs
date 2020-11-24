using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Models.Bugs;

namespace Core.Interfaces.Services
{
    public interface ICommentService
    {
        Task<int> AddComment(Comments comments);

        Task<List<Comments>> ListOfComments(int id);
    }
}

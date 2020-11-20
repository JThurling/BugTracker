using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class CommentService : ICommentService
    {
        private readonly ApplicationDbContext _context;

        public CommentService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<int> AddComment(Comments comments)
        {
            if (comments == null) return 0;

            _context.Comments.Add(comments);

            var result = await _context.SaveChangesAsync();

            if (result == 0) return 0;

            return 1;
        }

        public async Task<List<Comments>> ListOfComments(int id)
        {
            var comments = await _context.Comments.Where(x => x.BugEntity == id).ToListAsync();

            return comments;
        }
    }
}

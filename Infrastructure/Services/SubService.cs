using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class SubService : ISubService
    {
        private readonly ApplicationDbContext _context;

        public SubService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddSubTask(SubTask task)
        {
            if (task == null) return 0;

            _context.SubTasks.Add(task);

            var result = await _context.SaveChangesAsync();

            if (result == 0) return 0;

            return 1;
        }

        public async Task<List<SubTask>> ListOfSubTasks(int id)
        {
            var subTask = await _context.SubTasks.Where(x => x.Id == id).ToListAsync();

            return subTask;
        }
    }
}

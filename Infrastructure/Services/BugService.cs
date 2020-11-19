using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Services
{
    public class BugService : IBugService
    {
        private readonly ApplicationDbContext _context;

        public BugService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task<int> AddBug(BugEntity input)
        {
            if (input == null) return 0;

            _context.Bugs.Add(input);

            var result = await _context.SaveChangesAsync();

            if (result <= 0) return 0;

            return 1;
        }

        public async Task<IEnumerable<BugEntity>> GetAll()
        {
            var bugs = await _context.Bugs.ToListAsync();

            return bugs;
        }

        public async Task<BugEntity> GetOne(int id)
        {
            var bugs = await _context.Bugs.FindAsync(id);

            return bugs;
        }
    }
}

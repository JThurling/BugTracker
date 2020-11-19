using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using Infrastructure.Data;

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
    }
}

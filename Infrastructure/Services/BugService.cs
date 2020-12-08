using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces.Services;
using Core.Models.Bugs;
using Core.Models.Inputs.Bug;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Nest;
using Serilog.Core;

namespace Infrastructure.Services
{
    public class BugService : IBugService
    {
        private readonly ApplicationDbContext _context;

        private readonly IElasticClient _elasticClient;

        public BugService(ApplicationDbContext context , IElasticClient elasticClient)
        {
            _context = context;
            _elasticClient = elasticClient;
        }


        public async Task<int> AddBug(BugEntity input)
        {
            if (input == null) return 0;

            _context.Bugs.Add(input);

            var result = await _context.SaveChangesAsync();

            var insertBug = await _elasticClient.IndexDocumentAsync(input);

            if (!insertBug.IsValid)
            {
                var errorMsg = "Problem inserting document to Elasticsearch.";
                throw new Exception(errorMsg);
            }

            if (result <= 0) return 0;

            return 1;
        }

        public async Task<IEnumerable<BugEntity>> GetAll()
        {
            var bugs = await _context.Bugs
                .Include(x => x.Comments)
                .Include(x => x.SubTasks)
                .ToListAsync();

            return bugs;
        }

        public async Task<BugEntity> GetOne(int id)
        {
            var bugs = await _context.Bugs.FindAsync(id);

            return bugs;
        }

        public async Task<int> DeleteBug(int id)
        {
            var bug = await _context.Bugs.FindAsync(id);

            if (bug.Equals(null)) return 0;

            _context.Bugs.Remove(bug);

            var result = await _context.SaveChangesAsync();

            if (result <= 0) return 0;

            return 1;
        }
    }
}

using AssoSystem.Data;
using AssoSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoSystem.Services
{
    public class AssociateService
    {
        public readonly AssoSystemContext _context;

        public AssociateService(AssoSystemContext context)
        {
            _context = context;
        }

        public async Task<List<Associate>> FindAllAsync()
        {
            return await _context.Associates.ToListAsync();
        }
    }
}

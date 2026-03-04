using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure.Repositories
{
    public class WorkplaceRepository : IWorkplaceRepository
    {
        private readonly AppDbContext _context;
        public WorkplaceRepository(AppDbContext context) { _context = context; }
        public async Task<Workplace?> GetByIdAsync(Guid id) => await _context.Workplaces.FindAsync(id);
        public async Task<IEnumerable<Workplace>> GetAllAsync() => await _context.Workplaces.ToListAsync();
        public async Task AddAsync(Workplace workplace) => await _context.Workplaces.AddAsync(workplace);
        public async Task UpdateAsync(Workplace workplace) => _context.Workplaces.Update(workplace);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Workplaces.FindAsync(id);
            if (entity != null) _context.Workplaces.Remove(entity);
        }
    }
}
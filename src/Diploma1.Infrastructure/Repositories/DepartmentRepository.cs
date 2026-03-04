using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context) { _context = context; }
        public async Task<Department?> GetByIdAsync(Guid id) => await _context.Departments.FindAsync(id);
        public async Task<IEnumerable<Department>> GetAllAsync() => await _context.Departments.ToListAsync();
        public async Task AddAsync(Department department) => await _context.Departments.AddAsync(department);
        public async Task UpdateAsync(Department department) => _context.Departments.Update(department);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Departments.FindAsync(id);
            if (entity != null) _context.Departments.Remove(entity);
        }
    }
}
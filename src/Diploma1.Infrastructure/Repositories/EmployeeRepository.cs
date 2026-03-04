using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Employee?> GetByIdAsync(Guid id) => await _context.Employees.FindAsync(id);
        public async Task<IEnumerable<Employee>> GetAllAsync() => await _context.Employees.ToListAsync();
        public async Task AddAsync(Employee employee) => await _context.Employees.AddAsync(employee);
        public async Task UpdateAsync(Employee employee) => _context.Employees.Update(employee);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Employees.FindAsync(id);
            if (entity != null) _context.Employees.Remove(entity);
        }
    }
}
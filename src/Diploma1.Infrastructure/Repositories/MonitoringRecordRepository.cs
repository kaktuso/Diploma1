using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure.Repositories
{
    public class MonitoringRecordRepository : IMonitoringRecordRepository
    {
        private readonly AppDbContext _context;
        public MonitoringRecordRepository(AppDbContext context) { _context = context; }
        public async Task<MonitoringRecord?> GetByIdAsync(Guid id) => await _context.MonitoringRecords.FindAsync(id);
        public async Task<IEnumerable<MonitoringRecord>> GetAllAsync() => await _context.MonitoringRecords.ToListAsync();
        public async Task AddAsync(MonitoringRecord record) => await _context.MonitoringRecords.AddAsync(record);
        public async Task UpdateAsync(MonitoringRecord record) => _context.MonitoringRecords.Update(record);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.MonitoringRecords.FindAsync(id);
            if (entity != null) _context.MonitoringRecords.Remove(entity);
        }
    }
}
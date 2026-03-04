using Diploma1.Domain.Entities;

namespace Diploma1.Domain.Interfaces
{
    public interface IMonitoringRecordRepository
    {
        Task<MonitoringRecord?> GetByIdAsync(Guid id);
        Task<IEnumerable<MonitoringRecord>> GetAllAsync();
        Task AddAsync(MonitoringRecord record);
        Task UpdateAsync(MonitoringRecord record);
        Task DeleteAsync(Guid id);
    }
}
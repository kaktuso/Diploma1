using Diploma1.Application.DTO;

namespace Diploma1.Application.Interfaces
{
    public interface IMonitoringService
    {
        Task<MonitoringRecordDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<MonitoringRecordDto>> GetAllAsync();
        Task<MonitoringRecordDto> CreateAsync(MonitoringRecordDto dto);
        Task UpdateAsync(MonitoringRecordDto dto);
        Task DeleteAsync(Guid id);
    }
}
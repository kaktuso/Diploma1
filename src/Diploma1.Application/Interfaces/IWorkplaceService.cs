using Diploma1.Application.DTO;

namespace Diploma1.Application.Interfaces
{
    public interface IWorkplaceService
    {
        Task<WorkplaceDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<WorkplaceDto>> GetAllAsync();
        Task<WorkplaceDto> CreateAsync(WorkplaceDto dto);
        Task UpdateAsync(WorkplaceDto dto);
        Task DeleteAsync(Guid id);
    }
}
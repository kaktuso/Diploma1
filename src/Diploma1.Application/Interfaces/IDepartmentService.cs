using Diploma1.Application.DTO;

namespace Diploma1.Application.Interfaces
{
    public interface IDepartmentService
    {
        Task<DepartmentDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<DepartmentDto>> GetAllAsync();
        Task<DepartmentDto> CreateAsync(DepartmentDto dto);
        Task UpdateAsync(DepartmentDto dto);
        Task DeleteAsync(Guid id);
    }
}
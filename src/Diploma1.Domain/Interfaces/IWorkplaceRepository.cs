using Diploma1.Domain.Entities;

namespace Diploma1.Domain.Interfaces
{
    public interface IWorkplaceRepository
    {
        Task<Workplace?> GetByIdAsync(Guid id);
        Task<IEnumerable<Workplace>> GetAllAsync();
        Task AddAsync(Workplace workplace);
        Task UpdateAsync(Workplace workplace);
        Task DeleteAsync(Guid id);
    }
}
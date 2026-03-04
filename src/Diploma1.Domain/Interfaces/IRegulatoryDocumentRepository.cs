using Diploma1.Domain.Entities;

namespace Diploma1.Domain.Interfaces
{
    public interface IRegulatoryDocumentRepository
    {
        Task<RegulatoryDocument?> GetByIdAsync(Guid id);
        Task<IEnumerable<RegulatoryDocument>> GetAllAsync();
        Task AddAsync(RegulatoryDocument doc);
        Task UpdateAsync(RegulatoryDocument doc);
        Task DeleteAsync(Guid id);
    }
}
using Diploma1.Application.DTO;

namespace Diploma1.Application.Interfaces
{
    public interface IRegulatoryDocumentService
    {
        Task<RegulatoryDocumentDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<RegulatoryDocumentDto>> GetAllAsync();
        Task<RegulatoryDocumentDto> CreateAsync(RegulatoryDocumentDto dto);
        Task UpdateAsync(RegulatoryDocumentDto dto);
        Task DeleteAsync(Guid id);
    }
}
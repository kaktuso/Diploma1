using Diploma1.Application.DTO;

namespace Diploma1.Application.Interfaces
{
    public interface IAttestationService
    {
        Task<AttestationDto?> GetByIdAsync(Guid id);
        Task<IEnumerable<AttestationDto>> GetAllAsync();
        Task<AttestationDto> CreateAsync(AttestationDto dto);
        Task UpdateAsync(AttestationDto dto);
        Task DeleteAsync(Guid id);
    }
}
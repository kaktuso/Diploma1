using Diploma1.Domain.Entities;

namespace Diploma1.Domain.Interfaces
{
    public interface IAttestationRepository
    {
        Task<Attestation?> GetByIdAsync(Guid id);
        Task<IEnumerable<Attestation>> GetAllAsync();
        Task AddAsync(Attestation attestation);
        Task UpdateAsync(Attestation attestation);
        Task DeleteAsync(Guid id);
    }
}
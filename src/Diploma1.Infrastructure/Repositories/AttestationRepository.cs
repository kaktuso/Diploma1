using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure.Repositories
{
    public class AttestationRepository : IAttestationRepository
    {
        private readonly AppDbContext _context;
        public AttestationRepository(AppDbContext context) { _context = context; }
        public async Task<Attestation?> GetByIdAsync(Guid id) => await _context.Attestations.FindAsync(id);
        public async Task<IEnumerable<Attestation>> GetAllAsync() => await _context.Attestations.ToListAsync();
        public async Task AddAsync(Attestation attestation) => await _context.Attestations.AddAsync(attestation);
        public async Task UpdateAsync(Attestation attestation) => _context.Attestations.Update(attestation);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.Attestations.FindAsync(id);
            if (entity != null) _context.Attestations.Remove(entity);
        }
    }
}
using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Diploma1.Infrastructure.Repositories
{
    public class RegulatoryDocumentRepository : IRegulatoryDocumentRepository
    {
        private readonly AppDbContext _context;
        public RegulatoryDocumentRepository(AppDbContext context) { _context = context; }
        public async Task<RegulatoryDocument?> GetByIdAsync(Guid id) => await _context.RegulatoryDocuments.FindAsync(id);
        public async Task<IEnumerable<RegulatoryDocument>> GetAllAsync() => await _context.RegulatoryDocuments.ToListAsync();
        public async Task AddAsync(RegulatoryDocument doc) => await _context.RegulatoryDocuments.AddAsync(doc);
        public async Task UpdateAsync(RegulatoryDocument doc) => _context.RegulatoryDocuments.Update(doc);
        public async Task DeleteAsync(Guid id)
        {
            var entity = await _context.RegulatoryDocuments.FindAsync(id);
            if (entity != null) _context.RegulatoryDocuments.Remove(entity);
        }
    }
}
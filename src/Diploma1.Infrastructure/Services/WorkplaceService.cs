using Diploma1.Application.DTO;
using Diploma1.Application.Interfaces;
using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using AutoMapper;

namespace Diploma1.Infrastructure.Services
{
    public class WorkplaceService : IWorkplaceService
    {
        private readonly IWorkplaceRepository _repo;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public WorkplaceService(IWorkplaceRepository repo, IUnitOfWork uow, IMapper mapper)
        {
            _repo = repo;
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<WorkplaceDto?> GetByIdAsync(Guid id)
        {
            var entity = await _repo.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<WorkplaceDto>(entity);
        }
        public async Task<IEnumerable<WorkplaceDto>> GetAllAsync()
        {
            var entities = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<WorkplaceDto>>(entities);
        }
        public async Task<WorkplaceDto> CreateAsync(WorkplaceDto dto)
        {
            var entity = _mapper.Map<Workplace>(dto);
            await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync();
            return _mapper.Map<WorkplaceDto>(entity);
        }
        public async Task UpdateAsync(WorkplaceDto dto)
        {
            var entity = _mapper.Map<Workplace>(dto);
            await _repo.UpdateAsync(entity);
            await _uow.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _repo.DeleteAsync(id);
            await _uow.SaveChangesAsync();
        }
    }
}
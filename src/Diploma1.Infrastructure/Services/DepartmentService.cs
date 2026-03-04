using Diploma1.Application.DTO;
using Diploma1.Application.Interfaces;
using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using AutoMapper;

namespace Diploma1.Infrastructure.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repo;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public DepartmentService(IDepartmentRepository repo, IUnitOfWork uow, IMapper mapper)
        {
            _repo = repo;
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<DepartmentDto?> GetByIdAsync(Guid id)
        {
            var entity = await _repo.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<DepartmentDto>(entity);
        }
        public async Task<IEnumerable<DepartmentDto>> GetAllAsync()
        {
            var entities = await _repo.GetAllAsync();
            return _mapper.Map<IEnumerable<DepartmentDto>>(entities);
        }
        public async Task<DepartmentDto> CreateAsync(DepartmentDto dto)
        {
            var entity = _mapper.Map<Department>(dto);
            await _repo.AddAsync(entity);
            await _uow.SaveChangesAsync();
            return _mapper.Map<DepartmentDto>(entity);
        }
        public async Task UpdateAsync(DepartmentDto dto)
        {
            var entity = _mapper.Map<Department>(dto);
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
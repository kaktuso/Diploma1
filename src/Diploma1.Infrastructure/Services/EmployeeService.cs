using Diploma1.Application.DTO;
using Diploma1.Application.Interfaces;
using Diploma1.Domain.Entities;
using Diploma1.Domain.Interfaces;
using Diploma1.Infrastructure.Persistence;
using AutoMapper;

namespace Diploma1.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<EmployeeDto?> GetByIdAsync(Guid id)
        {
            var entity = await _employeeRepository.GetByIdAsync(id);
            return entity == null ? null : _mapper.Map<EmployeeDto>(entity);
        }
        public async Task<IEnumerable<EmployeeDto>> GetAllAsync()
        {
            var entities = await _employeeRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<EmployeeDto>>(entities);
        }
        public async Task<EmployeeDto> CreateAsync(EmployeeDto dto)
        {
            var entity = _mapper.Map<Employee>(dto);
            await _employeeRepository.AddAsync(entity);
            await _unitOfWork.SaveChangesAsync();
            return _mapper.Map<EmployeeDto>(entity);
        }
        public async Task UpdateAsync(EmployeeDto dto)
        {
            var entity = _mapper.Map<Employee>(dto);
            await _employeeRepository.UpdateAsync(entity);
            await _unitOfWork.SaveChangesAsync();
        }
        public async Task DeleteAsync(Guid id)
        {
            await _employeeRepository.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}
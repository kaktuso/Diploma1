using MediatR;
using Diploma1.Application.DTO;
using Diploma1.Application.Interfaces;

namespace Diploma1.Application.CQRS.Handlers
{
    public class GetEmployeeByIdQueryHandler : IRequestHandler<Queries.GetEmployeeByIdQuery, EmployeeDto?>
    {
        private readonly IEmployeeService _employeeService;
        public GetEmployeeByIdQueryHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<EmployeeDto?> Handle(Queries.GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeService.GetByIdAsync(request.Id);
        }
    }
}
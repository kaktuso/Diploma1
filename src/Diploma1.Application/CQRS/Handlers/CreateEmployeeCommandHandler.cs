using MediatR;
using Diploma1.Application.DTO;
using Diploma1.Application.Interfaces;

namespace Diploma1.Application.CQRS.Handlers
{
    public class CreateEmployeeCommandHandler : IRequestHandler<Commands.CreateEmployeeCommand, EmployeeDto>
    {
        private readonly IEmployeeService _employeeService;
        public CreateEmployeeCommandHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public async Task<EmployeeDto> Handle(Commands.CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await _employeeService.CreateAsync(request.Employee);
        }
    }
}
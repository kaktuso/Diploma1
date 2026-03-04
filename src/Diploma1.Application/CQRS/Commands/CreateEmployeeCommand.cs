using MediatR;
using Diploma1.Application.DTO;

namespace Diploma1.Application.CQRS.Commands
{
    public class CreateEmployeeCommand : IRequest<EmployeeDto>
    {
        public EmployeeDto Employee { get; set; }
        public CreateEmployeeCommand(EmployeeDto employee)
        {
            Employee = employee;
        }
    }
}
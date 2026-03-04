using MediatR;
using Diploma1.Application.DTO;

namespace Diploma1.Application.CQRS.Queries
{
    public class GetEmployeeByIdQuery : IRequest<EmployeeDto?>
    {
        public Guid Id { get; set; }
        public GetEmployeeByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
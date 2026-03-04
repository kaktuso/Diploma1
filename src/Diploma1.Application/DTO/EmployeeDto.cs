using Diploma1.Domain.Enums;

namespace Diploma1.Application.DTO
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? MiddleName { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
        public Guid WorkplaceId { get; set; }
        public Role Role { get; set; }
        public Guid? AssignedEngineerId { get; set; }
    }
}
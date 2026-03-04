using System;

namespace Diploma1.Web.Models
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
        public Guid WorkplaceId { get; set; }
        public string Role { get; set; } = string.Empty;
        public Guid? AssignedEngineerId { get; set; }
    }
}

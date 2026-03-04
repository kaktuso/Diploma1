using Diploma1.Domain.Enums;

namespace Diploma1.Application.DTO
{
    public class WorkplaceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public WorkplaceType Type { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
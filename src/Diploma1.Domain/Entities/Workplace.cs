using Diploma1.Domain.Enums;

namespace Diploma1.Domain.Entities
{
    public class Workplace
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public WorkplaceType Type { get; set; }
        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
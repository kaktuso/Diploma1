using Diploma1.Domain.Enums;
using Diploma1.Domain.ValueObjects;

namespace Diploma1.Domain.Entities
{
    public class Employee
    {
        public Guid Id { get; set; }
        public FullName FullName { get; set; } = default!;
        public Email Email { get; set; } = default!;
        public string Position { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
        public Department? Department { get; set; }
        public Guid WorkplaceId { get; set; }
        public Workplace? Workplace { get; set; }
        public Role Role { get; set; }
        public Guid? AssignedEngineerId { get; set; }
        public Employee? AssignedEngineer { get; set; }
        public ICollection<Attestation> Attestations { get; set; } = new List<Attestation>();
        public ICollection<MonitoringRecord> MonitoringRecords { get; set; } = new List<MonitoringRecord>();
    }
}
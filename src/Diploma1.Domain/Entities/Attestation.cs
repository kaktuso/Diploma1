using Diploma1.Domain.Enums;

namespace Diploma1.Domain.Entities
{
    public class Attestation
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime Date { get; set; }
        public AttestationStatus Status { get; set; }
        public DateTime? NextAttemptDate { get; set; }
        public Guid? ResponsibleEngineerId { get; set; }
        public Employee? ResponsibleEngineer { get; set; }
        public string? ResultDocumentPath { get; set; }
    }
}
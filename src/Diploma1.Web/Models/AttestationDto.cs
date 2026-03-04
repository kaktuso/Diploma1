using System;

namespace Diploma1.Web.Models
{
    public class AttestationDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public string? EmployeeFullName { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; } = string.Empty;
        public DateTime? NextAttemptDate { get; set; }
        public Guid? ResponsibleEngineerId { get; set; }
        public string? ResponsibleEngineerFullName { get; set; }
        public string? ResultDocumentPath { get; set; }
    }
}
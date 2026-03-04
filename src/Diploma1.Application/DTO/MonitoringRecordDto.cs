namespace Diploma1.Application.DTO
{
    public class MonitoringRecordDto
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime Date { get; set; }
        public double Temperature { get; set; }
        public double Illumination { get; set; }
        public double Noise { get; set; }
        public double Humidity { get; set; }
        public string? HazardFactors { get; set; }
        public bool IsViolation { get; set; }
        public string? ViolationDescription { get; set; }
    }
}
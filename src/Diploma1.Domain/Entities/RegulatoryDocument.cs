namespace Diploma1.Domain.Entities
{
    public class RegulatoryDocument
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string FileName { get; set; } = string.Empty;
        public byte[] Content { get; set; } = Array.Empty<byte>();
        public string ContentType { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; }
        public ICollection<Department> Departments { get; set; } = new List<Department>();
    }
}
using System;

namespace Diploma1.Web.Models
{
    public class WorkplaceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public Guid DepartmentId { get; set; }
    }
}
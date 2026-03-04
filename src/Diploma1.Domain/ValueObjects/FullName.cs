// Value Object for FullName
namespace Diploma1.Domain.ValueObjects
{
    public record FullName(string FirstName, string LastName, string? MiddleName = null)
    {
        public override string ToString() => $"{LastName} {FirstName}{(string.IsNullOrWhiteSpace(MiddleName) ? "" : " " + MiddleName)}";
    }
}
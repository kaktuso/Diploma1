// Value Object for Email
namespace Diploma1.Domain.ValueObjects
{
    public record Email(string Value)
    {
        public static Email Create(string value)
        {
            if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                throw new ArgumentException("Invalid email format");
            return new Email(value);
        }
    }
}
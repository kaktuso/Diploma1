namespace Diploma1.Web.Services;

public enum AppRole
{
    Administrator,
    SafetyEngineer,
    Employee
}

public sealed class UserContextService
{
    public AppRole CurrentRole { get; private set; } = AppRole.Administrator;

    public event Action? Changed;

    public void SetRole(AppRole role)
    {
        CurrentRole = role;
        Changed?.Invoke();
    }
}

using Microsoft.AspNetCore.Identity;

namespace Diploma1.Infrastructure.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        // Дополнительные поля профиля пользователя
    }

    public class ApplicationRole : IdentityRole<Guid>
    {
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicLink;

public class LoginContext : IdentityDbContext
{
    public LoginContext(DbContextOptions<LoginContext> options)
        : base(options)
    {
    }
}
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PHCApplication.Areas.Identity.Data;
using PHCApplication.Models;

namespace PHCApplication.Data;

public class PHCApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public PHCApplicationDbContext(DbContextOptions<PHCApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        base.OnModelCreating(builder);
        builder.HasDefaultSchema("Identity");
        builder.Entity<IdentityUser>(entity => { entity.ToTable(name: "User"); });
        builder.Entity<IdentityRole>(entity => { entity.ToTable(name: "Role"); });
        builder.Entity<IdentityUserRole<string>>(entity => { entity.ToTable("UserRoles"); });
        builder.Entity<IdentityUserClaim<string>>(entity => { entity.ToTable("UserClaims"); });
        builder.Entity<IdentityUserLogin<string>>(entity => { entity.ToTable("UserLogins"); });
        builder.Entity<IdentityRoleClaim<string>>(entity => { entity.ToTable("RoleClaims"); });
        builder.Entity<IdentityUserToken<string>>(entity => { entity.ToTable("UserTokens"); });
    }

    public DbSet<PHCApplication.Models.Appointment>? Appointment { get; set; }
}

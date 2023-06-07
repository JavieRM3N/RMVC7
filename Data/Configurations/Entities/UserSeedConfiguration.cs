using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ResidenciaMVC.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            var hasher = new PasswordHasher<Empleado>();
            builder.HasData(
                 new Empleado
                 {
                     Id = "408aa945-3d84-4421-8342-7269ec64d949",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     Firstname = "System",
                     Lastname = "Admin",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Empleado
                 {
                     Id = "3f4631bd-f907-4409-b416-ba356312e659",
                     Email = "user@localhost.com",
                     NormalizedEmail = "USER@LOCALHOST.COM",
                     NormalizedUserName = "USER@LOCALHOST.COM",
                     UserName = "user@localhost.com",
                     Firstname = "System",
                     Lastname = "User",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}

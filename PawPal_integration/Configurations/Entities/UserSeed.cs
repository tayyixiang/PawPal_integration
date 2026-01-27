using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PawPal_integration.Data;

namespace PawPal_integration.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<PawPalUser>
    {
        public void Configure(EntityTypeBuilder<PawPalUser> builder)
        {
            var hasher = new PasswordHasher<PawPalUser>();
            builder.HasData(
                new PawPalUser
                {
                    Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
            );
        }
    }
}
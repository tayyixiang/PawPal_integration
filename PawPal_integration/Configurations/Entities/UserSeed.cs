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
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                    // REMOVED properties causing issues if they were inherited from BaseDomainModel
                    // If you have CreatedBy/UpdatedBy in PawPalUser, set them to "System" instead of null
                }
            );
        }
    }
}
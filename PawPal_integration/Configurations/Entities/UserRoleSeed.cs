using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PawPal_integration.Configurations.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3501103f-4e2b-47e0-bb15-09c31498064d", // Must match RoleSeed Id
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9"  // Must match UserSeed Id
                }
            );
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PawPal_integration.Configurations.Entities;
using PawPal_integration.Domain;

namespace PawPal_integration.Data
{
    public class PawPalContext : IdentityDbContext<PawPalUser>
    {
        public PawPalContext(DbContextOptions<PawPalContext> options)
            : base(options)
        {
        }

        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        // NEW: Nicole's Entity
        public DbSet<AdoptionApplication> AdoptionApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // 1. Shelter -> Pets Relationship
            builder.Entity<Shelter>()
                .HasMany(s => s.Pets)
                .WithOne(p => p.Shelter)
                .HasForeignKey(p => p.ShelterId)
                .OnDelete(DeleteBehavior.Cascade);

            // 2. Pet -> AdoptionApplications Relationship (Added for Integration)
            builder.Entity<AdoptionApplication>()
                .HasOne(a => a.Pet)
                .WithMany() // A pet can have multiple applications
                .HasForeignKey(a => a.PetId)
                .OnDelete(DeleteBehavior.Cascade);

            // 3. Apply Seeding
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed());
            builder.ApplyConfiguration(new UserRoleSeed());
        }

        // Automate DateCreated and DateUpdated
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseDomainModel>()
                .Where(q => q.State == EntityState.Added || q.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                entry.Entity.DateUpdated = DateTime.Now;

                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
using System.ComponentModel.DataAnnotations;

namespace PawPal_integration.Domain
{
    public class Pet : BaseDomainModel
    {
        public string? Name { get; set; }

        public string? Breed { get; set; }

        public int Age { get; set; }

        public string? Gender { get; set; }

        public string? Color { get; set; }

        public string? ImageUrl { get; set; } // Storing image path as string for now

        public string? Description { get; set; }

        // Foreign Key
        public int ShelterId { get; set; }

        // Navigation Property
        public Shelter? Shelter { get; set; }
    }
}
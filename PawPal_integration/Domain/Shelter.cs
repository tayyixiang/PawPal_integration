using System.ComponentModel.DataAnnotations;

namespace PawPal_integration.Domain
{
    public class Shelter : BaseDomainModel
    {
        public string? Name { get; set; }

        public string? Address { get; set; }

        public string? ContactNumber { get; set; }

        public string? Email { get; set; }

        // Navigation Property: One Shelter has Many Pets
        // Initialise the list to prevent null reference errors
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
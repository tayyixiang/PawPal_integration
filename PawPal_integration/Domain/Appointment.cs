using System.ComponentModel.DataAnnotations;

namespace PawPal_integration.Domain
{
    public class Appointment : BaseDomainModel
    {
        public DateTime AppointmentDate { get; set; }

        public string? Status { get; set; } // "Pending", "Confirmed", "Completed"

        // Foreign Key: Links to Pet
        public int PetId { get; set; }

        // Navigation Property
        public Pet? Pet { get; set; }

        // Foreign Key: Links to AdoptionApplication
        public int? AdoptionApplicationId { get; set; }
    }
}
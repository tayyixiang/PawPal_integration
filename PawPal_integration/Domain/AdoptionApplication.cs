using System.ComponentModel.DataAnnotations;

namespace PawPal_integration.Domain
{
    public class AdoptionApplication : BaseDomainModel
    {
        // Link to Yixiang's Pet
        public int PetId { get; set; }
        public Pet? Pet { get; set; }

        // Link to User (Adopter) - Stored as String (Identity User Id)
        public string AdopterId { get; set; } = "";

        // Link to User (Admin) who reviewed it
        public string? ReviewedByAdminId { get; set; }

        public DateTime ApplicationDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pending"; // Pending, Approved, Rejected
        public string? Remarks { get; set; }

        // --- Form Fields (Contact) ---
        public string FullName { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Address { get; set; } = "";

        // --- Home Suitability ---
        public string HousingType { get; set; } = "";            // HDB/Condo/Landed/Rental
        public bool HasLandlordOrFamilyApproval { get; set; }
        public bool AnyoneAllergic { get; set; }
        public int AvgHoursAlone { get; set; }

        // --- Ownership Experience ---
        public bool CurrentlyOwnPets { get; set; }
        public string? CurrentPetsDetails { get; set; }
        public string? PetExperienceDetails { get; set; }

        // --- Motivation ---
        public string ReasonForAdoption { get; set; } = "";
        public string PrimaryCaregiver { get; set; } = "";
        public bool PreparedForVetCare { get; set; }

        // --- Admin Section ---
        public string? AdminRemarks { get; set; }
        public DateTime? ReviewedDateTime { get; set; }
    }
}
using Microsoft.AspNetCore.Identity;

namespace PawPal_integration.Data
{
    // Inheriting from IdentityUser gives us the standard table fields 
    // (Id, UserName, Email, PasswordHash, etc.)
    public class PawPalUser : IdentityUser
    {
        // We add these custom fields to store the user's actual name
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
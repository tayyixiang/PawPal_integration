using PawPal_integration.Data;
using Microsoft.AspNetCore.Identity;

namespace PawPal_integration.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<PawPalUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<PawPalUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}

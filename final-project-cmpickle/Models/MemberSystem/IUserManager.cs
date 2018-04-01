using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public interface IUserManager
    {
        IQueryable<IIdentityUser> Users { get; set; }

       Task<IdentityResult> CreateAsync(IIdentityUser user, string password);

       Task<IdentityResult> DeleteAsync(IIdentityUser identityUser);

       Task<string> GenerateEmailConfirmationTokenAsync(IIdentityUser identityUser);

       Task<IIdentityUser> FindByEmailAsync(string email);

       Task<IIdentityUser> FindByIdAsync(string userId);

       Task<IdentityResult> UpdateAsync(IIdentityUser identityUser);

       Task<IdentityResult> ConfirmEmailAsync(IIdentityUser identityUser, string code);

       Task<bool> IsEmailConfirmedAsync(IIdentityUser identityUser);

       Task<string> GeneratePasswordResetTokenAsync(IIdentityUser identityUser);

       Task<IdentityResult> ResetPasswordAsync(IIdentityUser identityUser, string code, string password);
    }
}
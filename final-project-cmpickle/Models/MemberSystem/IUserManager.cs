using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public interface IUserManager<T>
    {
        IQueryable Users { get; set; }

       Task<IdentityResult> CreateAsync(T user, string password);

       Task<IdentityResult> DeleteAsync(T identityUser);

       Task<string> GenerateEmailConfirmationTokenAsync(T identityUser);

       Task<T> FindByEmailAsync(string email);

       Task<T> FindByIdAsync(string userId);

       Task<T> FindByNameAsync(string name);

       Task<IdentityResult> UpdateAsync(T identityUser);

       Task<IdentityResult> ConfirmEmailAsync(T identityUser, string code);

       Task<bool> IsEmailConfirmedAsync(T identityUser);

       Task<string> GeneratePasswordResetTokenAsync(T identityUser);

       Task<IdentityResult> ResetPasswordAsync(T identityUser, string code, string password);
    }
}
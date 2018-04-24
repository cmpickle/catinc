using System.Linq;
using System.Threading.Tasks;
using catinc.Models.ViewModels.AccountViewModels;
using catinc.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;

namespace catinc.Repositories
{
    public interface IUserRepository<TUser>
    {
        IQueryable Get();

        Task<TUser> FindByEmailAsync(string email);

        Task<TUser> FindByIdAsync(string userId);

        IdentityResult Create(RegisterViewModel registerViewModel, string password);

        IdentityResult Update(TUser identityUser);

        IdentityResult Delete(TUser identityUser);

        Task<string> GenerateEmailConfirmationTokenAsync(TUser applicationUser);

        Task<IdentityResult> ConfirmEmailAsync(TUser identityUser, string code);

        Task<bool> IsEmailConfirmedAsync(TUser identityUser);

        Task<string> GeneratePasswordResetTokenAsync(TUser identityUser);

        Task<IdentityResult> ResetPasswordAsync(TUser identityUser, string code, string password);
    }
}
using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.AccountViewModels;
using final_project_cmpickle.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;

public interface IUserRepository
{
    IQueryable<IIdentityUser> Get();

    Task<IIdentityUser> FindByEmailAsync(string email);

    Task<IIdentityUser> FindByIdAsync(string userId);

    IdentityResult Create(RegisterViewModel registerViewModel, string password);

    IdentityResult Update(IIdentityUser identityUser);

    IdentityResult Delete(IIdentityUser identityUser);

    Task<string> GenerateEmailConfirmationTokenAsync(IIdentityUser applicationUser);

    Task<IdentityResult> ConfirmEmailAsync(IIdentityUser identityUser, string code);

    Task<bool> IsEmailConfirmedAsync(IIdentityUser identityUser);

    Task<string> GeneratePasswordResetTokenAsync(IIdentityUser identityUser);

    Task<IdentityResult> ResetPasswordAsync(IIdentityUser identityUser, string code, string password);
}
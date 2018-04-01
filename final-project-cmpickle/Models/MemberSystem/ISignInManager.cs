using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public interface ISignInManager
    {
        Task<SignInResult> PasswordSignInAsync(string email, string password, bool isPersistent, bool lockoutOnFailure);

        Task<SignInResult> SignInAsync(IIdentityUser user, bool isPersistent);

        Task<SignInResult> SignOutAsync();

        Task<SignInResult> GetTwoFactorAuthenticationUserAsync();

        Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync();
    }
}
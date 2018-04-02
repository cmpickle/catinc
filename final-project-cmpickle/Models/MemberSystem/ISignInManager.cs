using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace final_project_cmpickle.Models.MemberSystem
{
    public interface ISignInManager
    {
        Task<Microsoft.AspNetCore.Identity.SignInResult> PasswordSignInAsync(string email, string password, bool isPersistent, bool lockoutOnFailure);

        Task<Microsoft.AspNetCore.Identity.SignInResult> SignInAsync(IIdentityUser user, bool isPersistent);

        Task SignOutAsync();

        Task<Microsoft.AspNetCore.Identity.SignInResult> GetTwoFactorAuthenticationUserAsync();

        Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync();
    }
}
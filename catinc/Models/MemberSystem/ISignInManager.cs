using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace catinc.Models.MemberSystem
{
    public interface ISignInManager<TUser>
    {
        Task<Microsoft.AspNetCore.Identity.SignInResult> PasswordSignInAsync(string email, string password, bool isPersistent, bool lockoutOnFailure);

        Task SignInAsync(TUser user, bool isPersistent);

        Task SignOutAsync();

        Task<TUser> GetTwoFactorAuthenticationUserAsync();

        Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync();
    }
}
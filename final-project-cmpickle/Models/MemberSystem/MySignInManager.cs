using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MySignInManager<TUser> : SignInManager<TUser>, ISignInManager<TUser>, IDisposable where TUser : MyIdentityUser
    {
        public MySignInManager(UserManager<TUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<TUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<TUser>> logger, IAuthenticationSchemeProvider schemes) : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        {
        }

        public Task SignInAsync(TUser user, bool isPersistent)
        {
            return base.SignInAsync(user, isPersistent);
        }

        override public Task<TUser> GetTwoFactorAuthenticationUserAsync()
        {
            return base.GetTwoFactorAuthenticationUserAsync();
        }

        override public Task SignOutAsync()
        {
            return base.SignOutAsync();
        }

        override public Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync()
        {
            return base.GetExternalAuthenticationSchemesAsync();
        }

        public void Dispose()
        {
            
        }
    }
}
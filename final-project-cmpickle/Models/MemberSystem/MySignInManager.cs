using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MySignInManager : SignInManager<IdentityUser>, ISignInManager
    {
        public MySignInManager(UserManager<IdentityUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<IdentityUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<IdentityUser>> logger, IAuthenticationSchemeProvider schemes) : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        {
        }

        public Task<SignInResult> SignInAsync(IIdentityUser user, bool isPersistent)
        {
            throw new System.NotImplementedException();
        }

        Task<SignInResult> ISignInManager.GetTwoFactorAuthenticationUserAsync()
        {
            throw new System.NotImplementedException();
        }

        Task<SignInResult> ISignInManager.SignOutAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Linq;
using System.Threading.Tasks;
using catinc.Models.ViewModels.AccountViewModels;
using catinc.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;
using catinc.Models.Domain;

namespace catinc.Repositories
{
    public class UserRepository : IUserRepository<MyIdentityUser>
    {
        private IUserManager<MyIdentityUser> _userManager;

        public UserRepository(IUserManager<MyIdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IdentityResult Create(RegisterViewModel registerViewModel, string password)
        {
            var user = new MyIdentityUser { UserName = registerViewModel.Email, Email = registerViewModel.Email };
            return _userManager.CreateAsync(user, password).Result;
        }

        public IdentityResult Delete(MyIdentityUser identityUser)
        {
            return _userManager.DeleteAsync(identityUser).Result;
        }

        public Task<string> GenerateEmailConfirmationTokenAsync(MyIdentityUser identityUser)
        {
            return _userManager.GenerateEmailConfirmationTokenAsync(identityUser);
        }

        public IQueryable Get()
        {
            return _userManager.Users;
        }

        public Task<MyIdentityUser> FindByEmailAsync(string email)
        {
            return _userManager.FindByEmailAsync(email);
        }

        public Task<MyIdentityUser> FindByIdAsync(string userId)
        {
            return _userManager.FindByIdAsync(userId);
        }

        public IdentityResult Update(MyIdentityUser identityUser)
        {
            return _userManager.UpdateAsync(identityUser).Result;
        }

        public Task<IdentityResult> ConfirmEmailAsync(MyIdentityUser identityUser, string code)
        {
            return _userManager.ConfirmEmailAsync(identityUser, code);
        }

        public Task<bool> IsEmailConfirmedAsync(MyIdentityUser identityUser)
        {
            return _userManager.IsEmailConfirmedAsync(identityUser);
        }

        public Task<string> GeneratePasswordResetTokenAsync(MyIdentityUser identityUser)
        {
            return _userManager.GeneratePasswordResetTokenAsync(identityUser);
        }

        public Task<IdentityResult> ResetPasswordAsync(MyIdentityUser identityUser, string code, string password)
        {
            return _userManager.ResetPasswordAsync(identityUser, code, password);
        }
    }
}
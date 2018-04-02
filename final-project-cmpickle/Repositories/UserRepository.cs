using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.AccountViewModels;
using final_project_cmpickle.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;

public class UserRepository : IUserRepository
{
    private IUserManager<MyIdentityUser> _userManager;

    public UserRepository(IUserManager<MyIdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public IdentityResult Create(RegisterViewModel registerViewModel, string password)
    {
        var user = new MyIdentityUser(registerViewModel.Email);
        return _userManager.CreateAsync(user, password).Result;
    }

    public IdentityResult Delete(IIdentityUser identityUser)
    {
        return _userManager.DeleteAsync(identityUser).Result;
    }

    public Task<string> GenerateEmailConfirmationTokenAsync(IIdentityUser identityUser)
    {
        return _userManager.GenerateEmailConfirmationTokenAsync(identityUser);
    }

    public IQueryable<IIdentityUser> Get()
    {
        return _userManager.Users;
    }

    public Task<IIdentityUser> FindByEmailAsync(string email)
    {
        return _userManager.FindByEmailAsync(email);
    }

    public Task<IIdentityUser> FindByIdAsync(string userId)
    {
        return _userManager.FindByIdAsync(userId);
    }

    public IdentityResult Update(IIdentityUser identityUser)
    {
        return _userManager.UpdateAsync(identityUser).Result;
    }

    public Task<IdentityResult> ConfirmEmailAsync(IIdentityUser identityUser, string code)
    {
        return _userManager.ConfirmEmailAsync(identityUser, code);
    }

    public Task<bool> IsEmailConfirmedAsync(IIdentityUser identityUser)
    {
        return _userManager.IsEmailConfirmedAsync(identityUser);
    }

    public Task<string> GeneratePasswordResetTokenAsync(IIdentityUser identityUser)
    {
        return _userManager.GeneratePasswordResetTokenAsync(identityUser);
    }

    public Task<IdentityResult> ResetPasswordAsync(IIdentityUser identityUser, string code, string password)
    {
        return _userManager.ResetPasswordAsync(identityUser, code, password);
    }
}
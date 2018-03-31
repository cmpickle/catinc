using System.Linq;
using System.Threading.Tasks;
using final_project_cmpickle.Models.AccountViewModels;
using final_project_cmpickle.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;

public class UserRepository : IUserRepository
{
    private UserManager<IIdentityUser> _userManager;

    public UserRepository(UserManager<IIdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public IdentityResult Create(RegisterViewModel registerViewModel, string password)
    {
        var user = new MyIdentityUser(registerViewModel.Email);
        return _userManager.CreateAsync(user, password).Result;
    }

    public IdentityResult Delete(IIdentityUser applicationUser)
    {
        return _userManager.DeleteAsync(applicationUser).Result;
    }

    public Task<string> GenerateEmailConfirmationTokenAsync(IIdentityUser applicationUser)
    {
        return _userManager.GenerateEmailConfirmationTokenAsync(applicationUser);
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

    public IdentityResult Update(IIdentityUser applicationUser)
    {
        return _userManager.UpdateAsync(applicationUser).Result;
    }

    public Task<IdentityResult> ConfirmEmailAsync(IIdentityUser applicationUser, string code)
    {
        return _userManager.ConfirmEmailAsync(applicationUser, code);
    }

    public Task<bool> IsEmailConfirmedAsync(IIdentityUser applicationUser)
    {
        return _userManager.IsEmailConfirmedAsync(applicationUser);
    }

    public Task<string> GeneratePasswordResetTokenAsync(IIdentityUser applicationUser)
    {
        return _userManager.GeneratePasswordResetTokenAsync(applicationUser);
    }

    public Task<IdentityResult> ResetPasswordAsync(IIdentityUser applicationUser, string code, string password)
    {
        return _userManager.ResetPasswordAsync(applicationUser, code, password);
    }
}
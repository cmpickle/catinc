using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NewMvc6Project.Models;

public class UserRepository : IUserRepository
{
    private UserManager<ApplicationUser> _userManager;

    public UserRepository(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public IdentityResult Create(ApplicationUser applicationUser, string password)
    {
        return _userManager.CreateAsync(applicationUser, password).Result;
    }

    public IdentityResult Delete(ApplicationUser applicationUser)
    {
        return _userManager.DeleteAsync(applicationUser).Result;
    }

    public Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser applicationUser)
    {
        return _userManager.GenerateEmailConfirmationTokenAsync(applicationUser);
    }

    public IQueryable<ApplicationUser> Get()
    {
        return _userManager.Users;
    }

    public Task<ApplicationUser> FindByEmailAsync(string email)
    {
        return _userManager.FindByEmailAsync(email);
    }

    public Task<ApplicationUser> FindByIdAsync(string userId)
    {
        return _userManager.FindByIdAsync(userId);
    }

    public IdentityResult Update(ApplicationUser applicationUser)
    {
        return _userManager.UpdateAsync(applicationUser).Result;
    }

    public Task<IdentityResult> ConfirmEmailAsync(ApplicationUser applicationUser, string code)
    {
        return _userManager.ConfirmEmailAsync(applicationUser, code);
    }

    public Task<bool> IsEmailConfirmedAsync(ApplicationUser applicationUser)
    {
        return _userManager.IsEmailConfirmedAsync(applicationUser);
    }

    public Task<string> GeneratePasswordResetTokenAsync(ApplicationUser applicationUser)
    {
        return _userManager.GeneratePasswordResetTokenAsync(applicationUser);
    }

    public Task<IdentityResult> ResetPasswordAsync(ApplicationUser applicationUser, string code, string password)
    {
        return _userManager.ResetPasswordAsync(applicationUser, code, password);
    }
}
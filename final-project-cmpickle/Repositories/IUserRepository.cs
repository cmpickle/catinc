using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using NewMvc6Project.Models;

public interface IUserRepository
{
    IQueryable<ApplicationUser> Get();

    Task<ApplicationUser> FindByEmailAsync(string email);

    Task<ApplicationUser> FindByIdAsync(string userId);

    IdentityResult Create(ApplicationUser applicationUser, string password);

    IdentityResult Update(ApplicationUser applicationUser);

    IdentityResult Delete(ApplicationUser applicationUser);

    Task<string> GenerateEmailConfirmationTokenAsync(ApplicationUser applicationUser);

    Task<IdentityResult> ConfirmEmailAsync(ApplicationUser applicationUser, string code);

    Task<bool> IsEmailConfirmedAsync(ApplicationUser applicationUser);

    Task<string> GeneratePasswordResetTokenAsync(ApplicationUser applicationUser);

    Task<IdentityResult> ResetPasswordAsync(ApplicationUser applicationUser, string code, string password);
}
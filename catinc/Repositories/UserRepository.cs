using System.Linq;
using System.Threading.Tasks;
using catinc.Models.ViewModels.AccountViewModels;
using catinc.Models.MemberSystem;
using Microsoft.AspNetCore.Identity;
using catinc.Models.Domain;

namespace catinc.Repositories
{
    /// <summary>
    /// User repository to interact with Users from the DB
    /// </summary>
    public class UserRepository : IUserRepository<MyIdentityUser>
    {
        private IUserManager<MyIdentityUser> _userManager;

        /// <summary>
        /// Creates a user repository
        /// </summary>
        /// <param name="userManager"></param>
        public UserRepository(IUserManager<MyIdentityUser> userManager)
        {
            _userManager = userManager;
        }

        /// <summary>
        /// Creates a user object in the DB
        /// </summary>
        /// <param name="registerViewModel"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public IdentityResult Create(RegisterViewModel registerViewModel, string password)
        {
            var user = new MyIdentityUser { UserName = registerViewModel.Email, Email = registerViewModel.Email };
            return _userManager.CreateAsync(user, password).Result;
        }

        /// <summary>
        /// Deletes a user object from the DB
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        public IdentityResult Delete(MyIdentityUser identityUser)
        {
            return _userManager.DeleteAsync(identityUser).Result;
        }

        /// <summary>
        /// returns a email confirmation token
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        public Task<string> GenerateEmailConfirmationTokenAsync(MyIdentityUser identityUser)
        {
            return _userManager.GenerateEmailConfirmationTokenAsync(identityUser);
        }

        /// <summary>
        /// gets all users from DB
        /// </summary>
        /// <returns></returns>
        public IQueryable Get()
        {
            return _userManager.Users;
        }

        /// <summary>
        /// Finds user by email from the DB
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public Task<MyIdentityUser> FindByEmailAsync(string email)
        {
            return _userManager.FindByEmailAsync(email);
        }

        /// <summary>
        /// Finds user by id from DB
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public Task<MyIdentityUser> FindByIdAsync(string userId)
        {
            return _userManager.FindByIdAsync(userId);
        }

        /// <summary>
        /// Updates user in DB
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        public IdentityResult Update(MyIdentityUser identityUser)
        {
            return _userManager.UpdateAsync(identityUser).Result;
        }

        /// <summary>
        /// Confirms user email
        /// </summary>
        /// <param name="identityUser"></param>
        /// <param name="code"></param>
        /// <returns></returns>
        public Task<IdentityResult> ConfirmEmailAsync(MyIdentityUser identityUser, string code)
        {
            return _userManager.ConfirmEmailAsync(identityUser, code);
        }

        /// <summary>
        /// Returns wether or not user's email is confirmed
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        public Task<bool> IsEmailConfirmedAsync(MyIdentityUser identityUser)
        {
            return _userManager.IsEmailConfirmedAsync(identityUser);
        }

        /// <summary>
        /// Generates user password reset token
        /// </summary>
        /// <param name="identityUser"></param>
        /// <returns></returns>
        public Task<string> GeneratePasswordResetTokenAsync(MyIdentityUser identityUser)
        {
            return _userManager.GeneratePasswordResetTokenAsync(identityUser);
        }

        /// <summary>
        /// Resets users password
        /// </summary>
        /// <param name="identityUser"></param>
        /// <param name="code"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public Task<IdentityResult> ResetPasswordAsync(MyIdentityUser identityUser, string code, string password)
        {
            return _userManager.ResetPasswordAsync(identityUser, code, password);
        }
    }
}
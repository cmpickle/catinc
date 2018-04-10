using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MyIdentityUserManager<TUser> : UserManager<TUser>, IUserManager<TUser>, IDisposable where TUser : MyIdentityUser
    {
        public MyIdentityUserManager(IUserStore<TUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<TUser> passwordHasher, IEnumerable<IUserValidator<TUser>> userValidators, IEnumerable<IPasswordValidator<TUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<TUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }

        IQueryable IUserManager<TUser>.Users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        override public Task<IdentityResult> ConfirmEmailAsync(TUser identityUser, string code)
        {
            return base.ConfirmEmailAsync(identityUser, code);
        }

        public override Task<IdentityResult> CreateAsync(TUser user, string password)
        {
            return base.CreateAsync(user, password);
        }

        override public Task<IdentityResult> DeleteAsync(TUser identityUser)
        {
            return base.DeleteAsync(identityUser);
        }

        override public Task<string> GenerateEmailConfirmationTokenAsync(TUser identityUser)
        {
            return base.GenerateEmailConfirmationTokenAsync(identityUser);
        }

        override public Task<string> GeneratePasswordResetTokenAsync(TUser identityUser)
        {
            return base.GeneratePasswordResetTokenAsync(identityUser);
        }

        override public Task<bool> IsEmailConfirmedAsync(TUser identityUser)
        {
            return base.IsEmailConfirmedAsync(identityUser);
        }

        override public Task<IdentityResult> ResetPasswordAsync(TUser identityUser, string code, string password)
        {
            return base.ResetPasswordAsync(identityUser, code, password);
        }

        override public Task<IdentityResult> UpdateAsync(TUser identityUser)
        {
            return base.UpdateAsync(identityUser);
        }

        override public Task<TUser> FindByEmailAsync(string email)
        {
            return base.FindByEmailAsync(email);
        }

        public Task<TUser> FindByIdAsync<T>(string userId)
        {
            return base.FindByIdAsync(userId);
        }

        public Task<TUser> FindByNameAsync<T>(string name)
        {
            return base.FindByNameAsync(name);
        }
    }
}
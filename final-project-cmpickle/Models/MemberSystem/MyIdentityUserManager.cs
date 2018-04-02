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
            throw new NotImplementedException();
        }

        public override Task<IdentityResult> CreateAsync(TUser user, string password)
        {
            return base.CreateAsync(user, password);
        }

        override public Task<IdentityResult> DeleteAsync(TUser identityUser)
        {
            throw new NotImplementedException();
        }

        override public Task<string> GenerateEmailConfirmationTokenAsync(TUser identityUser)
        {
            throw new NotImplementedException();
        }

        override public Task<string> GeneratePasswordResetTokenAsync(TUser identityUser)
        {
            throw new NotImplementedException();
        }

        override public Task<bool> IsEmailConfirmedAsync(TUser identityUser)
        {
            throw new NotImplementedException();
        }

        override public Task<IdentityResult> ResetPasswordAsync(TUser identityUser, string code, string password)
        {
            throw new NotImplementedException();
        }

        override public Task<IdentityResult> UpdateAsync(TUser identityUser)
        {
            throw new NotImplementedException();
        }

        override public Task<TUser> FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<TUser> FindByIdAsync<T>(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
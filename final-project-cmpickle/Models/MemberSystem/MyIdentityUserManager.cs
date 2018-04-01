using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MyIdentityUserManager : UserManager<MyIdentityUser>, IUserManager
    {
        public MyIdentityUserManager(IUserStore<MyIdentityUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<MyIdentityUser> passwordHasher, IEnumerable<IUserValidator<MyIdentityUser>> userValidators, IEnumerable<IPasswordValidator<MyIdentityUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<MyIdentityUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
        }

        IQueryable<IIdentityUser> IUserManager.Users { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task<IdentityResult> ConfirmEmailAsync(IIdentityUser identityUser, string code)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(IIdentityUser user, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(IIdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        public Task<string> GenerateEmailConfirmationTokenAsync(IIdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        public Task<string> GeneratePasswordResetTokenAsync(IIdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsEmailConfirmedAsync(IIdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> ResetPasswordAsync(IIdentityUser identityUser, string code, string password)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(IIdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        Task<IIdentityUser> IUserManager.FindByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        Task<IIdentityUser> IUserManager.FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
    }
}
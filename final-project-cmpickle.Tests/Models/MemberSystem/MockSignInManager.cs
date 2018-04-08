// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using final_project_cmpickle.Models.MemberSystem;
// using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.Extensions.Logging;
// using Microsoft.Extensions.Options;

// namespace Tests.Models.MemberSystem
// {
//     public class MockSignInManager<TUser> : ISignInManager<TUser>, IDisposable where TUser : MyIdentityUser
//     {
//         public MockSignInManager() 
//         {
//         }

//         public Task SignInAsync(TUser user, bool isPersistent)
//         {
//             return new Task(null);
//         }

//         override public Task<TUser> GetTwoFactorAuthenticationUserAsync()
//         {
//             return new Task<TUser>(null);
//         }

//         override public Task SignOutAsync()
//         {
//             Task task = new Task(null);
//             return task;
//         }

//         override public Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync()
//         {
//             Task task = new Task<IEnumerable<AuthenticationScheme>>(null);
//             return (Task<IEnumerable<AuthenticationScheme>>)task;
//         }

//         public void Dispose()
//         {
            
//         }
//     }
// }
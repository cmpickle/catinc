using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MyIdentityUser : IdentityUser, IIdentityUser
    {
      public MyIdentityUser(string name): base(name) {}

        string IIdentityUser.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        IIdentityUser IIdentityUser.Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
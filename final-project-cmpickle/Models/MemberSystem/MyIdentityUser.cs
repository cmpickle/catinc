using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MyIdentityUser : IdentityUser, IMyIdentityUser
    {
      public MyIdentityUser(string name): base(name) {}

        int IMyIdentityUser.Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IIdentityUser Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
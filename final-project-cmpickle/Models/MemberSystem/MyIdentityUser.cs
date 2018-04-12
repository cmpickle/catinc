using System;
using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MyIdentityUser : IdentityUser, IIdentityUser
    {
        public MyIdentityUser(): base() {}

        public MyIdentityUser(string name): base(name) {}

        override public string Id { get => base.Id; set => base.Id = Id; }

        public IIdentityUser Create()
        {
            throw new System.NotImplementedException();
        }
    }
}
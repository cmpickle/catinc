using System;

namespace final_project_cmpickle.Models.MemberSystem
{
    public interface IIdentityUser
    {
        string Id { get; set; }
        IIdentityUser Create();
    }
}
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace catinc.Models.Domain
{
    public class MyIdentityUser : IdentityUser, IIdentityUser
    {
        public MyIdentityUser(): base() 
        {
            var id = Guid.NewGuid().ToString();
            Id = id;
        }

        public MyIdentityUser(string name): base(name) {}

        override public string Id { get; set; }

        public List<VendorUser> VendorUsers { get; set; }

        public IIdentityUser Create()
        {
            this.Id = new Guid().ToString();
            return this;
        }
    }
}
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace catinc.Models.Domain
{
    
    public class MyIdentityUser : IdentityUser, IIdentityUser
    {
        override public string Id { get; set; }

        public Permission Permission { get; set; }
        public Loyalty Loyalty { get; set; }
        public List<Orders> Orders { get; set; }
        public Log Log { get; set; }
        public Patron Patron { get; set; }
        public List<VendorUser> VendorUsers { get; set; }

        public MyIdentityUser(): base() 
        {
            var id = Guid.NewGuid().ToString();
            Id = id;
        }

        public MyIdentityUser(string name): base(name) {}

        public IIdentityUser Create()
        {
            this.Id = new Guid().ToString();
            return this;
        }
    }
}
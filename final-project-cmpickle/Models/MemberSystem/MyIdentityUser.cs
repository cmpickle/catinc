using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using final_project_cmpickle.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace final_project_cmpickle.Models.MemberSystem
{
    public class MyIdentityUser : IdentityUser, IIdentityUser
    {
        public MyIdentityUser(): base() 
        {
            var id = Guid.NewGuid().ToString();
            Id = id;
        }

        public MyIdentityUser(string name): base(name) {}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        override public string Id { get; set; }

        public List<VendorUser> VendorUsers { get; set; }

        public IIdentityUser Create()
        {
            this.Id = new Guid().ToString();
            return this;
        }
    }
}
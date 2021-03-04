using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebShop.Model
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Roles = new HashSet<Role>();
        }
        public string Password { get; set; }
        public ICollection<ProofOfPurchase> ProofsOfPurchase { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}

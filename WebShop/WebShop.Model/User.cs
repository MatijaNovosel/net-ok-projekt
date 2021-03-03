using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Vjezba.Model
{
    public class User
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }

        [Key] 
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<ProofOfPurchase> ProofsOfPurchase { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}

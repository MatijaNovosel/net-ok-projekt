using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WebShop.Model
{
    public class Role
    {
        public Role()
        {
            AppUsers = new HashSet<AppUser>();
        }

        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AppUser> AppUsers { get; set; }
    }
}

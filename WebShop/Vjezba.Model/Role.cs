using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Vjezba.Model
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        [Key] 
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}

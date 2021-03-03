using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vjezba.Model
{
    public class Item
    {
        public Item()
        {
            Tags = new HashSet<Tag>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }
    }
}

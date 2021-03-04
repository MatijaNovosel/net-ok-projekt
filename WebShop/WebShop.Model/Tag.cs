using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Model
{
    public class Tag
    {
        public Tag()
        {
            Items = new HashSet<Item>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}

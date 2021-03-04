using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebShop.Model
{
    public class Item
    {
        public Item()
        {
            Tags = new HashSet<Tag>();
            ProofsOfPurchase = new HashSet<ProofOfPurchase>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime MadeAt { get; set; }
        public double Discount { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<ProofOfPurchase> ProofsOfPurchase { get; set; }
    }
}

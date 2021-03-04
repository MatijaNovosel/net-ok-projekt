using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Web.Models.DTO
{
    public class CreateItemDto
    {
        [Required]
        [MinLength(4)]
        public string Name { get; set; }
        [Required]
        [MinLength(4)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTime MadeAt { get; set; }
        public double Discount { get; set; }
        [Required]
        public virtual List<int> TagIds { get; set; }
    }
}

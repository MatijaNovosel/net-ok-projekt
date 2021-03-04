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
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public DateTime MadeAt { get; set; }
        public double Discount { get; set; }
        [Required]
        [Range(minimum: 1, maximum: Int32.MaxValue, ErrorMessage = "At least one item needs to be selected")]
        public virtual List<int> TagIds { get; set; }
    }
}

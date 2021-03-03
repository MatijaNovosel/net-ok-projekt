using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Web.Models.DTO
{
    public class CreateItemDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime MadeAt { get; set; }
        public double Discount { get; set; }
        public virtual List<int> TagIds { get; set; }
    }
}

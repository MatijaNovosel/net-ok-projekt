using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShop.Web.Models.DTO
{
    public class UpdateItemDto : CreateItemDto
    {
        public int? Id { get; set; }
    }
}

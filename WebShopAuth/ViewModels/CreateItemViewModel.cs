using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;
using WebShop.Web.Models;
using WebShop.Web.Models.DTO;

namespace WebShop.Web.ViewModels
{
    public class CreateItemViewModel
    {
        public UpdateItemDto Item { get; set; }
        public List<SelectListItem> TagSelect { get; set; }
    }
}

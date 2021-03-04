using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;
using WebShop.Web.Models;

namespace WebShop.Web.ViewModels
{
    public class ItemsGridViewModel
    {
        public List<Item> Items { get; set; }
        public List<SelectListItem> TagSelect { get; set; }
        public ItemSearchModel Search { get; set; }
    }
}

using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vjezba.Model;

namespace WebShop.Web.TagHelpers
{
    [HtmlTargetElement("item-card", Attributes = "item")]
    public class ItemCardTagHelper : TagHelper
    {
        public Item Item { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "item-card shadow-sm border-shaded rounded-lg d-flex flex-column align-items-center");
            output.Content.SetHtmlContent(Content());
        }

        private string Content()
        {
            return $@"
                <img src='https://images-na.ssl-images-amazon.com/images/I/81V3y%2BfKGQL._SL1500_.jpg' width='125' height='125' alt='' />
                <h5 class='mt-4 align-self-start'>{Item.Name}</h5>
                <span class='align-self-start'>{Item.Description}</span>
                <div class='d-flex justify-content-end w-100 mt-4'>
                    <a href='/Items/{Item.Id}'> 
                        <button type='button' class='btn btn-outline-primary'>Detalji</button>
                    </a>
                </div>
            ";
        }
    }
}

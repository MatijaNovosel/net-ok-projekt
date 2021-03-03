using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vjezba.Model;

namespace WebShop.Web.TagHelpers
{
    [HtmlTargetElement("item-card", Attributes = "item")]
    [RestrictChildren("tag-pill-collection")]
    public class ItemCardTagHelper : TagHelper
    {
        public Item Item { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "item-card shadow-sm border-shaded rounded-lg d-flex flex-column align-items-center shrink cursor-pointer select-none");
            output.Attributes.Add("id", Item.Id);
            output.PreContent.SetHtmlContent(Content());
            output.Content.SetHtmlContent(await output.GetChildContentAsync());
        }

        private string Content()
        {
            return $@"
                <h5 class='align-self-start'>{Item.Name}</h5>
                <span class='align-self-start'>{Item.Description}</span>
                <span class='align-self-start'>{Item.Price - Item.Price * Item.Discount / 100} HRK</span>
            ";
        }
    }
}

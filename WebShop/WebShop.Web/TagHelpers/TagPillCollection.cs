using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;

namespace WebShop.Web.TagHelpers
{
    [HtmlTargetElement("tag-pill-collection", ParentTag = "item-card")]
    public class TagPillCollectionTagHelper : TagHelper
    {
        [HtmlAttributeName("text-collection")]
        public List<string> TextCollection { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "d-flex mt-3");
            output.Content.SetHtmlContent(Content());
        }

        private string Content()
        {
            string output = "";

            foreach (var text in TextCollection)
            {
                output += @$"<div class='px-3 py-1 pill-bg rounded-pill mr-3'>{text}</div>";
            }

            return output;
        }
    }
}
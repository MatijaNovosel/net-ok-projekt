using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShop.Model;

namespace WebShop.Web.TagHelpers
{
    [HtmlTargetElement("app-footer")]
    public class FooterTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "footer";
            output.Attributes.Add("class", "border-top footer text-muted");
            output.Content.SetHtmlContent(Content());
        }

        private string Content()
        {
            return $@"
                <div class='container'>
                    &copy; 2021 - WebShop
                </div>
            ";
        }
    }
}

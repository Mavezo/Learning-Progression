using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP.NET_MVC_9.TagHelpers
{
	[HtmlTargetElement("customtag")]
	public class CustomFilterTagHelper : TagHelper
    {
        private readonly IUrlHelperFactory factory;

        public string Action { get; set; }
        public string BreedName { get; set; }

        public CustomFilterTagHelper(IUrlHelperFactory factory)
        {
            this.factory = factory;
        }
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = factory.GetUrlHelper(ViewContext);
            output.TagName = "a";
            string url = urlHelper.Action(Action, new { BreedName });
            output.Attributes.SetAttribute("href", url);

        }


    }
}

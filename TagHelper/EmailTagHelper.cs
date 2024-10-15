using Microsoft.AspNetCore.Razor.TagHelpers;

namespace site2024.TagHelps
{
    public class EmailTagHelper : TagHelper
    {
        public string EmailAdress { get; set; }
        public string EmailContent { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto" + EmailAdress);
            output.Content.SetContent(EmailContent);
        }

    }
}

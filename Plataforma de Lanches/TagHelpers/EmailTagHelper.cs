using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Plataforma_de_Lanches.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Email { get; set; }
        public string Conteudo { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", $"mailto:{Email}");
            output.Content.SetContent(Conteudo); 
        }
    }
}

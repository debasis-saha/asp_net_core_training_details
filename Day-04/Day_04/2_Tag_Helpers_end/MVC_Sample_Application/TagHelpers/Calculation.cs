using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Sample_Application.TagHelpers
{
    [HtmlTargetElement("calculation", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class CalculationTag : TagHelper
    {
        [HtmlAttributeName("a")]
        public double num1 { get; set; }

        [HtmlAttributeName("b")]
        public double num2 { get; set; }

        [HtmlAttributeName("operator")]
        public Operator Operator { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "";
            if (Operator == Operator.Add)
            {
                output.Content.SetHtmlContent((num1 + num2).ToString());
            }
            else if (Operator == Operator.Sub)
            {
                output.Content.SetHtmlContent((num1 - num2).ToString());
            }
            else if (Operator == Operator.Mul)
            {
                output.Content.SetHtmlContent((num1 * num2).ToString());
            }
            else
            {
                output.Content.SetHtmlContent((num1 / num2).ToString());
            }

        }
    }

    public enum Operator
    {
        Add, Sub, Mul, Div
    }
}

#pragma checksum "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bee41c91bae570b13adbbe7704f3f8d8bf0a5ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Day3_BasicPage), @"mvc.1.0.view", @"/Views/Day3/BasicPage.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\_ViewImports.cshtml"
using MVC_Sample_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\_ViewImports.cshtml"
using MVC_Sample_Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\_ViewImports.cshtml"
using MVC_Sample_Application.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bee41c91bae570b13adbbe7704f3f8d8bf0a5ba", @"/Views/Day3/BasicPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdad7fb57c0ba34a0d67acb4c51e16b910a92428", @"/Views/_ViewImports.cshtml")]
    public class Views_Day3_BasicPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
  
    var date = DateTime.Now.ToShortDateString();
    var message = "Hello World";

    var date1 = DateTime.Now.ToShortDateString();
    string message1 = "Hello Asp.Net Core!";

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Today\'s date is: ");
#nullable restore
#line 7 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
                  Write(date1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n");
#nullable restore
#line 9 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
Write(message1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>Basic Razor Page Examples</h2>\r\n\r\n    <h2>");
#nullable restore
#line 15 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
   Write(DateTime.Now.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n\r\n    <h2>Today\'s date is: ");
#nullable restore
#line 18 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
                    Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    <h3>");
#nullable restore
#line 19 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
   Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n\r\n<h5>");
#nullable restore
#line 23 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day3\BasicPage.cshtml"
Write(Html.ActionLink("Back to Day 3 Home", "Index", "Day3"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

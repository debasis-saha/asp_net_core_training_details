#pragma checksum "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "982e9543d330a82bdfa0eb9698026c0ad8acde5e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Day6_Index), @"mvc.1.0.view", @"/Views/Day6/Index.cshtml")]
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
#nullable restore
#line 4 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\_ViewImports.cshtml"
using MVC_Sample_Application.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"982e9543d330a82bdfa0eb9698026c0ad8acde5e", @"/Views/Day6/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d93070e34596b889ad0abfb72e9b63b320c2e69f", @"/Views/_ViewImports.cshtml")]
    public class Views_Day6_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\Index.cshtml"
  
    ViewData["Title"] = "Day 6 Index Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>Display the Examples of Day 6</h2>\r\n    <ul>\r\n        <li>");
#nullable restore
#line 8 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\Index.cshtml"
       Write(Html.ActionLink("View Model", "ViewModel", "Day6"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>");
#nullable restore
#line 9 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\Index.cshtml"
       Write(Html.ActionLink("Explicit Server Validation", "ExplicitServer", "Day6"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n    </ul>\r\n</div>");
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
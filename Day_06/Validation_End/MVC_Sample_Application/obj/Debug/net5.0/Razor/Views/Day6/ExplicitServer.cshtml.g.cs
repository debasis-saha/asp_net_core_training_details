#pragma checksum "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce49e6e8a33cf3ac306492f0b5aeddf6d4a2c137"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Day6_ExplicitServer), @"mvc.1.0.view", @"/Views/Day6/ExplicitServer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce49e6e8a33cf3ac306492f0b5aeddf6d4a2c137", @"/Views/Day6/ExplicitServer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d93070e34596b889ad0abfb72e9b63b320c2e69f", @"/Views/_ViewImports.cshtml")]
    public class Views_Day6_ExplicitServer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegistrationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
  
    ViewData["Title"] = "Explicit Server Validation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script");
            BeginWriteAttribute("src", " src=\"", 99, "\"", 152, 1);
#nullable restore
#line 7 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
WriteAttributeValue("", 105, Url.Content("~/lib/jquery/dist/jquery.min.js"), 105, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text/javascript\"></script>\r\n\r\n<div class=\"text-left\">\r\n    <h2>Explicit Server Validation</h2>\r\n");
#nullable restore
#line 11 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <fieldset>\r\n            <ol>\r\n                <li>\r\n                    ");
#nullable restore
#line 16 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 17 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.TextBoxFor(m => m.UserName, new { maxlength = 50 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 18 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.ValidationMessageFor(m => m.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 21 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 22 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.PasswordFor(m => m.Password, new { maxlength = 50, value = ViewBag.Selpwd }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 26 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.LabelFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 27 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.PasswordFor(m => m.ConfirmPassword, new { maxlength = 50, value = ViewBag.Selconfirmpwd }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.ValidationMessageFor(m => m.ConfirmPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 31 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.LabelFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.TextAreaFor(m => m.Address, new { maxlength = 200 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 33 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.ValidationMessageFor(m => m.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 36 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.LabelFor(m => m.MobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 37 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.TextBoxFor(m => m.MobileNo, new { maxlength = 10 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 38 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.ValidationMessageFor(m => m.MobileNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    ");
#nullable restore
#line 41 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.CheckBoxFor(m => m.TermsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral(" I accept the terms & conditions\r\n                    ");
#nullable restore
#line 42 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
               Write(Html.ValidationMessageFor(m => m.TermsAccepted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            </ol>\r\n            <input type=\"submit\" value=\"Submit\" />\r\n        </fieldset>\r\n");
#nullable restore
#line 47 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<h5>");
#nullable restore
#line 50 "D:\Personal_Code_work\demo_work\MVC_Sample_Application\MVC_Sample_Application\Views\Day6\ExplicitServer.cshtml"
Write(Html.ActionLink("Back to Day 6 Home", "Index", "Day6"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistrationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

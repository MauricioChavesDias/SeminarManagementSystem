#pragma checksum "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b96bb8539d0799bd982b3721c3064470a536c6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
using SeminarManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
using SeminarManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b96bb8539d0799bd982b3721c3064470a536c6b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abaa12ea07c7a56f38d5931fbcad96dcb6ca3fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center card\">\n    <div class=\"container my-2\">\n");
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 184, "\"", 230, 1);
#nullable restore
#line 8 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Home/Index.cshtml"
WriteAttributeValue("", 190, Url.Content("~/Image/seminar_logo.png"), 190, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500\" height=\"500\" class=\"d-inline-block align-top\"");
            BeginWriteAttribute("alt", " alt=\"", 289, "\"", 295, 0);
            EndWriteAttribute();
            WriteLiteral(">\n\n\n        <h4 class=\"text-left text-secondary\">Developed by:</h4>\n\n        <table id=\"students\"");
            BeginWriteAttribute("class", " class=\"", 393, "\"", 401, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <thead>
                <tr>
                    <th>Students Name</th>
                    <th>Student ID</th>
                </tr>
            </thead>
            <tr>
                <td> Josefa Juliana Costa Santana</td>
                <td> 12001814 </td>
            </tr>
            <tr>
                <td> Diogo Felipe Poletti</td>
                <td> 12001683 </td>
            </tr>
            <tr>
                <td> Mauricio Chaves Dias</td>
                <td> 12001727 </td>
            </tr>

        </table>
    </div>
</div>");
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

#pragma checksum "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "213fdc94e286343681144aa27a3b99fe5e2ffb5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Seminar_Index), @"mvc.1.0.view", @"/Views/Seminar/Index.cshtml")]
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
#line 1 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\_ViewImports.cshtml"
using SeminarManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\_ViewImports.cshtml"
using SeminarManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213fdc94e286343681144aa27a3b99fe5e2ffb5d", @"/Views/Seminar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18d34547411ec16fcaf8c8ed83d8efe28f3c9166", @"/Views/_ViewImports.cshtml")]
    public class Views_Seminar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SeminarManagementSystem.Models.Seminar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
  
    ViewData["Title"] = "Seminar";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n\r\n            <div class=\"row card-header align-card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 263, "\"", 315, 1);
#nullable restore
#line 11 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 269, Url.Content("~/Image/icons/seminar_icon.png"), 269, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" width=""60"" height=""60"">
                <h1 class=""header-title mt-2"">Seminar</h1>
            </div>

            <table id=""grid"" class=""table"">
                <thead class=""thead-dark"">
                    <tr>
                        <th scope=""col"">
                            ");
#nullable restore
#line 19 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.organiser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
#nullable restore
#line 22 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.typeSeminar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
#nullable restore
#line 25 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.seminar_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th scope=\"col\">\r\n                            ");
#nullable restore
#line 28 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                       Write(Html.DisplayNameFor(model => model.seminar_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n\r\n                        <th scope=\"col\">Options</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 39 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.organiser.organiser_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 42 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.typeSeminar.typeSeminar_Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 45 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.seminar_title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 48 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.seminar_description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213fdc94e286343681144aa27a3b99fe5e2ffb5d9027", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                                                       WriteLiteral(item.seminarID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213fdc94e286343681144aa27a3b99fe5e2ffb5d11254", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                                                          WriteLiteral(item.seminarID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "213fdc94e286343681144aa27a3b99fe5e2ffb5d13488", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                                                         WriteLiteral(item.seminarID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </tbody>
            </table>
            <div class=""container d-flex flex-column col-md-8"" id=""create-button"">

                <div class=""row flex-column"">
                    <button type=""button""
                            class=""col-4 align-self-end btn btn-primary btn-lg""
                            value=""Create""");
            BeginWriteAttribute("onclick", "\r\n                            onclick=\"", 2795, "\"", 2882, 3);
            WriteAttributeValue("", 2834, "location.href=\'", 2834, 15, true);
#nullable restore
#line 65 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 2849, Url.Action("Create", "Seminar"), 2849, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2881, "\'", 2881, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2914, "\"", 2956, 1);
#nullable restore
#line 66 "C:\Users\diogo\source\repos\SeminarManagementSystem\SeminarManagementSystem\Views\Seminar\Index.cshtml"
WriteAttributeValue("", 2920, Url.Content("~/Image/new_icon.png"), 2920, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"25\" height=\"25\" >\r\n                        New Seminar\r\n                    </button>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SeminarManagementSystem.Models.Seminar>> Html { get; private set; }
    }
}
#pragma warning restore 1591

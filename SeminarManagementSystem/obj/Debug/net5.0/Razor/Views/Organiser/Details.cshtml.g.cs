<<<<<<< Updated upstream
#pragma checksum "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81c0b8ee5447b8734b7fe9360cc5b0b6c88bc512"
=======
#pragma checksum "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a825cc59fc64309c18cfc663577c0e40aad8bfe9"
>>>>>>> Stashed changes
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Organiser_Details), @"mvc.1.0.view", @"/Views/Organiser/Details.cshtml")]
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
<<<<<<< Updated upstream
#line 1 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
=======
#line 1 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
>>>>>>> Stashed changes
using SeminarManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< Updated upstream
#line 2 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
=======
#line 2 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/_ViewImports.cshtml"
>>>>>>> Stashed changes
using SeminarManagementSystem.Models;

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81c0b8ee5447b8734b7fe9360cc5b0b6c88bc512", @"/Views/Organiser/Details.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a825cc59fc64309c18cfc663577c0e40aad8bfe9", @"/Views/Organiser/Details.cshtml")]
>>>>>>> Stashed changes
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abaa12ea07c7a56f38d5931fbcad96dcb6ca3fd2", @"/Views/_ViewImports.cshtml")]
    public class Views_Organiser_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SeminarManagementSystem.Models.Organiser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
<<<<<<< Updated upstream
#line 3 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
=======
#line 3 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
>>>>>>> Stashed changes
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Organiser</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 14 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
=======
#line 14 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayNameFor(model => model.organiser_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 17 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
=======
#line 17 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayFor(model => model.organiser_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 20 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
=======
#line 20 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayNameFor(model => model.organiser_DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
<<<<<<< Updated upstream
#line 23 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
=======
#line 23 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
>>>>>>> Stashed changes
       Write(Html.DisplayFor(model => model.organiser_DOB));

#line default
#line hidden
#nullable disable
<<<<<<< Updated upstream
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c0b8ee5447b8734b7fe9360cc5b0b6c88bc5125543", async() => {
=======
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a825cc59fc64309c18cfc663577c0e40aad8bfe95535", async() => {
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
#line 28 "/Users/mauriciodias/Projects/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
=======
#line 28 "/Users/jc/Projects/KOIDevelopment/SeminarManagementSystem/SeminarManagementSystem/Views/Organiser/Details.cshtml"
>>>>>>> Stashed changes
                           WriteLiteral(Model.organiserID);

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
<<<<<<< Updated upstream
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81c0b8ee5447b8734b7fe9360cc5b0b6c88bc5127691", async() => {
=======
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a825cc59fc64309c18cfc663577c0e40aad8bfe97686", async() => {
>>>>>>> Stashed changes
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SeminarManagementSystem.Models.Organiser> Html { get; private set; }
    }
}
#pragma warning restore 1591

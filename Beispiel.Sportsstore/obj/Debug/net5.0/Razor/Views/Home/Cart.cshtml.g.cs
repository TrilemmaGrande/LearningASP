#pragma checksum "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00f39672d31b61b377473b518aa6b04a07677fc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cart), @"mvc.1.0.view", @"/Views/Home/Cart.cshtml")]
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
#line 1 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\_ViewImports.cshtml"
using Beispiel.Sportsstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\_ViewImports.cshtml"
using Beispiel.Sportsstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\_ViewImports.cshtml"
using Beispiel.Sportsstore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00f39672d31b61b377473b518aa6b04a07677fc3", @"/Views/Home/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e9e25cdc62d28484f284217fc632cee056e593", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveLine", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
  
    Layout = "_CartLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Shopping Cart</h4>
<table class=""table table-bordered table-hover"">
    <thead >
        <tr>
            <th>Quantity</th>
            <th>Item</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">");
#nullable restore
#line 20 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
                               Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
#nullable restore
#line 21 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
                               Write(line.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 22 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
                              Write(line.Product.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 23 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
                               Write((line.Quantity * line.Product.Price).ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"text-center\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00f39672d31b61b377473b518aa6b04a07677fc36454", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"ReturnUrl\"");
                BeginWriteAttribute("value", " value=\"", 878, "\"", 902, 1);
#nullable restore
#line 26 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 886, Model.ReturnUrl, 886, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <input type=\"hidden\" name=\"ProductID\"");
                BeginWriteAttribute("value", " value=\"", 965, "\"", 996, 1);
#nullable restore
#line 27 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 973, line.Product.ProductID, 973, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-danger\">-</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <td colspan=\"3\" class=\"text-right\">Total:</td>\r\n            <td class=\"text-right\">");
#nullable restore
#line 37 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
                              Write(Model.Cart.ComputeTotalValue().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n<div class=\"text-center\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1409, "\"", 1432, 1);
#nullable restore
#line 42 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.Sportsstore\Views\Home\Cart.cshtml"
WriteAttributeValue("", 1416, Model.ReturnUrl, 1416, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\">Continue Shopping</a>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

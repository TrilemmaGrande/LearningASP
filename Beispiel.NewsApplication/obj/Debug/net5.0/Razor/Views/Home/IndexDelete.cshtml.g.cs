#pragma checksum "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38b7dc62b5c8ae78931eb05daa84e66fa7d17bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_IndexDelete), @"mvc.1.0.view", @"/Views/Home/IndexDelete.cshtml")]
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
#line 1 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\_ViewImports.cshtml"
using Beispiel.NewsApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\_ViewImports.cshtml"
using Beispiel.NewsApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38b7dc62b5c8ae78931eb05daa84e66fa7d17bd", @"/Views/Home/IndexDelete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fb7fe4e84d02617a8764a310b9100b9222d05b5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_IndexDelete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteArticle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration-none text-reset"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
  
    ViewData["Title"] = "Artikel Löschen";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    h1{\r\n        opacity:0.5;\r\n    }\r\n    .card:hover {\r\n        transform: scale(1.025);\r\n        box-shadow: 0 10px 20px rgba(0,0,0,.12), 0 4px 8px rgba(0,0,0,.06);\r\n        background-color: #fee;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 16 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
 if (Model.TopArticle != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"bg-dark text-white text-center opacity-50 my-2\">Top News</h3>\r\n    <div class=\"my-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38b7dc62b5c8ae78931eb05daa84e66fa7d17bd5491", async() => {
                WriteLiteral("\r\n            <div class=\"card opacity-50\">\r\n                <div class=\"card-header fw-bold\">\r\n                    ");
#nullable restore
#line 23 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
               Write(Model.TopArticle.Headline);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <img");
                BeginWriteAttribute("src", " src=\"", 787, "\"", 825, 2);
                WriteAttributeValue("", 793, "/img/", 793, 5, true);
#nullable restore
#line 26 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
WriteAttributeValue("", 798, Model.TopArticle.ImageFile, 798, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Hier ist ein Bild\" class=\"img-fluid\" />\r\n");
#nullable restore
#line 27 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                     if (Model.TopArticle.Content.Length > 100)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                   Write(Model.TopArticle.Content.Substring(0, 100));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                WriteLiteral("...\r\n");
#nullable restore
#line 30 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                   Write(Model.TopArticle.Content);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                                                 
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"card-footer\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
               Write(Model.TopArticle.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 37 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                                          Write(Model.TopArticle.Created.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        ");
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
#line 20 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                                        WriteLiteral(Model.TopArticle.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"bg-dark text-white text-center mt-2 opacity-50 my-2\">Weitere News</h3>\r\n<div class=\"row my-2\">\r\n");
#nullable restore
#line 46 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
     foreach (var item in Model.Articles)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-xl-3 col-md-4 col-sm-6 my-1\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38b7dc62b5c8ae78931eb05daa84e66fa7d17bd11849", async() => {
                WriteLiteral("\r\n                <div class=\"card h-100 opacity-50\">\r\n                    <div class=\"card-header fw-bold\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                   Write(item.Headline);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1987, "\"", 2013, 2);
                WriteAttributeValue("", 1993, "/img/", 1993, 5, true);
#nullable restore
#line 55 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
WriteAttributeValue("", 1998, item.ImageFile, 1998, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Hier ist ein Bild\" class=\"img-fluid\" />\r\n");
#nullable restore
#line 56 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                         if (item.Content.Length > 100)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                       Write(item.Content.Substring(0, 100));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
                WriteLiteral("...\r\n");
#nullable restore
#line 59 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                       Write(item.Content);

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                                         
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                    <div class=\"card-footer\">\r\n                        ");
#nullable restore
#line 66 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                   Write(item.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | ");
#nullable restore
#line 66 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                                  Write(item.Created.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            ");
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
#line 49 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 71 "C:\Users\Nils Reinshagen\source\repos\TrilemmaGrande\LearningASP\Beispiel.NewsApplication\Views\Home\IndexDelete.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38b7dc62b5c8ae78931eb05daa84e66fa7d17bd17754", async() => {
                WriteLiteral("Zurück");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

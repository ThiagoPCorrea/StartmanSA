#pragma checksum "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65de261c72388207d94e2b039cd93c46b33f9429"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Materiaprima_Details), @"mvc.1.0.view", @"/Views/Materiaprima/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Materiaprima/Details.cshtml", typeof(AspNetCore.Views_Materiaprima_Details))]
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
#line 1 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\_ViewImports.cshtml"
using StartmanSA;

#line default
#line hidden
#line 2 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\_ViewImports.cshtml"
using StartmanSA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65de261c72388207d94e2b039cd93c46b33f9429", @"/Views/Materiaprima/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49909953d9a8493b7ee36b080e5f396df4914980", @"/Views/_ViewImports.cshtml")]
    public class Views_Materiaprima_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StartmanSA.Models.Materiaprima>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 138, true);
            WriteLiteral("\r\n<h1>Detalhes</h1>\r\n\r\n<div>\r\n    <h4>Matéria-Prima</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(223, 40, false);
#line 14 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(263, 64, true);
            WriteLiteral(":\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(328, 36, false);
#line 17 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(364, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(428, 53, false);
#line 20 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(481, 64, true);
            WriteLiteral(":\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(546, 49, false);
#line 23 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantidadeEstoque));

#line default
#line hidden
            EndContext();
            BeginContext(595, 63, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(659, 56, false);
#line 26 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantidadeEstoqueMax));

#line default
#line hidden
            EndContext();
            BeginContext(715, 64, true);
            WriteLiteral(":\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(780, 52, false);
#line 29 "C:\Users\thiag\Documents\GitHub\StartmanSA\StartmanSA\StartmanSA\Views\Materiaprima\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantidadeEstoqueMax));

#line default
#line hidden
            EndContext();
            BeginContext(832, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(879, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65de261c72388207d94e2b039cd93c46b33f94296707", async() => {
                BeginContext(901, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(911, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StartmanSA.Models.Materiaprima> Html { get; private set; }
    }
}
#pragma warning restore 1591

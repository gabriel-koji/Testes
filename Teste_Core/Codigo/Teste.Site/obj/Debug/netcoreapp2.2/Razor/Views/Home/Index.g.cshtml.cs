#pragma checksum "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b58500dbb762eb9b3b2d5136d4c6bee24357c5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\_ViewImports.cshtml"
using Teste_Teste;

#line default
#line hidden
#line 2 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\_ViewImports.cshtml"
using Teste_Teste.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b58500dbb762eb9b3b2d5136d4c6bee24357c5d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e8b0ef03b69e5aaf961458894ca2951047b3a29", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teste_Teste.Models.NumeroModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Números Estranhos";

#line default
#line hidden
            BeginContext(92, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(96, 1430, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b58500dbb762eb9b3b2d5136d4c6bee24357c5d4851", async() => {
                BeginContext(176, 238, true);
                WriteLiteral("\r\n        <div class=\"text-center\">\r\n            <h1 class=\"display-4\">Teste de Números Estranhos</h1>\r\n        </div>\r\n        <div class=\"text-center\">\r\n            <br />\r\n            <br />\r\n            <span> Digite o número:</span> ");
                EndContext();
                BeginContext(415, 80, false);
#line 12 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                                      Write(Html.TextBoxFor(model => model.Numero, htmlAttributes: new { @type = "number" }));

#line default
#line hidden
                EndContext();
                BeginContext(495, 111, true);
                WriteLiteral("\r\n            <button type=\"submit\">Verificar Número</button>\r\n        </div>\r\n        <br />\r\n        <br />\r\n");
                EndContext();
#line 17 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
         if (Model.Retorno != null)
        {

#line default
#line hidden
                BeginContext(654, 75, true);
                WriteLiteral("            <div class=\"text-center\">\r\n                <h3>Resultado</h3>\r\n");
                EndContext();
#line 21 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                 if (Model.Retorno.NumeroEstranho)
                {
                    

#line default
#line hidden
                BeginContext(821, 37, false);
#line 23 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
               Write(Html.Raw("Número Estranho - Soma = "));

#line default
#line hidden
                EndContext();
#line 23 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                                                          ;
                }
                else
                {
                    

#line default
#line hidden
                BeginContext(942, 41, false);
#line 27 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
               Write(Html.Raw("Número não Estranho - Soma = "));

#line default
#line hidden
                EndContext();
#line 27 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                                                              ;
                }

#line default
#line hidden
                BeginContext(1005, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(1024, 38, false);
#line 30 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
           Write(Html.Raw(Model.Retorno.Total + " // "));

#line default
#line hidden
                EndContext();
                BeginContext(1062, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 32 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                 for (int i = 0; i < Model.Retorno.Lista.Count; i++)
                {
                    if (i < Model.Retorno.Lista.Count - 1)
                    {
                        

#line default
#line hidden
                BeginContext(1263, 40, false);
#line 36 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Retorno.Lista[i] + " - "));

#line default
#line hidden
                EndContext();
#line 36 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                                                                 ;
                    }
                    else
                    {
                        

#line default
#line hidden
                BeginContext(1403, 32, false);
#line 40 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.Retorno.Lista[i]));

#line default
#line hidden
                EndContext();
#line 40 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
                                                         ;
                    }

                }

#line default
#line hidden
                BeginContext(1482, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 46 "C:\Users\gabriel.koji\source\repos\Teste_Core\Codigo\Teste.Site\Views\Home\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(1515, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1526, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teste_Teste.Models.NumeroModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db098c6d60d2e3de26fdc63d5e25ea9cf07b88f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_wa_Alocar), @"mvc.1.0.view", @"/Views/wa/Alocar.cshtml")]
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
#line 1 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\_ViewImports.cshtml"
using desafio_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\_ViewImports.cshtml"
using desafio_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db098c6d60d2e3de26fdc63d5e25ea9cf07b88f8", @"/Views/wa/Alocar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18134b6d419e4d0cae9dbf370c9501faae761e2", @"/Views/_ViewImports.cshtml")]
    public class Views_wa_Alocar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<desafio_mvc.Models.Alocar>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sugestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Alocacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dispensar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2 class=\"text-center\">Sugestões de Alocação</h2>\r\n<hr>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db098c6d60d2e3de26fdc63d5e25ea9cf07b88f85454", async() => {
                WriteLiteral("Gerar sugestões");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br>\r\n<br>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
 foreach (var alo in Model)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
   if(alo.FuncionarioID.Status == true)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"jumbotron\">\r\n");
            WriteLiteral("      <div class=\"row\">\r\n        <div class=\"col-sm-6\"> \r\n          <h1>");
#nullable restore
#line 18 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
         Write(alo.FuncionarioID.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n          <p class=\"lead\">Cargo: ");
#nullable restore
#line 19 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                            Write(alo.FuncionarioID.Cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 19 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                                                       Write(alo.FuncionarioID.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          <p class=\"font-weight-bolder\">Principal Tecnologia: ");
#nullable restore
#line 20 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                                                               foreach (var tec in alo.FuncionarioID.FuncTecnologia.Select(t => t.Tecnologia))
              {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
           Write(tec.Nome);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                         
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </p>\r\n");
            WriteLiteral("          <p class=\"font-weight-lighter\">GFT Brasil></p>\r\n          <p class=\"font-weight-lighter\">Matricula: ");
#nullable restore
#line 27 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                                               Write(alo.FuncionarioID.Matricula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n          <br>\r\n          <a class=\"btn btn-dark col-sm-6\"");
            BeginWriteAttribute("href", " href=\"", 1072, "\"", 1122, 2);
            WriteAttributeValue("", 1079, "/wa/PerfilFuncionario/", 1079, 22, true);
#nullable restore
#line 29 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
WriteAttributeValue("", 1101, alo.FuncionarioID.Id, 1101, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Perfil</a>\r\n        </div>\r\n\r\n");
            WriteLiteral("        <div class=\"col-sm-6\">\r\n          <h1>");
#nullable restore
#line 34 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
         Write(alo.VagaID.Descricao_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("          <p class=\"font-weight-bolder\">Projeto: </p>\r\n          <p class=\"font-weight-bolder\">Principal Tecnologia: ");
#nullable restore
#line 37 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                                                               foreach (var tec in alo.VagaID.Tecnologias.Select(t => t.Tecnologia))
              {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
           Write(tec.Nome);

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                         
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </p>\r\n          <p class=\"font-weight-lighter\">Quantidade: ");
#nullable restore
#line 42 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                                                Write(alo.VagaID.Qtd_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral(" vagas</p>\r\n          <p class=\"font-weight-lighter\">Codigo da Vaga: ");
#nullable restore
#line 43 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
                                                    Write(alo.VagaID.Codigo_vaga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n      </div>\r\n      \r\n\r\n      <hr class=\"my-4\">\r\n      <div class=\"row\">\r\n          <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1921, "\"", 1957, 2);
            WriteAttributeValue("", 1928, "/wa/CadastrarAlocacao/", 1928, 22, true);
#nullable restore
#line 50 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
WriteAttributeValue("", 1950, alo.Id, 1950, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Alocar</a> \r\n          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db098c6d60d2e3de26fdc63d5e25ea9cf07b88f812964", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2114, "\"", 2129, 1);
#nullable restore
#line 52 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
WriteAttributeValue("", 2122, alo.Id, 2122, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <button class=\"btn btn-danger\">Dispensar</button>\r\n          ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      </div>\r\n     \r\n     \r\n    </div>\r\n");
#nullable restore
#line 59 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
  }
  else{

  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Alocar.cshtml"
   
  
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<desafio_mvc.Models.Alocar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
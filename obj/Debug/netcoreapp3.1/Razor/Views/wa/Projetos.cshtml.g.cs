#pragma checksum "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c222308d69f64669dec06b303a6acff3f252d103"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_wa_Projetos), @"mvc.1.0.view", @"/Views/wa/Projetos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c222308d69f64669dec06b303a6acff3f252d103", @"/Views/wa/Projetos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f18134b6d419e4d0cae9dbf370c9501faae761e2", @"/Views/_ViewImports.cshtml")]
    public class Views_wa_Projetos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<desafio_mvc.Models.Projeto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastrarProjeto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "wa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Vagas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Projeto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<script>
    $(document).ready( function () {
    $('#projetos').DataTable({
        ""language"": {
            ""lengthMenu"" : ""Mostrando _MENU_ registros por pagina"",
            ""zeroRecords"":  ""Nada encontrado, desculpa"",
            ""info"" : ""Mostrando pagina _PAGE_ de _PAGES_"",
            ""infoEmpty"" : ""Nenhum registro disponivel"",
            ""search"":   ""Buscar:"",
            ""paginate"": {
                ""first"":    ""Primeiro"",
                ""last"":     ""Ultimo"",
                ""next"":     ""Proximo"",
                ""previous"": ""Anterior""
            }
        }
    });
    });
</script>

<div class=""container-sm text-center"">
    <h2>Projetos cadastrados</h2>

    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c222308d69f64669dec06b303a6acff3f252d1037042", async() => {
                WriteLiteral("Cadastrar Projeto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c222308d69f64669dec06b303a6acff3f252d1038501", async() => {
                WriteLiteral("Vagas");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    \r\n    <hr/>\r\n\r\n");
#nullable restore
#line 48 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table id=\"projetos\" class=\"table table-striped table-bordered\">\r\n        <thead>\r\n            <tr>\r\n                <th>Nome </th>\r\n                <th>Ações</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 58 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
             foreach (var proj in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
                   Write(proj.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1674, "\"", 1707, 2);
            WriteAttributeValue("", 1681, "/wa/EditarProjeto/", 1681, 18, true);
#nullable restore
#line 62 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
WriteAttributeValue("", 1699, proj.Id, 1699, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Editar</a>\r\n                        \r\n                        <button class=\"btn btn-danger\" onclick=\"deleta()\">Deletar</button>\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c222308d69f64669dec06b303a6acff3f252d10311699", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2034, "\"", 2050, 1);
#nullable restore
#line 67 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
WriteAttributeValue("", 2042, proj.Id, 2042, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button id=deletar  type=\"hidden\" class=\"btn btn-danger\">Deletar</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 72 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 75 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
    }
    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Nenhum projeto encontrado</h1>\r\n");
#nullable restore
#line 78 "C:\Users\KYCS\OneDrive - GFT Technologies SE\Documents\desafio_mvc\Views\wa\Projetos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<desafio_mvc.Models.Projeto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

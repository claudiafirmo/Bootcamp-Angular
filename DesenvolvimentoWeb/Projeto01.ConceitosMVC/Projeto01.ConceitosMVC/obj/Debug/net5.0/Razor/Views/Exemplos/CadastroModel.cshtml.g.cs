#pragma checksum "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bad53a818c2864138e5bfd21e3f75e8e7e36e686"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exemplos_CadastroModel), @"mvc.1.0.view", @"/Views/Exemplos/CadastroModel.cshtml")]
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
#line 1 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\_ViewImports.cshtml"
using Projeto01.ConceitosMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\_ViewImports.cshtml"
using Projeto01.ConceitosMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bad53a818c2864138e5bfd21e3f75e8e7e36e686", @"/Views/Exemplos/CadastroModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb1a3d93f68b1bb76eb5ee043a695f50f153b577", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Exemplos_CadastroModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Produto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Cadastro de produtos - Model</h2>\r\n");
#nullable restore
#line 5 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
 using (Html.BeginForm("CadastroModel", "Exemplos", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"margem\">\r\n        <div class=\"mb-3\">\r\n            ");
#nullable restore
#line 9 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.LabelFor(p => p.Codigo, new{@class="form-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 10 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.TextBoxFor(p => p.Codigo, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 11 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.ValidationMessageFor(p => p.Codigo, "" ,new { @class="text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            ");
#nullable restore
#line 14 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.LabelFor(p => p.Descricao, new{@class="form-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 15 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.TextBoxFor(p => p.Descricao, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 16 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.ValidationMessageFor(p => p.Descricao, "", new{ @class="text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"mb-3\">\r\n            ");
#nullable restore
#line 19 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.LabelFor(p => p.Preco, new{@class="form-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 20 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.TextBoxFor(p => p.Preco, new{@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
       Write(Html.ValidationMessageFor(p => p.Preco, "", new{ @class="text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Enviar</button>\r\n    </div>\r\n");
#nullable restore
#line 25 "D:\DEV MANDA\Bootcamp-Angular\DesenvolvimentoWeb\Projeto01.ConceitosMVC\Projeto01.ConceitosMVC\Views\Exemplos\CadastroModel.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Produto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
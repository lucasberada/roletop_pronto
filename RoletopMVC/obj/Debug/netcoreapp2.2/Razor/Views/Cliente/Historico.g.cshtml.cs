#pragma checksum "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4749e468010d2710bca9fb2d191242020871d7dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4749e468010d2710bca9fb2d191242020871d7dc", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Seu Evento - Roletop";

#line default
#line hidden
            BeginContext(105, 364, true);
            WriteLiteral(@"<main>
    <br>
        <h2>Seu Historico de eventos</h2>
         <br>
    <table>
        <thead>
            <tr>
                <th>Data</th>
                <th>Nome</th>
                <th>luz e som</th>
                <th>Forma ed pagamento</th>
                <th>Status do Pedido</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
             foreach( var pedido in Model.Pedidos ) {

#line default
#line hidden
            BeginContext(524, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(571, 19, false);
#line 22 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(590, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(622, 11, false);
#line 23 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(633, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(665, 13, false);
#line 24 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.LuzSom);

#line default
#line hidden
            EndContext();
            BeginContext(678, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(710, 21, false);
#line 25 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(731, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(763, 13, false);
#line 26 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
                   Write(pedido.Status);

#line default
#line hidden
            EndContext();
            BeginContext(776, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(821, 304, true);
            WriteLiteral(@"        </tbody>
    </table>
    <br>

    <h2>Legenda do Status</h2>
    <br>
    <p>0 = Pedido Pendente Aguarde Resposta.
        <br>
    1 = Pedido Aprovado Parabens!
    <br>
    2 = Pedido Reprovado Que Triste! </p>
    
      <br> <br> <br> <br> <br> <br> <br> <br> <br> <br>
</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

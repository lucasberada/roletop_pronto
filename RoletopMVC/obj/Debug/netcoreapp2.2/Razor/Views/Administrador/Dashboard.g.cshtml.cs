#pragma checksum "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f73882c19169cb91feb9164f2ab8122984ed756"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Dashboard), @"mvc.1.0.view", @"/Views/Administrador/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Dashboard.cshtml", typeof(AspNetCore.Views_Administrador_Dashboard))]
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
#line 1 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC;

#line default
#line hidden
#line 2 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\_ViewImports.cshtml"
using RoletopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f73882c19169cb91feb9164f2ab8122984ed756", @"/Views/Administrador/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.DashboardViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 255, true);
            WriteLiteral("\r\n <main>\r\n\r\n<br>\r\n\r\n         <h3>STATUS DOS EVENTOS</h3>\r\n            <section id=\"apr\">\r\n<br>\r\n\r\n            <div class=\"box-status-pedidos aprovados\">\r\n                    <h4>Aprovados</h4><i class=\"fas fa-calendar-check\"></i>\r\n                    <p>");
            EndContext();
            BeginContext(305, 22, false);
#line 13 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                  Write(Model.PedidosAprovados);

#line default
#line hidden
            EndContext();
            BeginContext(327, 200, true);
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"box-status-pedidos pendentes\">\r\n                        <h4>pendentes</h4><i class=\"fas fa-hourglass-half\"></i>\r\n                        <p>");
            EndContext();
            BeginContext(528, 22, false);
#line 18 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                      Write(Model.PedidosPendentes);

#line default
#line hidden
            EndContext();
            BeginContext(550, 220, true);
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"box-status-pedidos reprovados\">\r\n                            <h4>reprovados</h4><i class=\"fas fa-skull-crossbones\"></i>\r\n                            <p>");
            EndContext();
            BeginContext(771, 23, false);
#line 23 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                          Write(Model.PedidosReprovados);

#line default
#line hidden
            EndContext();
            BeginContext(794, 1118, true);
            WriteLiteral(@"</p>
                        </div>
                    </section>
<br>

                    <h3>LISTA DE EVENTOS</h3>
<br>
                    <table>
                            <thead>
                                <tr>
                                    <th rowspan=""2"">Nome</th>
                                    <th rowspan=""2"">data do evento</th>
                                    <th rowspan=""2"">descriçao do evento</th>
                                    <th rowspan=""2"">cpf</th>
                                    <th rowspan=""2"">rg</th>
                                    <th rowspan=""2"">email</th>
                                    <th rowspan=""2"">luz e som</th>
                                    <th rowspam=""2"">confirmar</th>
                                    <th rowspam=""2"">negar</th>
                                </tr>
                                
                                    
                                    
                            
         ");
            WriteLiteral("                   </thead>\r\n                          \r\n                            <tbody>\r\n");
            EndContext();
#line 50 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                 foreach (var pedido in Model.Pedidos)
                                {

#line default
#line hidden
            BeginContext(2019, 83, true);
            WriteLiteral("                                     <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(2103, 19, false);
#line 53 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                   Write(pedido.Cliente.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(2122, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2170, 19, false);
#line 54 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                   Write(pedido.DataDoEvento);

#line default
#line hidden
            EndContext();
            BeginContext(2189, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2237, 16, false);
#line 55 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                   Write(pedido.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(2253, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2301, 18, false);
#line 56 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                   Write(pedido.Cliente.CPF);

#line default
#line hidden
            EndContext();
            BeginContext(2319, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2367, 17, false);
#line 57 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                   Write(pedido.Cliente.RG);

#line default
#line hidden
            EndContext();
            BeginContext(2384, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2432, 20, false);
#line 58 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                   Write(pedido.Cliente.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2452, 48, true);
            WriteLiteral("</td>\r\n                                     <td>");
            EndContext();
            BeginContext(2501, 13, false);
#line 59 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                    Write(pedido.LuzSom);

#line default
#line hidden
            EndContext();
            BeginContext(2514, 49, true);
            WriteLiteral("</td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", "  href=\'", 2563, "\'", 2626, 1);
#line 60 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2571, Url.Action("Aprovar", "Pedido", new {id = @pedido.Id}), 2571, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2627, 89, true);
            WriteLiteral("><i class=\"fas fa-check-circle\"></i></a></td>\r\n                                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2716, "\'", 2779, 1);
#line 61 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
WriteAttributeValue("", 2723, Url.Action("Reprovar", "Pedido", new {id = @pedido.Id}), 2723, 56, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2780, 115, true);
            WriteLiteral("><i class=\"fas fa-ban\"></i></a></td>\r\n                                    \r\n                                </tr>\r\n");
            EndContext();
#line 64 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                }

#line default
#line hidden
            BeginContext(2930, 324, true);
            WriteLiteral(@"                               
                              
                            </tbody>
                            
                        </table>
                          <br>
                            <br>
                              <br>
                        <p>agendamentos atualizados em ");
            EndContext();
            BeginContext(3255, 12, false);
#line 73 "C:\Users\52041722894\Desktop\ryjjhdtj\roletop_pronto\RoletopMVC\Views\Administrador\Dashboard.cshtml"
                                                  Write(DateTime.Now);

#line default
#line hidden
            EndContext();
            BeginContext(3267, 100, true);
            WriteLiteral("</p>\r\n           <br>\r\n             <br>\r\n              <br>\r\n               <br>\r\n\r\n        </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

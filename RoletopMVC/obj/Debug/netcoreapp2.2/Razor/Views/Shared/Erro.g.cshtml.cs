#pragma checksum "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Shared\Erro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ebd8378a8a2fac4b027468420f49ae8bf5967a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Erro), @"mvc.1.0.view", @"/Views/Shared/Erro.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Erro.cshtml", typeof(AspNetCore.Views_Shared_Erro))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ebd8378a8a2fac4b027468420f49ae8bf5967a7", @"/Views/Shared/Erro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fcde6f443f8ee695eebee3c09673a46bc68798b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Erro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMVC.ViewModels.RespostaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 52, true);
            WriteLiteral("<main>\r\n    <section id=\"caixa\">\r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(101, 14, false);
#line 5 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Shared\Erro.cshtml"
   Write(Model.NomeView);

#line default
#line hidden
            EndContext();
            BeginContext(115, 42, true);
            WriteLiteral(" deu ruim!  \r\n    </h2>\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(158, 14, false);
#line 8 "C:\Users\52041722894\Desktop\RoleTOPP\RoletopMVC\Views\Shared\Erro.cshtml"
   Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(172, 35, true);
            WriteLiteral("\r\n    </p>\r\n    </section>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMVC.ViewModels.RespostaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\Carros\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb00d7ac40f7b5499b145157f5a9ea5a8dbb8ddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Detalhes), @"mvc.1.0.view", @"/Views/Carros/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carros/Detalhes.cshtml", typeof(AspNetCore.Views_Carros_Detalhes))]
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
#line 1 "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#line 2 "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb00d7ac40f7b5499b145157f5a9ea5a8dbb8ddb", @"/Views/Carros/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.Carro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\Carros\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(81, 46, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(128, 37, false);
#line 9 "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(165, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(172, 36, false);
#line 10 "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(208, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(215, 35, false);
#line 11 "C:\Users\dougg\Desktop\Desenvolvimento\WebApplication1\WebApplication1\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(250, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\wtalavera\Documents\PLURALSIGHT\ASP.NET-CORE-FULL\Restaurante\Pages\Greeting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fda1d4297ebee87cdfb6185d7691b951843c2d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Greeting), @"mvc.1.0.razor-page", @"/Pages/Greeting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Greeting.cshtml", typeof(AspNetCore.Pages_Greeting), null)]
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
#line 1 "C:\Users\wtalavera\Documents\PLURALSIGHT\ASP.NET-CORE-FULL\Restaurante\Pages\_ViewImports.cshtml"
using Restaurante.Models;

#line default
#line hidden
#line 2 "C:\Users\wtalavera\Documents\PLURALSIGHT\ASP.NET-CORE-FULL\Restaurante\Pages\_ViewImports.cshtml"
using Restaurante.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\wtalavera\Documents\PLURALSIGHT\ASP.NET-CORE-FULL\Restaurante\Pages\_ViewImports.cshtml"
using Restaurante.Pages;

#line default
#line hidden
#line 4 "C:\Users\wtalavera\Documents\PLURALSIGHT\ASP.NET-CORE-FULL\Restaurante\Pages\_ViewImports.cshtml"
using Restaurante.Services;

#line default
#line hidden
#line 5 "C:\Users\wtalavera\Documents\PLURALSIGHT\ASP.NET-CORE-FULL\Restaurante\Pages\_ViewImports.cshtml"
using Resturante.Services;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fda1d4297ebee87cdfb6185d7691b951843c2d9", @"/Pages/Greeting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c71d1edd8fe79612ce70ef0d683629a23720569", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Greeting : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(31, 13, true);
            WriteLiteral("\r\n<div></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GreetingModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GreetingModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GreetingModel>)PageContext?.ViewData;
        public GreetingModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

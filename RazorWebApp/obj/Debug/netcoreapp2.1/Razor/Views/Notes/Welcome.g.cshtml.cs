#pragma checksum "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\Notes\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b854250b6ca127dc77086d612444b3f68d0de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notes_Welcome), @"mvc.1.0.view", @"/Views/Notes/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notes/Welcome.cshtml", typeof(AspNetCore.Views_Notes_Welcome))]
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
#line 1 "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\_ViewImports.cshtml"
using RazorWebApp;

#line default
#line hidden
#line 2 "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\_ViewImports.cshtml"
using RazorWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b854250b6ca127dc77086d612444b3f68d0de3", @"/Views/Notes/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1aa383b2e8dfb9506048ffa265f275c85c6348b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Notes_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\Notes\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(41, 23, true);
            WriteLiteral("<h2>Welcome</h2>\n\n<ul>\n");
            EndContext();
#line 8 "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\Notes\Welcome.cshtml"
     for (int i = 0; i<(int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(125, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(138, 19, false);
#line 10 "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\Notes\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(157, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 11 "C:\Users\1\source\repos\Тест\RazorWebApp-master\RazorWebApp\Views\Notes\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(169, 6, true);
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\b.lesik\source\repos\Test Project\Test Project\Views\Home\Films.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a8b458648aae7467d06739c683d0472de167975"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Films), @"mvc.1.0.view", @"/Views/Home/Films.cshtml")]
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
#line 1 "C:\Users\b.lesik\source\repos\Test Project\Test Project\Views\_ViewImports.cshtml"
using Test_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\b.lesik\source\repos\Test Project\Test Project\Views\_ViewImports.cshtml"
using Test_Project.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\b.lesik\source\repos\Test Project\Test Project\Views\Home\Films.cshtml"
using HtmlHelpersApp.App_Code;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a8b458648aae7467d06739c683d0472de167975", @"/Views/Home/Films.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0deb162effc24d5eec4986e14612628cd0a222b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Films : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test_Project.Models.Films>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h3>Фильмы</h3>\r\n");
#nullable restore
#line 9 "C:\Users\b.lesik\source\repos\Test Project\Test Project\Views\Home\Films.cshtml"
Write(Html.CreateList(Model.films));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h3>Мультики</h3>\r\n");
#nullable restore
#line 13 "C:\Users\b.lesik\source\repos\Test Project\Test Project\Views\Home\Films.cshtml"
Write(Html.CreateList(Model.movies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test_Project.Models.Films> Html { get; private set; }
    }
}
#pragma warning restore 1591

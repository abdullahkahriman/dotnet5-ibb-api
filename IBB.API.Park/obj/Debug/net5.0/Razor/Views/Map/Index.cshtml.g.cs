#pragma checksum "C:\PROJECTS\CUSTOM\IBB.API\IBB.API.Park\Views\Map\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27deb043ce83aab65e5576556b2f4b69054a1a5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Map_Index), @"mvc.1.0.view", @"/Views/Map/Index.cshtml")]
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
#line 1 "C:\PROJECTS\CUSTOM\IBB.API\IBB.API.Park\Views\_ViewImports.cshtml"
using IBB.API.Park;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\PROJECTS\CUSTOM\IBB.API\IBB.API.Park\Views\_ViewImports.cshtml"
using IBB.API.Park.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27deb043ce83aab65e5576556b2f4b69054a1a5f", @"/Views/Map/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179fdf79e169e7c0cb28f5939fbbf2e0b9f61e28", @"/Views/_ViewImports.cshtml")]
    public class Views_Map_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\PROJECTS\CUSTOM\IBB.API\IBB.API.Park\Views\Map\Index.cshtml"
  
    ViewData["Title"] = "Map";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"map-container\">\r\n    <div class=\"map-loader\">\r\n        <img src=\"/img/loading.gif\"");
            BeginWriteAttribute("alt", " alt=\"", 135, "\"", 141, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n    <div id=\"map\"></div>\r\n</div>\r\n");
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

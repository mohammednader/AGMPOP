#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\cycleDetailter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89f46b3039352fac9297971eed842abb917a6553"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cycles_cycleDetailter), @"mvc.1.0.view", @"/Views/Cycles/cycleDetailter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cycles/cycleDetailter.cshtml", typeof(AspNetCore.Views_Cycles_cycleDetailter))]
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
#line 1 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\_ViewImports.cshtml"
using AGMPOP.Web;

#line default
#line hidden
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\_ViewImports.cshtml"
using AGMPOP.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89f46b3039352fac9297971eed842abb917a6553", @"/Views/Cycles/cycleDetailter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Cycles_cycleDetailter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\cycleDetailter.cshtml"
  
    ViewData["Title"] = "cycleDetailter";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(99, 144, true);
            WriteLiteral("\r\n<h1>cycleDetailter</h1>\r\n\r\n<div id=\"territories\" ></div>\r\n\r\n<script>\r\n    function loadTerrtiroiesTab() {\r\n        $.ajax({\r\n            url:\'");
            EndContext();
            BeginContext(244, 29, false);
#line 14 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\cycleDetailter.cshtml"
            Write(Url.Action("_CycleTerritory"));

#line default
#line hidden
            EndContext();
            BeginContext(273, 349, true);
            WriteLiteral(@"',
            method: 'GET',
            success: response => {
                if (response) {
                    $('#territories').html(response);
                   // $('.nav-tabs a[href=""#territories""]').tab('show');
                }
            }
        })
    }
    $(() => {
        loadTerrtiroiesTab();

    });
</script>");
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

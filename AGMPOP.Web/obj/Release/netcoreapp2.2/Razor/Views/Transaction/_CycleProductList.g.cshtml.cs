#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "388876f5a3e574c98603172864e9831033c86fc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__CycleProductList), @"mvc.1.0.view", @"/Views/Transaction/_CycleProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/_CycleProductList.cshtml", typeof(AspNetCore.Views_Transaction__CycleProductList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"388876f5a3e574c98603172864e9831033c86fc4", @"/Views/Transaction/_CycleProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__CycleProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductCycleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 69, true);
            WriteLiteral("\r\n\r\n\r\n<table width=\"100%\" class=\"table table-bordered card-body\">\r\n\r\n");
            EndContext();
#line 7 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
     if (Model.Count() > 0)
    {
        foreach (var prod in Model)
        {

#line default
#line hidden
            BeginContext(213, 82, true);
            WriteLiteral("            <tr>\r\n                <td class=\"img-warp\">\r\n                     <img");
            EndContext();
            BeginWriteAttribute("src", "  src=\"", 295, "\"", 318, 1);
#line 13 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
WriteAttributeValue("", 302, prod.ProductImg, 302, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(319, 135, true);
            WriteLiteral(" style=\"height:40px; width:40px;\" />\r\n\r\n                </td>\r\n                <td>\r\n                    <h5>\r\n                        ");
            EndContext();
            BeginContext(455, 16, false);
#line 18 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
                   Write(prod.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(471, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 19 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
                         if (prod.TypeId == 1)
                        {

#line default
#line hidden
            BeginContext(548, 62, true);
            WriteLiteral("                            <small class=\"block\">BBo</small>\r\n");
            EndContext();
#line 22 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
                        } 
                        else
                        {

#line default
#line hidden
            BeginContext(695, 66, true);
            WriteLiteral("                            <small class=\"block\">Product</small>\r\n");
            EndContext();
#line 26 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
                        }

#line default
#line hidden
            BeginContext(788, 139, true);
            WriteLiteral("\r\n                    </h5>\r\n                </td>\r\n                <td class=\"text-right\">\r\n                    <input style=\"width:50px;\"");
            EndContext();
            BeginWriteAttribute("name", " name=\"", 927, "\"", 951, 1);
#line 31 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
WriteAttributeValue("", 934, prod.ProductName, 934, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 952, "\"", 972, 1);
#line 31 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
WriteAttributeValue("", 957, prod.ProductId, 957, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(973, 190, true);
            WriteLiteral(" class=\"text-center pull-right mr-sm valid product\" placeholder=\"0\" value=\"0\" min=\"0\" oninput=\"this.value = Math.abs(this.value)\"type=\"number\"/>\r\n\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 35 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_CycleProductList.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1181, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AGMPOP.BL.Models.ViewModels.ProductCycleModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
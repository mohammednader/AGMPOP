#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cda00ef6f185eff1086b2cd8b80c71b4383b61dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction__TransactionDetails), @"mvc.1.0.view", @"/Views/Transaction/_TransactionDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/_TransactionDetails.cshtml", typeof(AspNetCore.Views_Transaction__TransactionDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cda00ef6f185eff1086b2cd8b80c71b4383b61dc", @"/Views/Transaction/_TransactionDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction__TransactionDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductCycleModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(88, 138, true);
            WriteLiteral("    <div class=\"modal-header d-flex justify-content-between\">\r\n        <h5  class=\"modal-title p-n m-n pull-left \">Transaction\'s Products ");
            EndContext();
            BeginContext(227, 13, false);
#line 7 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
                                                                      Write(Model.Count());

#line default
#line hidden
            EndContext();
            BeginContext(240, 603, true);
            WriteLiteral(@" items</h5>
        <button data-dismiss=""modal"" class=""close"">&times;</button>
    </div>
    <div class=""modal-body"">

        <table id=""cycles-table"" class=""table table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"" data-field=""photo"">Photo</th>
                    <th class=""text-center"" data-field=""name"">Name</th>
                    <th class=""text-center"" data-field=""code"">Code</th>
                    <th class=""text-center"" data-field=""type"">Quantity</th>
    
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 23 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(908, 108, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1016, "\"", 1038, 1);
#line 27 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
WriteAttributeValue("", 1022, item.ProductImg, 1022, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1039, 147, true);
            WriteLiteral("class=\"img-circle product-img\" />\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            <a>");
            EndContext();
            BeginContext(1187, 16, false);
#line 30 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
                          Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 85, true);
            WriteLiteral("</a>\r\n                        </td>\r\n                        <td class=\"text-center\">");
            EndContext();
            BeginContext(1289, 9, false);
#line 32 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
                                           Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(1298, 97, true);
            WriteLiteral("</td>\r\n    \r\n    \r\n                        <td class=\"text-center\">\r\n                            ");
            EndContext();
            BeginContext(1396, 13, false);
#line 36 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
                       Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1409, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
                }

#line default
#line hidden
            BeginContext(1488, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 43 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(1552, 206, true);
            WriteLiteral("    <div class=\"p-sm\">\r\n        <div>\r\n            <strong class=\"title pull-left\">\r\n                There is no Transaction Detials on this Transaction!\r\n            </strong>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 53 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\_TransactionDetails.cshtml"
}

#line default
#line hidden
            BeginContext(1761, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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

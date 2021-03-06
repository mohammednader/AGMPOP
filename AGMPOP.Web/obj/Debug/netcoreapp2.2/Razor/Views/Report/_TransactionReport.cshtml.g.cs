#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bd74c1129d7cf0dba47e7d9229ab94e284f6268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report__TransactionReport), @"mvc.1.0.view", @"/Views/Report/_TransactionReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/_TransactionReport.cshtml", typeof(AspNetCore.Views_Report__TransactionReport))]
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
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
using AGMPOP.BL.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bd74c1129d7cf0dba47e7d9229ab94e284f6268", @"/Views/Report/_TransactionReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Report__TransactionReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<AGMPOP.BL.Models.ViewModels.TransactionCycle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(161, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(449, 123, true);
            WriteLiteral("<div>\r\n\r\n    <table id=\"dt_transTable\" class=\"table table-striped  table-bordered\">\r\n \r\n        <thead>\r\n            <tr>\r\n");
            EndContext();
#line 25 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                 if (ViewBag.showData == 0)
                {

#line default
#line hidden
            BeginContext(636, 41, true);
            WriteLiteral("                    <th>Cycle Name</th>\r\n");
            EndContext();
#line 28 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                }

#line default
#line hidden
            BeginContext(696, 296, true);
            WriteLiteral(@"                <th>From</th>
                <th>To</th>
                <th>Type</th>
                <th>Created Date</th>
                <th>Created By</th>
                <th>Status</th>
                <th>Total Items</th>

            </tr>
        </thead>

        <tbody>
");
            EndContext();
#line 41 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
             if (Model?.Count > 0)
            {
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1107, 26, true);
            WriteLiteral("                    <tr>\r\n");
            EndContext();
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                         if (ViewBag.showData == 0)
                        {

#line default
#line hidden
            BeginContext(1213, 35, true);
            WriteLiteral("                            <td><b>");
            EndContext();
            BeginContext(1249, 14, false);
#line 48 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                              Write(item.CycleName);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 11, true);
            WriteLiteral("</b></td>\r\n");
            EndContext();
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                        }

#line default
#line hidden
            BeginContext(1301, 28, true);
            WriteLiteral("                        <td>");
            EndContext();
            BeginContext(1330, 17, false);
#line 50 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                       Write(item.FromUserName);

#line default
#line hidden
            EndContext();
            BeginContext(1347, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1383, 15, false);
#line 51 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                       Write(item.ToUserName);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1435, 49, false);
#line 52 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                        Write(((POPEnums.TransactionTypes)item.Type).ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1485, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1521, 20, false);
#line 53 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                       Write(item.Date.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1541, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1577, 14, false);
#line 54 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                       Write(item.CreatedBy);

#line default
#line hidden
            EndContext();
            BeginContext(1591, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1628, 69, false);
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                        Write(((POPEnums.TransactionStatus)item.Status).ToString().Replace("_"," "));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 163, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            <span class=\"badge badge-pill badge-primary px-2 py-1\" style=\"font-size:14px\"> <a class=\"btn-link\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1861, "\"", 1897, 3);
            WriteAttributeValue("", 1871, "showDetials(", 1871, 12, true);
#line 57 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
WriteAttributeValue("", 1883, item.TransId, 1883, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 1896, ")", 1896, 1, true);
            EndWriteAttribute();
            BeginContext(1898, 10, true);
            WriteLiteral(" title=\'\'>");
            EndContext();
            BeginContext(1909, 38, false);
#line 57 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                                                                                                                                                                        Write(item.TotalItem.Sum(a => a.TransAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 74, true);
            WriteLiteral("</a> </span>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"

                }
            }
            else
            {

#line default
#line hidden
            BeginContext(2090, 22, true);
            WriteLiteral("                <tr>\r\n");
            EndContext();
#line 67 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                     if (ViewBag.showData == 0)
                    {

#line default
#line hidden
            BeginContext(2184, 144, true);
            WriteLiteral("                        <td colspan=\"8\" class=\"text-center\">\r\n                            No transactions found\r\n                        </td>\r\n");
            EndContext();
#line 72 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2400, 142, true);
            WriteLiteral("                        <td colspan=\"7\" class=\"text-center\">\r\n                            No transactions found\r\n                        </td>");
            EndContext();
#line 77 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                             }

#line default
#line hidden
            BeginContext(2545, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 79 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
            }

#line default
#line hidden
            BeginContext(2583, 602, true);
            WriteLiteral(@"

        </tbody>
    </table>
</div>
<!-- Modal -->
<div id='DetialModal' class=""modal fade"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">

            <div class=""modal-body"">

                <div id='DetialContainer'>

                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>

            </div>
        </div>
    </div>
</div>
");
            EndContext();
#line 103 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
 if (Model?.Count > 0)
{ 

#line default
#line hidden
            BeginContext(3213, 178, true);
            WriteLiteral("        <script> \r\n            $(document).ready(function () {\r\n                   $(\'#dt_transTable\').DataTable({\r\n                    });\r\n \r\n            });\r\n\r\n    </script>\r\n");
            EndContext();
#line 113 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
}

#line default
#line hidden
            BeginContext(3394, 146, true);
            WriteLiteral("    <script>\r\n        //show Product details in transaction\r\n        function showDetials(Tid) {\r\n\r\n            $.ajax({\r\n\r\n                url: \'");
            EndContext();
            BeginContext(3541, 47, false);
#line 120 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_TransactionReport.cshtml"
                 Write(Url.Action("_TransactionDetails","Transaction"));

#line default
#line hidden
            EndContext();
            BeginContext(3588, 300, true);
            WriteLiteral(@"',
                method: 'Get',
                data: { Tid },
                success: function (data, jqXHR) {
                    $('#DetialContainer').html(data);
                    $('#DetialModal').modal('show');


                }
            });
        }

    </script>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<AGMPOP.BL.Models.ViewModels.TransactionCycle>> Html { get; private set; }
    }
}
#pragma warning restore 1591

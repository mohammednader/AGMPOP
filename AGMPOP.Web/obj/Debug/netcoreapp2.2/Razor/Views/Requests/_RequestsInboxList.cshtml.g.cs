#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b70c5acd60f87b30d55973aa66397382d63405e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests__RequestsInboxList), @"mvc.1.0.view", @"/Views/Requests/_RequestsInboxList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Requests/_RequestsInboxList.cshtml", typeof(AspNetCore.Views_Requests__RequestsInboxList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b70c5acd60f87b30d55973aa66397382d63405e4", @"/Views/Requests/_RequestsInboxList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Requests__RequestsInboxList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AGMPOP.Web.Models.Requests.RequestsInboxVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(93, 859, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12"">
        <div class=""card card-body"">
            <table id=""dtBasicExample"" class=""table table-responsive-sm table-responsive-md table-striped table-bordered"" cellspacing=""0"" width=""100%"">

                <thead>
                    <tr>
                        <th data-field=""name"" data-sortable=""true"">Cycle Name</th>
                        <th data-field="""" data-sortable=""true"">Cycle Type</th>
                        <th data-field="""" data-sortable=""true"">Requested By</th>
                        <th data-field="""" data-sortable=""true"">Request Date</th>
                        <th data-field="""">    Status</th>
                        <th data-field="""">Total Items</th>
                        <th>Action</th>
                    </tr>
                </thead>

                <tbody>
");
            EndContext();
#line 25 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                     if (Model != null)
                    {


                        foreach (var item in Model)
                        {


#line default
#line hidden
            BeginContext(1102, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1173, 14, false);
#line 33 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                               Write(item.CycleName);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 34 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                 if (@item.CycleType == 1)
                                {

#line default
#line hidden
            BeginContext(1289, 57, true);
            WriteLiteral("                                    <td>NationWide</td>\r\n");
            EndContext();
#line 37 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(1454, 52, true);
            WriteLiteral("                                    <td>Event</td>\r\n");
            EndContext();
#line 41 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                }

#line default
#line hidden
            BeginContext(1541, 76, true);
            WriteLiteral("\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1618, 19, false);
#line 44 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                               Write(item.CreartedByName);

#line default
#line hidden
            EndContext();
            BeginContext(1637, 77, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>");
            EndContext();
            BeginContext(1715, 41, false);
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                               Write(item.ReqDate.ToString("dd/MM/yyyy HH:mm"));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                 if (@item.ReqStatus == false)
                                {

#line default
#line hidden
            BeginContext(1862, 54, true);
            WriteLiteral("                                    <td>Pending</td>\r\n");
            EndContext();
#line 50 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2024, 55, true);
            WriteLiteral("                                    <td>Received</td>\r\n");
            EndContext();
#line 54 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                }

#line default
#line hidden
            BeginContext(2114, 233, true);
            WriteLiteral("\r\n                                <td>\r\n                                    <span class=\"badge badge-pill badge-primary\">\r\n                                        <a class=\"btn-link \" data-toggle=\"modal\" data-target=\"#ProductDetails\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2347, "\"", 2380, 3);
            WriteAttributeValue("", 2357, "GetDetails(", 2357, 11, true);
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
WriteAttributeValue("", 2368, item.ReqID, 2368, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2379, ")", 2379, 1, true);
            EndWriteAttribute();
            BeginContext(2381, 10, true);
            WriteLiteral(" title=\'\'>");
            EndContext();
            BeginContext(2392, 14, false);
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                                                                                                                                     Write(item.ReqAmount);

#line default
#line hidden
            EndContext();
            BeginContext(2406, 92, true);
            WriteLiteral("</a>\r\n                                    </span>\r\n                                </td>\r\n\r\n");
            EndContext();
#line 62 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                 if (@item.ReqStatus == false)
                                {

#line default
#line hidden
            BeginContext(2597, 156, true);
            WriteLiteral("                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-success\" title=\"Confirm this request\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2753, "\"", 2789, 3);
            WriteAttributeValue("", 2763, "AcceptRequest(", 2763, 14, true);
#line 65 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
WriteAttributeValue("", 2777, item.ReqID, 2777, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 2788, ")", 2788, 1, true);
            EndWriteAttribute();
            BeginContext(2790, 62, true);
            WriteLiteral(">Confirm</button>\r\n                                    </td>\r\n");
            EndContext();
#line 67 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2960, 221, true);
            WriteLiteral("                                    <td>\r\n                                        <button type=\"button\" class=\"btn btn-secondary \" disabled><i class=\"fa fa-check\"></i></button>\r\n                                    </td>\r\n");
            EndContext();
#line 73 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"
                                }

#line default
#line hidden
            BeginContext(3216, 37, true);
            WriteLiteral("\r\n                            </tr>\r\n");
            EndContext();
#line 76 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\_RequestsInboxList.cshtml"

                        }
                    }

#line default
#line hidden
            BeginContext(3305, 1088, true);
            WriteLiteral(@"                </tbody>
            </table>
        </div>
    </div>
</div>

<div class=""modal fade"" id=""ProductDetails"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""p-n m-n pull-left"" id=""CycleName""></h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <table id=""stock-table"" class=""table table-bordered"">
                    <thead><tr><th>Item Name</th><th>Quantity</th></tr></thead>

                    <tbody></tbody>
                </table>

            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</butto");
            WriteLiteral("n>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AGMPOP.Web.Models.Requests.RequestsInboxVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

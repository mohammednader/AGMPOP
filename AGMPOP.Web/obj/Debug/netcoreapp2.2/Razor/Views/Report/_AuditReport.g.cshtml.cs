#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7c9c1e6360d512b54896f04c0ab877f0d6167a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report__AuditReport), @"mvc.1.0.view", @"/Views/Report/_AuditReport.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/_AuditReport.cshtml", typeof(AspNetCore.Views_Report__AuditReport))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7c9c1e6360d512b54896f04c0ab877f0d6167a4", @"/Views/Report/_AuditReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Report__AuditReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.AuditSearchVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 765, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-body"">

            <table id=""Audit-table"" class=""table table-bordered table-striped table-responsive-sm table-responsive-md table-responsive-lg"">
                <thead>
                    <tr>
                        <th data-field=""id"" class=""text-center"">User</th>
                        <th data-field=""name"" class=""text-center"">Date</th>
                        <th data-field=""name"" class=""text-center"">Action</th>
                        <th data-field=""name"" class=""text-center"">Table Name</th>
                        <th data-field=""name"" class=""text-center"">View Details</th>

                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 21 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                      

                        if (Model.Count != 0)
                        {



                            

#line default
#line hidden
#line 28 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1016, 139, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                       ");
            EndContext();
            BeginContext(1156, 13, false);
#line 32 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                                  Write(item.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1169, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(1317, 9, false);
#line 35 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                                   Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 144, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                     ");
            EndContext();
            BeginContext(1471, 15, false);
#line 38 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                                Write(item.ActionName);

#line default
#line hidden
            EndContext();
            BeginContext(1486, 124, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                     ");
            EndContext();
            BeginContext(1611, 14, false);
#line 41 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                                Write(item.TableName);

#line default
#line hidden
            EndContext();
            BeginContext(1625, 243, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <button class=\"material-tooltip-main btn btn-danger btn-floating my-0 p-0\" data-toggle=\"tooltip\"");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 1868, "\"", 1889, 1);
#line 44 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
WriteAttributeValue("", 1876, item.NewData, 1876, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1890, 190, true);
            WriteLiteral(">\r\n                                            New data\r\n                                        </button>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                            }

#line default
#line hidden
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(2195, 150, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"10\"> There is no data to view</td>\r\n                            </tr>\r\n");
            EndContext();
#line 56 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"

                        }
                    

#line default
#line hidden
            BeginContext(2397, 147, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div><!--  end card  -->\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n\r\n");
            EndContext();
#line 66 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(2570, 228, true);
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n\r\n            $(\'#Audit-table\').DataTable({\r\n                \"ordering\": false,\r\n                // \"order\": [[3, \"desc\"]]\r\n            });\r\n\r\n\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 79 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_AuditReport.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AGMPOP.BL.Models.ViewModels.AuditSearchVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591

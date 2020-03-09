#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad66cab4863b2461a6bd71cc20d3cbad1148f30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cycles__CyclesList), @"mvc.1.0.view", @"/Views/Cycles/_CyclesList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cycles/_CyclesList.cshtml", typeof(AspNetCore.Views_Cycles__CyclesList))]
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
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
using AGMPOP.BL.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad66cab4863b2461a6bd71cc20d3cbad1148f30", @"/Views/Cycles/_CyclesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Cycles__CyclesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.CycleVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
  var CurrentDate = DateTime.Today;

#line default
#line hidden
            BeginContext(124, 1126, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-body"">

            <table id=""cycles-table"" class=""table table-bordered table-striped table-responsive-sm table-responsive-md table-responsive-lg"">
                <thead>
                    <tr>
                        <th data-field=""id"" class=""text-center"">ID</th>
                        <th data-field=""name"" class=""text-center"">Name</th>
                        <th data-field=""type"" class=""text-center"">Type</th>
                        <th data-field=""department"" class=""text-center"">Department</th>
                        <th data-field=""from"" class=""text-center"">From</th>
                        <th data-field=""to"" class=""text-center"">To</th>
                        <th data-field=""reconciliationdate"" class=""text-center"">Reconciliation Date</th>
                        <th class=""text-center"">Status</th>
                        <th class=""text-center"">Active/Inactive</th>
                        <th class="" text");
            WriteLiteral("-right\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n");
            EndContext();
#line 25 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                      

                        if (Model.Count != 0)
                        {



                            

#line default
#line hidden
#line 32 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1445, 140, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(1586, 12, false);
#line 36 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                   Write(item.CycleId);

#line default
#line hidden
            EndContext();
            BeginContext(1598, 149, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1747, "\"", 1780, 2);
            WriteAttributeValue("", 1754, "CycleDetails/", 1754, 13, true);
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
WriteAttributeValue("", 1767, item.CycleId, 1767, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1781, 18, true);
            WriteLiteral(" class=\"btn-link\">");
            EndContext();
            BeginContext(1800, 9, false);
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                                         Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1809, 111, true);
            WriteLiteral("</a>\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 42 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                         if (item.CycleType == 1)
                                        {
                                            

#line default
#line hidden
            BeginContext(2076, 44, false);
#line 44 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                        Write(((POPEnums.CycleType.NationWide)).ToString());

#line default
#line hidden
            EndContext();
#line 44 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                                           

                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(2303, 39, false);
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                        Write(((POPEnums.CycleType.Event)).ToString());

#line default
#line hidden
            EndContext();
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                                      
                                        }

#line default
#line hidden
            BeginContext(2388, 125, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(2514, 19, false);
#line 53 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                   Write(item.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(2533, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(2681, 44, false);
#line 56 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(2873, 42, false);
#line 59 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(3063, 53, false);
#line 62 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ReconciliationDate));

#line default
#line hidden
            EndContext();
            BeginContext(3116, 107, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 65 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                         if (item.StartDate > CurrentDate)
                                        {
                                            

#line default
#line hidden
            BeginContext(3388, 39, false);
#line 67 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                        Write(((POPEnums.CycleStatus.New)).ToString());

#line default
#line hidden
            EndContext();
#line 67 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                                      
                                        }
                                        else if (item.StartDate <= CurrentDate && item.EndDate >= CurrentDate)
                                        {
                                            

#line default
#line hidden
            BeginContext(3674, 43, false);
#line 71 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                        Write(((POPEnums.CycleStatus.Running)).ToString());

#line default
#line hidden
            EndContext();
#line 71 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                                          
                                        }
                                        else if (item.EndDate < CurrentDate)
                                        {
                                            

#line default
#line hidden
            BeginContext(3930, 41, false);
#line 75 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                        Write(((POPEnums.CycleStatus.Ended)).ToString());

#line default
#line hidden
            EndContext();
#line 75 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                                        
                                        }

#line default
#line hidden
            BeginContext(4017, 108, true);
            WriteLiteral("                                    </td>\r\n\r\n                                    <td class=\" text-center\">\r\n");
            EndContext();
#line 80 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                         if (item.CycleIsActive == true)
                                        {
                                            

#line default
#line hidden
            BeginContext(4292, 6, true);
            WriteLiteral("Active");
            EndContext();
#line 82 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                               
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(4489, 8, true);
            WriteLiteral("Inactive");
            EndContext();
#line 86 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                                                 
                                        }

#line default
#line hidden
            BeginContext(4549, 251, true);
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a class=\"material-tooltip-main btn-primary  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 4800, "\'", 4870, 1);
#line 90 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
WriteAttributeValue("", 4807, Url.Action("UpdateCycle", "Cycles", new { Id = item.CycleId }), 4807, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4871, 166, true);
            WriteLiteral(">\r\n                                            <i class=\"fas fa-edit \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                        </a>\r\n\r\n");
            EndContext();
#line 94 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                                         if (item.CycleIsActive == false)
                                        {

#line default
#line hidden
            BeginContext(5155, 170, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn btn-success btn-floating my-0 p-0 btnActivation\" data-toggle=\"tooltip\" title=\"active\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5325, "\"", 5346, 1);
#line 96 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
WriteAttributeValue("", 5333, item.CycleId, 5333, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5347, 182, true);
            WriteLiteral(">\r\n                                                <i class=\"fad fa-user-check\" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 99 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"


                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(5665, 175, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn btn-danger btn-floating my-0 p-0 btnDectivation \" data-toggle=\"tooltip\" title=\"Deactivate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 5840, "\"", 5861, 1);
#line 104 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
WriteAttributeValue("", 5848, item.CycleId, 5848, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5862, 183, true);
            WriteLiteral(">\r\n                                                <i class=\"fad fa-user-times \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 107 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"

                                        }

#line default
#line hidden
            BeginContext(6090, 86, true);
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
            EndContext();
#line 113 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                            }

#line default
#line hidden
#line 113 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                             
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(6291, 150, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"10\"> There is no data to view</td>\r\n                            </tr>\r\n");
            EndContext();
#line 120 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"

                        }
                    

#line default
#line hidden
            BeginContext(6493, 145, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div><!--  end card  -->\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n");
            EndContext();
#line 129 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
 if (Model.Count > 0)
{

#line default
#line hidden
            BeginContext(6664, 229, true);
            WriteLiteral("    <script>\r\n        $(document).ready(function () {\r\n\r\n            $(\'#cycles-table\').DataTable({\r\n                \"ordering\": false,\r\n                // \"order\": [[3, \"desc\"]]\r\n            });\r\n\r\n\r\n        });\r\n    </script>\r\n");
            EndContext();
#line 142 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
}

#line default
#line hidden
            BeginContext(6896, 635, true);
            WriteLiteral(@"



<script type=""text/javascript"">
        $(function () {
            $("".btnActivation"").click(function (e) {
                var CycletId = $(this).val();

                Swal.fire({
                     text: ""Active Cycle!"",
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#888',
                    confirmButtonText: 'Yes, Activate it!'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: '");
            EndContext();
            BeginContext(7532, 32, false);
#line 162 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                             Write(Url.Action("Activate", "Cycles"));

#line default
#line hidden
            EndContext();
            BeginContext(7564, 1685, true);
            WriteLiteral(@"',
                            data: { CycletId },
                            type: ""Post"",
                            success: function (data) {

                                if (data.success == true) {
                                    Swal.fire({
                                        text: data.message,
                                        icon: 'success'
                                    }).then(
                                        function () {
                                            loadCycleData();

                                        }
                                    );
                                }

                                else {
                                    Swal.fire({
                                        text: data.message,
                                        icon: 'error'
                                    })
                                }

                            },

                        });
            ");
            WriteLiteral(@"        }
                })

            })
        })

        $(function () {
            $("".btnDectivation"").click(function (e) {
                var CycletId = $(this).val();
                Swal.fire({
                    text: ""Deactivate Cycle!"",
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes, Deactivate it!'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: '");
            EndContext();
            BeginContext(9250, 34, false);
#line 208 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CyclesList.cshtml"
                             Write(Url.Action("Deactivate", "Cycles"));

#line default
#line hidden
            EndContext();
            BeginContext(9284, 1100, true);
            WriteLiteral(@"',
                            data: { CycletId },
                            type: ""Post"",
                            success: function (data) {

                                if (data.success == true) {
                                    Swal.fire({
                                        text: data.message,
                                        icon: 'success'
                                    }).then(
                                        function () {
                                            loadCycleData();

                                        }
                                    );
                                }

                                else {
                                    Swal.fire({
                                        text: data.message,
                                        icon: 'error'
                                    })
                                }
                            },
                        });


            ");
            WriteLiteral("        }\r\n\r\n                })\r\n\r\n            })\r\n        })\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AGMPOP.BL.Models.ViewModels.CycleVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
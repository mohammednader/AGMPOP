#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8d48fa52000e639e153ea7238e138f560aa6ffe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department__departmentList), @"mvc.1.0.view", @"/Views/Department/_departmentList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Department/_departmentList.cshtml", typeof(AspNetCore.Views_Department__departmentList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8d48fa52000e639e153ea7238e138f560aa6ffe", @"/Views/Department/_departmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Department__departmentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AGMPOP.BL.Models.Domain.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 340, true);
            WriteLiteral(@"


<table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
    <thead>
        <tr>
            <th></th>
            <th class=""th-sm"">Department Name</th>

            <th class=""th-sm text-center"" style=""width:285px !important"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 15 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
         if (Model != null)
        {

            

#line default
#line hidden
#line 18 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(495, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(542, 9, false);
#line 21 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(551, 136, true);
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        <input type=\"text\" class=\"form-control\" style=\"width:250px; margin-left:10px\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 687, "\"", 705, 1);
#line 24 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 695, item.Name, 695, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 706, "\"", 719, 1);
#line 24 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 711, item.Id, 711, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 720, "\"", 750, 3);
            WriteAttributeValue("", 730, "changeDept(", 730, 11, true);
#line 24 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 741, item.Id, 741, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 749, ")", 749, 1, true);
            EndWriteAttribute();
            BeginContext(751, 172, true);
            WriteLiteral(" disabled />\r\n                        <span id=\"msg\" style=\"display:none;color:red\">This field is required.</span>\r\n\r\n                        <input id=\"temp\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 923, "\"", 941, 1);
#line 27 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 931, item.Name, 931, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(942, 222, true);
            WriteLiteral(" />\r\n\r\n                    </td>\r\n\r\n                    <td class=\"text-center\"> \r\n\r\n\r\n                        <button class=\"material-tooltip-main btn-primary  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1164, "\"", 1188, 1);
#line 34 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1169, item.Id + "edit", 1169, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1189, "\"", 1228, 3);
            WriteAttributeValue("", 1199, "javascript:editDept(", 1199, 20, true);
#line 34 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1219, item.Id, 1219, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1227, ")", 1227, 1, true);
            EndWriteAttribute();
            BeginContext(1229, 284, true);
            WriteLiteral(@">
                            <i class=""fas fa-edit "" style=""font-size:15px; margin-top:-5px;""></i>
                        </button>


                        <button class=""material-tooltip-main btn-danger  btn btn-floating my-0 p-0 d-none"" data-toggle=""tooltip"" title=""Cancel""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1513, "\"", 1539, 1);
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1518, item.Id + "cancle", 1518, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1540, "\"", 1570, 3);
            WriteAttributeValue("", 1550, "cancleDept(", 1550, 11, true);
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1561, item.Id, 1561, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1569, ")", 1569, 1, true);
            EndWriteAttribute();
            BeginContext(1571, 289, true);
            WriteLiteral(@">
                            <i class=""fas fa-times-circle "" style=""font-size:15px; margin-top:-5px;""></i>
                        </button>

                        <button class=""material-tooltip-main btn-success  btn btn-floating my-0 p-0 d-none"" data-toggle=""tooltip"" title=""Save""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1860, "\"", 1884, 1);
#line 43 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1865, item.Id + "save", 1865, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1885, "\"", 1913, 3);
            WriteAttributeValue("", 1895, "saveDept(", 1895, 9, true);
#line 43 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1904, item.Id, 1904, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1912, ")", 1912, 1, true);
            EndWriteAttribute();
            BeginContext(1914, 278, true);
            WriteLiteral(@">
                            <i class=""fas fa-save "" style=""font-size:15px; margin-top:-5px;""></i>
                        </button>



                        <button class=""material-tooltip-main btn btn-danger btn-floating my-0 p-0"" data-toggle=""tooltip"" title=""Delete""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2192, "\"", 2220, 3);
            WriteAttributeValue("", 2202, "showSwal(", 2202, 9, true);
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 2211, item.Id, 2211, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2219, ")", 2219, 1, true);
            EndWriteAttribute();
            BeginContext(2221, 194, true);
            WriteLiteral(">\r\n                            <i class=\"fa fa-trash-alt\" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                        </button>\r\n\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 56 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"



            }

#line default
#line hidden
#line 59 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(2472, 44, true);
            WriteLiteral("            <tr> Not found Department</tr>\r\n");
            EndContext();
#line 64 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
        }

#line default
#line hidden
            BeginContext(2527, 723, true);
            WriteLiteral(@"
    </tbody>
</table>

<script>
    $(document).ready(function () {


        $('.material-tooltip-main').tooltip({
            template: '<div class=""tooltip md-tooltip""><div class=""tooltip-arrow md-arrow""></div><div class=""tooltip-inner md-inner""></div></div>'
        });

        $(""select"").removeClass(""custom-select"");
        $('#dtBasicExample').DataTable({
            ""columnDefs"": [
                {
                    ""targets"": [1],
                    ""visible"": true,
                    ""orderData"": [0]
                },
                {
                    ""targets"": [0],
                    ""visible"": false,
                }
            ]
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AGMPOP.BL.Models.Domain.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
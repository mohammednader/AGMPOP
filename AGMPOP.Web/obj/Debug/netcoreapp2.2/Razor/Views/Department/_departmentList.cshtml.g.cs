#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb596e52a654d7dc35d8ae2d5fd54087f352b720"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb596e52a654d7dc35d8ae2d5fd54087f352b720", @"/Views/Department/_departmentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Department__departmentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AGMPOP.BL.Models.Domain.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 344, true);
            WriteLiteral(@"<table id=""dtBasicExample"" class=""table table-striped"" cellspacing=""0"">
    <thead>
        <tr>
            <th></th>
            <th class=""th-sm"">Department Name</th>
            <th class=""text-center"">Status</th>
            <th data-sortable=""false"" class=""th-sm"" width=""150"">Actions</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 12 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
         if (Model != null)
        {

            

#line default
#line hidden
#line 15 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(499, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(546, 9, false);
#line 18 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(555, 136, true);
            WriteLiteral("</td>\r\n                    <td>\r\n\r\n                        <input type=\"text\" class=\"form-control\" style=\"width:250px; margin-left:10px\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 691, "\"", 709, 1);
#line 21 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 699, item.Name, 699, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 710, "\"", 723, 1);
#line 21 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 715, item.Id, 715, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 724, "\"", 754, 3);
            WriteAttributeValue("", 734, "changeDept(", 734, 11, true);
#line 21 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 745, item.Id, 745, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 753, ")", 753, 1, true);
            EndWriteAttribute();
            BeginContext(755, 172, true);
            WriteLiteral(" disabled />\r\n                        <span id=\"msg\" style=\"display:none;color:red\">This field is required.</span>\r\n\r\n                        <input id=\"temp\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 927, "\"", 945, 1);
#line 24 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 935, item.Name, 935, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(946, 80, true);
            WriteLiteral(" />\r\n\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n");
            EndContext();
#line 28 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                         if (item.IsActive == true)
                        {

#line default
#line hidden
            BeginContext(1106, 191, true);
            WriteLiteral("                            <i title=\"Active\" class=\"material-tooltip-main text-success fas fa-check-circle\" data-toggle=\"tooltip\" style=\"font-size:20px;\"><span class=\"sr-only\">1</span></i>\r\n");
            EndContext();
#line 31 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1381, 192, true);
            WriteLiteral("                            <i title=\"Inactive\" class=\"material-tooltip-main text-danger fas fa-times-circle\" data-toggle=\"tooltip\" style=\"font-size:20px;\"><span class=\"sr-only\">0</span></i>\r\n");
            EndContext();
#line 35 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                        }

#line default
#line hidden
            BeginContext(1600, 185, true);
            WriteLiteral("                    </td>\r\n                    <td>\r\n\r\n\r\n                        <button class=\"material-tooltip-main btn-primary btn-floating btn-sm\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1785, "\"", 1809, 1);
#line 40 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1790, item.Id + "edit", 1790, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1810, "\"", 1849, 3);
            WriteAttributeValue("", 1820, "javascript:editDept(", 1820, 20, true);
#line 40 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 1840, item.Id, 1840, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1848, ")", 1848, 1, true);
            EndWriteAttribute();
            BeginContext(1850, 250, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-pencil-alt\"></i>\r\n                        </button>\r\n\r\n\r\n                        <button class=\"material-tooltip-main btn-danger btn-floating my-0 p-0 btn-sm d-none\" data-toggle=\"tooltip\" title=\"Cancel\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2100, "\"", 2126, 1);
#line 45 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 2105, item.Id + "cancle", 2105, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2127, "\"", 2157, 3);
            WriteAttributeValue("", 2137, "cancleDept(", 2137, 11, true);
#line 45 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 2148, item.Id, 2148, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2156, ")", 2156, 1, true);
            EndWriteAttribute();
            BeginContext(2158, 233, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-times\"></i>\r\n                        </button>\r\n\r\n                        <button class=\"material-tooltip-main btn-success btn-floating btn-sm d-none\" data-toggle=\"tooltip\" title=\"Save\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2391, "\"", 2415, 1);
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 2396, item.Id + "save", 2396, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2416, "\"", 2444, 3);
            WriteAttributeValue("", 2426, "saveDept(", 2426, 9, true);
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 2435, item.Id, 2435, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 2443, ")", 2443, 1, true);
            EndWriteAttribute();
            BeginContext(2445, 102, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-check\"></i>\r\n                        </button>\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(2818, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                         if (item.IsActive == true)
                        {

#line default
#line hidden
            BeginContext(2900, 137, true);
            WriteLiteral("                            <button class=\"material-tooltip-main btn-danger btn-floating btn-sm\" data-toggle=\"tooltip\" title=\"Deactivate\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3037, "\"", 3071, 3);
            WriteAttributeValue("", 3047, "deactivateDept(", 3047, 15, true);
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 3062, item.Id, 3062, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3070, ")", 3070, 1, true);
            EndWriteAttribute();
            BeginContext(3072, 103, true);
            WriteLiteral(">\r\n                                <i class=\"fas fa-lock\"></i>\r\n                            </button>\r\n");
            EndContext();
#line 64 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3259, 136, true);
            WriteLiteral("                            <button class=\"material-tooltip-main btn-success btn-floating btn-sm\" data-toggle=\"tooltip\" title=\"Activate\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3395, "\"", 3427, 3);
            WriteAttributeValue("", 3405, "activateDept(", 3405, 13, true);
#line 67 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
WriteAttributeValue("", 3418, item.Id, 3418, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3426, ")", 3426, 1, true);
            EndWriteAttribute();
            BeginContext(3428, 108, true);
            WriteLiteral(">\r\n                                <i class=\"fas fa-lock-open\"></i>\r\n                            </button>\r\n");
            EndContext();
#line 70 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"

                        }

#line default
#line hidden
            BeginContext(3565, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 76 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"



            }

#line default
#line hidden
#line 79 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
             
        }
        else
        {

#line default
#line hidden
            BeginContext(3676, 44, true);
            WriteLiteral("            <tr> Not found Department</tr>\r\n");
            EndContext();
#line 84 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Department\_departmentList.cshtml"
        }

#line default
#line hidden
            BeginContext(3731, 754, true);
            WriteLiteral(@"
    </tbody>
</table>

<script>
    $(document).ready(function () {
        $('.material-tooltip-main').tooltip({
            //template: '<div class=""tooltip md-tooltip""><div class=""tooltip-arrow md-arrow""></div><div class=""tooltip-inner md-inner""></div></div>'
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
            ],
            ""autoWidth"": false
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

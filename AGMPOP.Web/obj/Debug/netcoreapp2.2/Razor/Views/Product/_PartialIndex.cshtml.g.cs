#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "818e395632cb7fdef33462c0c908d47e80e94a0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__PartialIndex), @"mvc.1.0.view", @"/Views/Product/_PartialIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/_PartialIndex.cshtml", typeof(AspNetCore.Views_Product__PartialIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"818e395632cb7fdef33462c0c908d47e80e94a0c", @"/Views/Product/_PartialIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__PartialIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 131, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-12 text-right mb-2\">\r\n        <button type=\"button\" class=\"btn btn-outline-success btn-md\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 184, "\"", 249, 3);
            WriteAttributeValue("", 194, "location.href=\'", 194, 15, true);
#line 5 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 209, Url.Action("ImportProduct", "Product"), 209, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 248, "\'", 248, 1, true);
            EndWriteAttribute();
            BeginContext(250, 95, true);
            WriteLiteral(">\r\n            <b>Import</b>&nbsp;&nbsp;<i class=\"fas fa-arrow-down\"> </i>\r\n        </button>\r\n");
            EndContext();
#line 8 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
         if (Model?.Count > 0)
        {

#line default
#line hidden
            BeginContext(388, 186, true);
            WriteLiteral("            <button type=\"button\" class=\"btn btn-success btn-md\" onclick=\"ExportProdcut()\">\r\n                Export&nbsp;&nbsp;<i class=\"fas fa-file-excel\"> </i>\r\n            </button>\r\n");
            EndContext();
#line 13 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
        }

#line default
#line hidden
            BeginContext(585, 819, true);
            WriteLiteral(@"        <hr />
    </div>
    <div class=""col-md-12"">
        <div class="""">
            <table id=""dtBasicExample"" class=""table table-responsive-sm  table-striped "" cellspacing=""0"">
                <thead>
                    <tr>
                        <th data-sortable=""false"" data-field=""photo""></th>
                        <th data-field=""name"" data-sortable=""true"" "">Name</th>
                        <th data-field=""code"" class=""text-center"">Code</th>
                        <th data-field=""DepartmentId"" class=""text-center"">Department</th>
                        <th data-field=""TypeId"" class=""text-center"">Status</th>
                        <th data-sortable=""false"" class=""td-actions text-center"">Actions</th>
                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 31 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                      
                        if (Model?.Count > 0)
                        {

                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1592, 175, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <div class=\"img-circle product-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1767, "\"", 1830, 3);
            WriteAttributeValue("", 1775, "background-image:url(\'", 1775, 22, true);
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 1797, item.Image.Replace(@"\", "/"), 1797, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 1827, "\');", 1827, 3, true);
            EndWriteAttribute();
            BeginContext(1831, 184, true);
            WriteLiteral(" />\r\n\r\n                                    </td>\r\n                                    <td>\r\n                                        <b><a class=\"btn-link font-weight-bold text-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2015, "\"", 2060, 3);
            WriteAttributeValue("", 2025, "ShowProductDetails(", 2025, 19, true);
#line 43 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 2044, item.ProductId, 2044, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2059, ")", 2059, 1, true);
            EndWriteAttribute();
            BeginContext(2061, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2063, 16, false);
#line 43 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                                                                                                                      Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2079, 157, true);
            WriteLiteral("</a></b>\r\n\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(2237, 9, false);
#line 47 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                   Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(2246, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(2394, 19, false);
#line 50 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                   Write(item.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(2413, 107, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 53 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                         if (item.IsActive == true)
                                        {

#line default
#line hidden
            BeginContext(2632, 207, true);
            WriteLiteral("                                            <i title=\"Active\" class=\"material-tooltip-main text-success fas fa-check-circle\" data-toggle=\"tooltip\" style=\"font-size:20px;\"><span class=\"sr-only\">1</span></i>\r\n");
            EndContext();
#line 56 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(2971, 208, true);
            WriteLiteral("                                            <i title=\"Inactive\" class=\"material-tooltip-main text-danger fas fa-times-circle\" data-toggle=\"tooltip\" style=\"font-size:20px;\"><span class=\"sr-only\">0</span></i>\r\n");
            EndContext();
#line 60 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3222, 253, true);
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n\r\n\r\n                                        <button class=\"material-tooltip-main btn-primary btn-floating btn-sm\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3475, "\"", 3506, 3);
            WriteAttributeValue("", 3485, "Edit(", 3485, 5, true);
#line 65 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 3490, item.ProductId, 3490, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3505, ")", 3505, 1, true);
            EndWriteAttribute();
            BeginContext(3507, 134, true);
            WriteLiteral(">\r\n                                            <i class=\"fas fa-pencil-alt \"></i>\r\n                                        </button>\r\n");
            EndContext();
#line 68 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                         if (item.IsActive)
                                        {

#line default
#line hidden
            BeginContext(3745, 168, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-danger btn-floating btn-sm btnDectivation\" data-toggle=\"tooltip\" title=\"Deactivate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3913, "\"", 3936, 1);
#line 70 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 3921, item.ProductId, 3921, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3937, 135, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-lock\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 73 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"


                                        }
                                        else
                                        {


#line default
#line hidden
            BeginContext(4210, 166, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-success btn-floating btn-sm btnActivation\" data-toggle=\"tooltip\" title=\"Activate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4376, "\"", 4399, 1);
#line 79 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 4384, item.ProductId, 4384, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4400, 140, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-lock-open\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 82 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"

                                        }

#line default
#line hidden
            BeginContext(4585, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 86 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4784, 210, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"6\">\r\n                                    data Not Found\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 96 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(5044, 155, true);
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n        </div><!--  end card  -->\r\n\r\n\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n");
            EndContext();
            BeginContext(5215, 399, true);
            WriteLiteral(@"<script type=""text/javascript"">

    $(document).ready(function () {
        $('#dtBasicExample').DataTable({
            ""autoWidth"": false
        });

        //activate the tooltips after the data table is initialized
        $('[rel=""tooltip""]').tooltip();

        $(window).resize(function () {
            $table.bootstrapTable('resetView');
        });
    });

</script>

");
            EndContext();
            BeginContext(5635, 560, true);
            WriteLiteral(@"
<script type=""text/javascript"">
    $(function () {
        $('.material-tooltip-main').tooltip();
    })


            $("".btnActivation"").click(function (e) {
                var ProductId = $(this).val();

                Swal.fire({
                     text: ""Are you sure you want to activate this product?"",
                    icon: 'question',
                    showCancelButton: true,
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: '");
            EndContext();
            BeginContext(6196, 33, false);
#line 145 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                             Write(Url.Action("activate", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(6229, 1096, true);
            WriteLiteral(@"',
                            data: { ProductId },
                            type: ""Post"",
                            success: function (data) {
                            },

                        });

                        Swal.fire({
                            text: 'Your Product has been Activated',
                            icon: 'success',
                        }
                        ).then(
                            function () {
                                loadProduct();

                            }
                        );

                    }
                })

            })



            $("".btnDectivation"").click(function (e) {
                var ProductId = $(this).val();
                Swal.fire({
                    text: ""Are you sure you want to deactivate this product?"",
                    icon: 'question',
                    showCancelButton: true,
                }).then((result) => {
                    if (result.value)");
            WriteLiteral(" {\r\n                        $.ajax({\r\n                            url: \'");
            EndContext();
            BeginContext(7326, 35, false);
#line 180 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                             Write(Url.Action("Deactivate", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(7361, 661, true);
            WriteLiteral(@"',
                            data: { ProductId },
                            type: ""Post"",
                            success: function (data) {
                            },
                        });
                        Swal.fire({
                           text: 'Your Product has been Deactivated',
                            icon:'success',
                        }
                        ).then(
                            function () {
                                loadProduct();

                            }
                        );

                    }

                })

            })


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AGMPOP.BL.Models.ViewModels.ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591

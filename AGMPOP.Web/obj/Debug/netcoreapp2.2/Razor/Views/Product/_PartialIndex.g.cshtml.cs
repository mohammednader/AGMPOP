#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c7321bfd1194438b5d3de632c1d782137ef1112"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7321bfd1194438b5d3de632c1d782137ef1112", @"/Views/Product/_PartialIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__PartialIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 204, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12 text-right mb-2\">\r\n\r\n\r\n        <button type=\"button\" class=\"material-tooltip-main mr-0 btn btn-default   text-center mt-0 mb-0 px-3 waves-effect waves-light \"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 257, "\"", 322, 3);
            WriteAttributeValue("", 267, "location.href=\'", 267, 15, true);
#line 8 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 282, Url.Action("ImportProduct", "Product"), 282, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 321, "\'", 321, 1, true);
            EndWriteAttribute();
            BeginContext(323, 157, true);
            WriteLiteral(">\r\n            Import&nbsp; <i class=\"fal fa-arrow-up fa-align-center \" style=\"vertical-align: middle !important; font-size:20px;\"> </i>\r\n        </button>\r\n");
            EndContext();
#line 11 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
         if (Model?.Count > 0)
        {

#line default
#line hidden
            BeginContext(523, 354, true);
            WriteLiteral(@"        <button type=""button"" class=""material-tooltip-main  btn mr-0  text-center mb-0 mt-0 px-3 waves-effect waves-light"" style=""background-color:#080a2e; color:white;"" onclick=""ExportProdcut()"">
            Export&nbsp; <i class=""fal fa-arrow-down fa-align-center "" style=""vertical-align: middle !important; font-size:20px;""> </i>
        </button>
");
            EndContext();
#line 16 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
        }

#line default
#line hidden
            BeginContext(888, 658, true);
            WriteLiteral(@"    </div>

</div>



<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-body"">



            <table id=""dtBasicExample"" class=""table   table-responsive-sm   table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                <thead>
                    <tr>
                        <th data-field=""photo"" class=""text-center"">Photo</th>
                        <th data-field=""name"" data-sortable=""true"" class=""w-25 text-center"">Name</th>
                        <th data-field=""code"" class=""text-center"">Code</th>
                        <th data-field=""DepartmentId"" class=""text-center"">Department</th>
");
            EndContext();
            BeginContext(1629, 174, true);
            WriteLiteral("                        <th class=\"td-actions text-center\" style=\"width:300px;\">Actions</th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n\r\n");
            EndContext();
#line 42 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                      
                        if (Model ?.Count>0)
                        {

                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1990, 236, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <div class=\"img-container\">\r\n                                            <img class=\"img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 2226, "\"", 2243, 1);
#line 51 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 2232, item.Image, 2232, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2244, 318, true);
            WriteLiteral(@" style=""border-radius:5%;height:40px; width:40px;"" />
                                        </div>
                                    </td>
                                    <td class=""text-center"">
                                        <a class=""btn-link font-weight-bold"" style=""text-decoration:underline""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2562, "\"", 2607, 3);
            WriteAttributeValue("", 2572, "ShowProductDetails(", 2572, 19, true);
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 2591, item.ProductId, 2591, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2606, ")", 2606, 1, true);
            EndWriteAttribute();
            BeginContext(2608, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2610, 16, false);
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                                                                                                                                        Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2626, 153, true);
            WriteLiteral("</a>\r\n\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(2780, 9, false);
#line 59 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                   Write(item.Code);

#line default
#line hidden
            EndContext();
            BeginContext(2789, 147, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        ");
            EndContext();
            BeginContext(2937, 19, false);
#line 62 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                   Write(item.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(2956, 51, true);
            WriteLiteral("\r\n\r\n\r\n                                    </td>\r\n\r\n");
            EndContext();
            BeginContext(3543, 217, true);
            WriteLiteral("                                    <td class=\"text-center\">\r\n\r\n\r\n                                        <button class=\"material-tooltip-main btn-primary  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3760, "\"", 3791, 3);
            WriteAttributeValue("", 3770, "Edit(", 3770, 5, true);
#line 83 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 3775, item.ProductId, 3775, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3790, ")", 3790, 1, true);
            EndWriteAttribute();
            BeginContext(3792, 169, true);
            WriteLiteral(">\r\n                                            <i class=\"fas fa-edit \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                        </button>\r\n");
            EndContext();
#line 86 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                                         if (item.IsActive)
                                        {

#line default
#line hidden
            BeginContext(4065, 175, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn btn-success btn-floating my-0 p-0 btnDectivation\" data-toggle=\"tooltip\" title=\"Deactivate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4240, "\"", 4263, 1);
#line 88 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 4248, item.ProductId, 4248, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4264, 182, true);
            WriteLiteral(">\r\n                                                <i class=\"fad fa-user-check\" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 91 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"


                                        }
                                        else
                                        {


#line default
#line hidden
            BeginContext(4584, 171, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn btn-danger btn-floating my-0 p-0 btnActivation\" data-toggle=\"tooltip\" title=\"activate\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 4755, "\"", 4778, 1);
#line 97 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
WriteAttributeValue("", 4763, item.ProductId, 4763, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4779, 183, true);
            WriteLiteral(">\r\n                                                <i class=\"fad fa-user-times \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 100 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"

                                        }

#line default
#line hidden
            BeginContext(5007, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 104 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5206, 210, true);
            WriteLiteral("                            <tr>\r\n                                <td colspan=\"6\">\r\n                                    data Not Found\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 114 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(5466, 155, true);
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n        </div><!--  end card  -->\r\n\r\n\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n");
            EndContext();
            BeginContext(5637, 1183, true);
            WriteLiteral(@"<script type=""text/javascript"">
    $(function () {
        $('.material-tooltip-main').tooltip();
    })
    var $table = $('#cycles-table');
    $table.bootstrapTable({
        toolbar: "".toolbar"",
        clickToSelect: true,
        //showRefresh: true,
        search: true,
        //showToggle: true,
        //showColumns: true,
        pagination: true,
        searchAlign: 'left',
        pageSize: 8,
        clickToSelect: false,
        pageList: [8, 10, 25, 50, 100],

        formatShowingRows: function (pageFrom, pageTo, totalRows) {
            //do nothing here, we don't want to show the text ""showing x of y from...""
        },
        formatRecordsPerPage: function (pageNumber) {
            return pageNumber + "" rows visible"";
        },
        icons: {
            columns: 'fa-columns'
        }
    });

    $(document).ready(function () {
        $('#dtBasicExample').DataTable();

        //activate the tooltips after the data table is initialized
        $(");
            WriteLiteral("\'[rel=\"tooltip\"]\').tooltip();\r\n\r\n        $(window).resize(function () {\r\n            $table.bootstrapTable(\'resetView\');\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n");
            EndContext();
            BeginContext(6841, 675, true);
            WriteLiteral(@"
<script type=""text/javascript"">
        $(function () {
            $("".btnActivation"").click(function (e) {
                var ProductId = $(this).val();

                Swal.fire({
                     text: ""Are you sure you want to activate this product?"",
                    icon: 'question',
                    showCancelButton: true,
                    confirmButtonColor: '#4285f4',
                    cancelButtonColor: '#a1a1a1',
                    confirmButtonText: 'Ok' 
                    
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: '");
            EndContext();
            BeginContext(7517, 33, false);
#line 188 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                             Write(Url.Action("activate", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(7550, 1299, true);
            WriteLiteral(@"',
                            data: { ProductId },
                            type: ""Post"",
                            success: function (data) {
                            },

                        });

                        Swal.fire(
                            'Activate!',
                            'Your Product has been Activate.',
                            'success',
                        ).then(
                            function () {
                                loadProduct();

                            }
                        );

                    }
                })

            })
        })

        $(function () {
            $("".btnDectivation"").click(function (e) {
                var ProductId = $(this).val();
                Swal.fire({
                    text: ""Are you sure you want to deactivate this product?"",
                    icon: 'question',                    
                    showCancelButton: true,
                    c");
            WriteLiteral(@"onfirmButtonColor: '#4285f4',
                    cancelButtonColor: '#a1a1a1',
                    confirmButtonText: 'Ok'
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: '");
            EndContext();
            BeginContext(8850, 35, false);
#line 226 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\_PartialIndex.cshtml"
                             Write(Url.Action("Deactivate", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(8885, 677, true);
            WriteLiteral(@"',
                            data: { ProductId },
                            type: ""Post"",
                            success: function (data) {
                            },
                        });
                        Swal.fire(
                            'Deactivate!',
                            'Your Product has been Deactivate.',
                            'success',
                        ).then(
                            function () {
                                loadProduct();

                            }
                        );

                    }

                })

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

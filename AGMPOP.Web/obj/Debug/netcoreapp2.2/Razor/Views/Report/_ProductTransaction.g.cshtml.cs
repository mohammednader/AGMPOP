#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b159ba3ed481e61bd5245c7114bd4c6bd499ae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report__ProductTransaction), @"mvc.1.0.view", @"/Views/Report/_ProductTransaction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Report/_ProductTransaction.cshtml", typeof(AspNetCore.Views_Report__ProductTransaction))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b159ba3ed481e61bd5245c7114bd4c6bd499ae5", @"/Views/Report/_ProductTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Report__ProductTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1294, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 text-right my-1 "">



        <button type=""button"" class=""material-tooltip-main  btn   text-center  px-3 waves-effect waves-light mr-0  "" style=""background-color:#080a2e; color:white;"" onclick='ExportInventory()'>
            Export&nbsp;

            <i class=""fal fa-arrow-down fa-align-center "" style=""vertical-align: middle !important; font-size:15px;""></i>
        </button>

    </div>
</div>




<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card card-body"">



            <table id=""dtBasicExample"" class=""table table-responsive-sm table-responsive-md table-striped table-bordered"" cellspacing=""0"" width=""100%"">
                <thead>
                    <tr>
                        <th data-field=""photo"" class=""text-center"">Photo</th>
                        <th data-field=""name"" data-sortable=""true"" class=""w-25 text-center"">Name</th>
                        <th data-field=""quantity"" class=""text-center"">quantity</th");
            WriteLiteral(@">
                        <th data-field=""DepartmentId"" class=""text-center"">Department</th>
                        <th class=""td-actions text-center"" style=""width:300px;"">Actions</th>

                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 39 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                      
                        if (Model != null)
                        {

                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1532, 236, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <div class=\"img-container\">\r\n                                            <img class=\"img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1768, "\"", 1785, 1);
#line 48 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 1774, item.Image, 1774, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1786, 318, true);
            WriteLiteral(@" style=""border-radius:5%;height:40px; width:40px;"" />
                                        </div>
                                    </td>
                                    <td class=""text-center"">
                                        <a class=""btn-link font-weight-bold"" style=""text-decoration:underline""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2104, "\"", 2149, 3);
            WriteAttributeValue("", 2114, "ShowProductDetails(", 2114, 19, true);
#line 52 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 2133, item.ProductId, 2133, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2148, ")", 2148, 1, true);
            EndWriteAttribute();
            BeginContext(2150, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2152, 16, false);
#line 52 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                                                                                                                                        Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2168, 51, true);
            WriteLiteral("</a>\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                     if (item.ShowUpdateBtns == false)
                                    {

#line default
#line hidden
            BeginContext(2330, 169, true);
            WriteLiteral("                                        <td>\r\n                                            <input type=\"number\" class=\"form-control\" style=\"width:250px; margin-left:10px\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2499, "\"", 2526, 1);
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 2507, item.InventoryQnty, 2507, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2527, "\"", 2547, 1);
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 2532, item.ProductId, 2532, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2548, "\"", 2593, 3);
            WriteAttributeValue("", 2558, "changeQuantity(", 2558, 15, true);
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 2573, item.InventoryQnty, 2573, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2592, ")", 2592, 1, true);
            EndWriteAttribute();
            BeginContext(2594, 88, true);
            WriteLiteral(" disabled />\r\n                                            <input id=\"temp\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2682, "\"", 2709, 1);
#line 59 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 2690, item.InventoryQnty, 2690, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2710, 52, true);
            WriteLiteral(" />\r\n                                        </td>\r\n");
            EndContext();
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2882, 113, true);
            WriteLiteral("                                        <td class=\"text-center\">\r\n                                            <p>");
            EndContext();
            BeginContext(2996, 18, false);
#line 65 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                          Write(item.InventoryQnty);

#line default
#line hidden
            EndContext();
            BeginContext(3014, 53, true);
            WriteLiteral("</p>\r\n                                        </td>\r\n");
            EndContext();
#line 67 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3106, 107, true);
            WriteLiteral("                                    <td class=\"text-center\">\r\n\r\n                                        <p>");
            EndContext();
            BeginContext(3214, 19, false);
#line 70 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                      Write(item.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(3233, 159, true);
            WriteLiteral("</p>\r\n\r\n                                    </td>\r\n\r\n\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3392, "\"", 3478, 1);
#line 76 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 3399, Url.Action("TransactionProductDetails", "Report", new { id = item.ProductId }), 3399, 79, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3479, 214, true);
            WriteLiteral(" target=\"_blank\" class=\"material-tooltip-main btn-warning  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Transactions\"> <i class=\"fas fa-info-circle \" style=\"font-size:15px; margin-top:-5px;\"></i></a>\r\n\r\n");
            EndContext();
#line 78 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                         if (item.ShowUpdateBtns == true)
                                        {


#line default
#line hidden
            BeginContext(3813, 155, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-primary  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3968, "\"", 3999, 1);
#line 81 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 3973, item.ProductId + "edit", 3973, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4000, "\"", 4046, 3);
            WriteAttributeValue("", 4010, "javascript:editQunt(", 4010, 20, true);
#line 81 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 4030, item.ProductId, 4030, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4045, ")", 4045, 1, true);
            EndWriteAttribute();
            BeginContext(4047, 177, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-edit \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
            BeginContext(4228, 163, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-danger  btn btn-floating my-0 p-0 d-none\" data-toggle=\"tooltip\" title=\"Cancel\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4391, "\"", 4424, 1);
#line 86 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 4396, item.ProductId + "cancle", 4396, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4425, "\"", 4462, 3);
            WriteAttributeValue("", 4435, "cancelQunt(", 4435, 11, true);
#line 86 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 4446, item.ProductId, 4446, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4461, ")", 4461, 1, true);
            EndWriteAttribute();
            BeginContext(4463, 185, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-times-circle \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
            BeginContext(4650, 162, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-success  btn btn-floating my-0 p-0 d-none\" data-toggle=\"tooltip\" title=\"Save\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4812, "\"", 4843, 1);
#line 90 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 4817, item.ProductId + "save", 4817, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4844, "\"", 4879, 3);
            WriteAttributeValue("", 4854, "saveQunt(", 4854, 9, true);
#line 90 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
WriteAttributeValue("", 4863, item.ProductId, 4863, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4878, ")", 4878, 1, true);
            EndWriteAttribute();
            BeginContext(4880, 177, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-save \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 93 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5100, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 96 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5299, 202, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n\r\n                                    data Not Found\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 108 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(5551, 155, true);
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n        </div><!--  end card  -->\r\n\r\n\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n");
            EndContext();
            BeginContext(5722, 1315, true);
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
            WriteLiteral(@"'[rel=""tooltip""]').tooltip();

        $(window).resize(function () {
            $table.bootstrapTable('resetView');
        });
    });

</script>

<script>
    function TransactionProduct(id) {
        window.location.href = ""Report/TransactionProductDetails/"" + id;
    }

");
            EndContext();
            BeginContext(7074, 317, true);
            WriteLiteral(@"    function editQunt(id) {

        $(""#"" + id).prop('disabled', false);
        $(""#"" + id + ""save"").toggleClass('d-inline');
        $(""#"" + id + ""edit"").toggleClass('d-none');
        $(""#"" + id + ""cancle"").toggleClass('d-inline');
        $(""#msg"").addClass('d-none');

        changeQunt(id);
    }

");
            EndContext();
            BeginContext(7429, 381, true);
            WriteLiteral(@"    function cancelQunt(id) {
        $(""#"" + id).val($(""#temp"").val());
        console.log($(""#temp"").val());
        $(""#"" + id + ""save"").toggleClass('d-inline');
        $(""#"" + id + ""edit"").toggleClass('d-none');
        $(""#"" + id + ""cancle"").toggleClass('d-inline');

        $(""#msg"").addClass('d-none');

        $(""#"" + id).prop('disabled', true);


    }

");
            EndContext();
            BeginContext(7831, 116, true);
            WriteLiteral("    function changeQunt(id) {\r\n        var change = $(\"#\" + id).val();\r\n        $(\"#temp\").val(change);\r\n\r\n    }\r\n\r\n");
            EndContext();
            BeginContext(7974, 2705, true);
            WriteLiteral(@"    function saveQunt(id) {

        if (!$(""#"" + id).val()) {

            $(""#msg"").css('display', 'inline-block');

        }
        else {
            // check two values temp vs actual
            if ($(""#"" + id).val() != $(""#temp"").val()) {
                if ($(""#"" + id).val() != null) {
                    var _parameters = { Id: id, Qunt: $(""#"" + id).val() }
                }
                else {
                    var _parameters = { Id: id }

                }
                if ($(""#temp"").val() < $(""#"" + id).val()) {
                    $.ajax({
                        url: ""/inventory/EditQuantity"",
                        type: ""GET"",
                        data: _parameters,
                        success: function (data) {
                            //  window.location.href = ""/Department/Index"";
                            if (data) {
                                if (data.success) {
                                    swal.fire({
                         ");
            WriteLiteral(@"               text: 'Your data has been updated',
                                        icon: 'success',
                                      
                                    })

                                }
                                else {
                                    swal.fire({
                                        text: data.message,
                                        icon: 'error',

                                    })

                                }

                            }


                            $(""#"" + id + ""save"").toggleClass('d-inline');
                            $(""#"" + id + ""edit"").toggleClass('d-none');
                            $(""#"" + id + ""cancle"").toggleClass('d-inline');
                            $(""#"" + id).prop('disabled', true);


                        }
                    });
                }
                else {
                    var temp = $(""#temp"").val();
                    $(""#"" + id).val(");
            WriteLiteral(@"temp);

                }
            }
            else {
                swal.fire({
                    text: 'Nothing has changed !!',
                    icon: 'info',
                    buttonsStyling: false
                });
                $(""#"" + id + ""save"").toggleClass('d-inline');
                $(""#"" + id + ""edit"").toggleClass('d-none');
                $(""#"" + id + ""cancle"").toggleClass('d-inline');
                $(""#"" + id).prop('disabled', true);



            }
        }
    }



</script>


<script>


    async function ExportInventory() {

        var now = moment().format();
         fetch('");
            EndContext();
            BeginContext(10680, 29, false);
#line 292 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Report\_ProductTransaction.cshtml"
           Write(Url.Action("ExportInventory"));

#line default
#line hidden
            EndContext();
            BeginContext(10709, 1146, true);
            WriteLiteral(@"', {
             method: 'get',

            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
        }).then(response => {
            return response.blob();
        }).then(blob => {
            if (!blob) {
                swal.fire({
                    icon: 'error',
                    text: 'No file to download',
                });
                return;
            } else if (!blob.size){
                swal.fire({
                    icon: 'error',
                    text: 'You don\'t have permission',
                });
                return;
            }
            const url = window.URL.createObjectURL(blob);
            const a = document.createElement('a');
            a.style.display = 'none';
            a.href = url;
            a.download = `Inventory_${now}.xlsx`;
            document.body.appendChild(a);
            a.click();
            window.URL.revokeObjectURL(url);
            }).catch(err => {
                swal.fire({
     ");
            WriteLiteral("           icon: \'error\',\r\n                text: \'An error occured\',\r\n            });\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n");
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
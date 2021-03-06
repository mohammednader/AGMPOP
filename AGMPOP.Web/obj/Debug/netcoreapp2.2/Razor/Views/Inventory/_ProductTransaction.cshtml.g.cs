#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae75ca5fb151c02126f1b30a4741498ce4c43953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory__ProductTransaction), @"mvc.1.0.view", @"/Views/Inventory/_ProductTransaction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/_ProductTransaction.cshtml", typeof(AspNetCore.Views_Inventory__ProductTransaction))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae75ca5fb151c02126f1b30a4741498ce4c43953", @"/Views/Inventory/_ProductTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory__ProductTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 974, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-12 text-right"">
        <button type=""button"" class=""btn btn-success btn-md"" onclick='ExportInventory()'>
            Export&nbsp;

            <i class=""fas fa-file-excel"" ></i>
        </button>
        <hr />
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12"">
            <table id=""dtBasicExample"" class=""table table-responsive-sm table-striped"" cellspacing=""0"" >
                <thead>
                    <tr>
                        <th data-sortable=""false"" data-field=""photo"" class=""text-center""></th>
                        <th data-field=""name"" data-sortable=""true"">Name</th>
                        <th data-field=""quantity"">quantity</th>
                        <th data-field=""DepartmentId"">Department</th>
                        <th class=""td-actions text-center"" data-sortable=""false"">Actions</th>

                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 29 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                      
                        if (Model != null)
                        {

                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1212, 175, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <div class=\"img-circle product-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1387, "\"", 1450, 3);
            WriteAttributeValue("", 1395, "background-image:url(\'", 1395, 22, true);
#line 37 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 1417, item.Image.Replace(@"\", "/"), 1417, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 1447, "\');", 1447, 3, true);
            EndWriteAttribute();
            BeginContext(1451, 165, true);
            WriteLiteral(" />\r\n                                    </td>\r\n                                    <td>\r\n                                        <b><a class=\"btn-link text-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1616, "\"", 1661, 3);
            WriteAttributeValue("", 1626, "ShowProductDetails(", 1626, 19, true);
#line 40 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 1645, item.ProductId, 1645, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1660, ")", 1660, 1, true);
            EndWriteAttribute();
            BeginContext(1662, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1664, 16, false);
#line 40 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                                                                                                     Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1680, 55, true);
            WriteLiteral("</a></b>\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 43 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                     if (item.ShowUpdateBtns == true)
                                    {

#line default
#line hidden
            BeginContext(1845, 237, true);
            WriteLiteral("                                        <td>\r\n                                            <input type=\"number\" class=\"form-control\" data-toggle=\"tooltip\" title=\"Please enter greater than this number\" style=\"width:250px; margin-left:10px\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2082, "\"", 2109, 1);
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2090, item.InventoryQnty, 2090, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2110, "\"", 2130, 1);
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2115, item.ProductId, 2115, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2131, "\"", 2176, 3);
            WriteAttributeValue("", 2141, "changeQuantity(", 2141, 15, true);
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2156, item.InventoryQnty, 2156, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2175, ")", 2175, 1, true);
            EndWriteAttribute();
            BeginContext(2177, 88, true);
            WriteLiteral(" disabled />\r\n                                            <input id=\"temp\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2265, "\"", 2292, 1);
#line 47 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2273, item.InventoryQnty, 2273, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2293, 52, true);
            WriteLiteral(" />\r\n                                        </td>\r\n");
            EndContext();
#line 49 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2465, 93, true);
            WriteLiteral("                                        <td>\r\n                                            <p>");
            EndContext();
            BeginContext(2559, 18, false);
#line 53 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                          Write(item.InventoryQnty);

#line default
#line hidden
            EndContext();
            BeginContext(2577, 53, true);
            WriteLiteral("</p>\r\n                                        </td>\r\n");
            EndContext();
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2669, 87, true);
            WriteLiteral("                                    <td>\r\n\r\n                                        <p>");
            EndContext();
            BeginContext(2757, 19, false);
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                      Write(item.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(2776, 161, true);
            WriteLiteral("</p>\r\n\r\n                                    </td>\r\n\r\n\r\n                                    <td class=\"text-center\">\r\n\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2937, "\"", 3026, 1);
#line 65 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2944, Url.Action("TransactionProductDetails", "Inventory", new { id = item.ProductId }), 2944, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3027, 207, true);
            WriteLiteral(" target=\"_blank\" class=\"material-tooltip-main btn-warning btn-floating btn-sm m-1\" data-toggle=\"tooltip\" title=\"View Transaction\">\r\n                                        <i class=\"fas fa-list\"></i></a>\r\n\r\n");
            EndContext();
#line 68 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                         if (item.ShowUpdateBtns == true)
                                        {


#line default
#line hidden
            BeginContext(3354, 152, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-primary btn-floating btn-sm m-1\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3506, "\"", 3537, 1);
#line 71 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 3511, item.ProductId + "edit", 3511, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3538, "\"", 3584, 3);
            WriteAttributeValue("", 3548, "javascript:editQunt(", 3548, 20, true);
#line 71 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 3568, item.ProductId, 3568, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3583, ")", 3583, 1, true);
            EndWriteAttribute();
            BeginContext(3585, 141, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-pencil-alt\"></i>\r\n                                            </button>\r\n");
            EndContext();
            BeginContext(3730, 161, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-danger  btn-floating btn-sm d-none m-1\" data-toggle=\"tooltip\" title=\"Cancel\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 3891, "\"", 3924, 1);
#line 76 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 3896, item.ProductId + "cancle", 3896, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 3925, "\"", 3962, 3);
            WriteAttributeValue("", 3935, "cancelQunt(", 3935, 11, true);
#line 76 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 3946, item.ProductId, 3946, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3961, ")", 3961, 1, true);
            EndWriteAttribute();
            BeginContext(3963, 136, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-times\"></i>\r\n                                            </button>\r\n");
            EndContext();
            BeginContext(4101, 159, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-success btn-floating btn-sm d-none m-1\" data-toggle=\"tooltip\" title=\"Save\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4260, "\"", 4291, 1);
#line 80 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 4265, item.ProductId + "save", 4265, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4292, "\"", 4327, 3);
            WriteAttributeValue("", 4302, "saveQunt(", 4302, 9, true);
#line 80 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 4311, item.ProductId, 4311, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4326, ")", 4326, 1, true);
            EndWriteAttribute();
            BeginContext(4328, 136, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-check\"></i>\r\n                                            </button>\r\n");
            EndContext();
#line 83 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                        }

#line default
#line hidden
            BeginContext(4507, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 86 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4706, 202, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n\r\n                                    data Not Found\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 98 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(4958, 112, true);
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n");
            EndContext();
            BeginContext(5086, 1260, true);
            WriteLiteral(@"<script type=""text/javascript"">
   
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
        $('[rel=""tooltip""]').tooltip();

        $(window).resize(function () {");
            WriteLiteral("\n            $table.bootstrapTable(\'resetView\');\r\n        });\r\n    });\r\n\r\n</script>\r\n\r\n<script>\r\n    var show = 0;\r\n    function TransactionProduct(id) {\r\n\r\n        window.location.href = \"Inventory/TransactionProductDetails/\" + id;\r\n\r\n");
            EndContext();
            BeginContext(6661, 11, true);
            WriteLiteral("\r\n    }\r\n\r\n");
            EndContext();
            BeginContext(6709, 396, true);
            WriteLiteral(@"    function editQunt(id) {
        if (show == 0) {
            $(""#"" + id).prop('disabled', false);
            $(""#"" + id + ""save"").toggleClass('d-inline');
            $(""#"" + id + ""edit"").toggleClass('d-none');
            $(""#"" + id + ""cancle"").toggleClass('d-inline');
            $(""#msg"").addClass('d-none');

            changeQunt(id);
        }
         show = 1;
    }

");
            EndContext();
            BeginContext(7143, 400, true);
            WriteLiteral(@"    function cancelQunt(id) {
        $(""#"" + id).val($(""#temp"").val());
        console.log($(""#temp"").val());
        $(""#"" + id + ""save"").toggleClass('d-inline');
        $(""#"" + id + ""edit"").toggleClass('d-none');
        $(""#"" + id + ""cancle"").toggleClass('d-inline');

        $(""#msg"").addClass('d-none');

        $(""#"" + id).prop('disabled', true);
          show = 0;

    }

");
            EndContext();
            BeginContext(7564, 116, true);
            WriteLiteral("    function changeQunt(id) {\r\n        var change = $(\"#\" + id).val();\r\n        $(\"#temp\").val(change);\r\n\r\n    }\r\n\r\n");
            EndContext();
            BeginContext(7707, 2933, true);
            WriteLiteral(@"    function saveQunt(id) {
        show = 0;
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
            WriteLiteral(@"                                text: 'Your data has been updated',
                                        icon: 'success',
                                       
                                    })

                                }
                                else {
                                     var temp = $(""#temp"").val();
                                     $(""#"" + id).val(temp);
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
       ");
            WriteLiteral(@"             });
                }
                else {
                    var temp = $(""#temp"").val();
                    $(""#"" + id).val(temp);

                }
            }
            else {
                swal.fire({
                    text: 'Nothing has changed !!',
                    icon: 'info',
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
    $(function () {
        $('.material-tooltip-main').tooltip();
    })

    async function ExportInventory() {

        var now = moment().format();
        var form = $('#inventory').serialize();
         fetch('");
            EndContext();
            BeginContext(10641, 29, false);
#line 296 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
           Write(Url.Action("ExportInventory"));

#line default
#line hidden
            EndContext();
            BeginContext(10670, 1152, true);
            WriteLiteral(@"?'+form, {
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
                swal.fire({");
            WriteLiteral("\n                icon: \'error\',\r\n                text: \'An error occured\',\r\n            });\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n");
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

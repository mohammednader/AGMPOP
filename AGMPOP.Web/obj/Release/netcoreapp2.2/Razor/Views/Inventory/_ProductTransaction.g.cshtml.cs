#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a37703745c1b508bd7284ab9842d2f4f2386a72"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a37703745c1b508bd7284ab9842d2f4f2386a72", @"/Views/Inventory/_ProductTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory__ProductTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AGMPOP.BL.Models.ViewModels.ProductDTO>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 1387, true);
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-12 text-right "">



        <button type=""button"" class=""material-tooltip-main  btn btn-brown  text-center  px-3 waves-effect waves-light mr-0 mb-2"" onclick='ExportInventory()'>
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
                        <th data-field=""quantity"" class=""text-center"">quantity</th>
                        <th data-fi");
            WriteLiteral(@"eld=""DepartmentId"" class=""text-center"">Department</th>
                        <th data-field=""TypeId"" class=""text-center"">Type</th>
                        
                            <th class=""td-actions text-center"" style=""width:300px;"">Actions</th>
                      
                    </tr>
                </thead>
                <tbody>

");
            EndContext();
#line 42 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                      
                        if (Model != null)
                        {

                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1625, 236, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"text-center\">\r\n                                        <div class=\"img-container\">\r\n                                            <img class=\"img-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1861, "\"", 1878, 1);
#line 51 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 1867, item.Image, 1867, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1879, 318, true);
            WriteLiteral(@" style=""border-radius:5%;height:40px; width:40px;"" />
                                        </div>
                                    </td>
                                    <td class=""text-center"">
                                        <a class=""btn-link font-weight-bold"" style=""text-decoration:underline""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2197, "\"", 2242, 3);
            WriteAttributeValue("", 2207, "ShowProductDetails(", 2207, 19, true);
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2226, item.ProductId, 2226, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2241, ")", 2241, 1, true);
            EndWriteAttribute();
            BeginContext(2243, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2245, 16, false);
#line 55 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                                                                                                                                        Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2261, 51, true);
            WriteLiteral("</a>\r\n\r\n                                    </td>\r\n");
            EndContext();
#line 58 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                     if (item.ShowUpdateBtns == false)
                                    {

#line default
#line hidden
            BeginContext(2423, 169, true);
            WriteLiteral("                                        <td>\r\n                                            <input type=\"number\" class=\"form-control\" style=\"width:250px; margin-left:10px\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2592, "\"", 2619, 1);
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2600, item.InventoryQnty, 2600, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 2620, "\"", 2640, 1);
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2625, item.ProductId, 2625, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2641, "\"", 2686, 3);
            WriteAttributeValue("", 2651, "changeQuantity(", 2651, 15, true);
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2666, item.InventoryQnty, 2666, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2685, ")", 2685, 1, true);
            EndWriteAttribute();
            BeginContext(2687, 88, true);
            WriteLiteral(" disabled />\r\n                                            <input id=\"temp\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2775, "\"", 2802, 1);
#line 62 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 2783, item.InventoryQnty, 2783, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2803, 52, true);
            WriteLiteral(" />\r\n                                        </td>\r\n");
            EndContext();
#line 64 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2975, 113, true);
            WriteLiteral("                                        <td class=\"text-center\">\r\n                                            <p>");
            EndContext();
            BeginContext(3089, 18, false);
#line 68 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                          Write(item.InventoryQnty);

#line default
#line hidden
            EndContext();
            BeginContext(3107, 53, true);
            WriteLiteral("</p>\r\n                                        </td>\r\n");
            EndContext();
#line 70 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3199, 107, true);
            WriteLiteral("                                    <td class=\"text-center\">\r\n\r\n                                        <p>");
            EndContext();
            BeginContext(3307, 19, false);
#line 73 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                      Write(item.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(3326, 115, true);
            WriteLiteral("</p>\r\n\r\n                                    </td>\r\n\r\n                                    <td class=\"text-center\">\r\n");
            EndContext();
#line 78 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                         if (item.typeId == 1)
                                        {

#line default
#line hidden
            BeginContext(3548, 58, true);
            WriteLiteral("                                            <p> BBO </p>\r\n");
            EndContext();
#line 81 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"


                                        }

#line default
#line hidden
            BeginContext(3653, 40, true);
            WriteLiteral("                                        ");
            EndContext();
#line 84 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                         if (item.typeId == 2)
                                        {

#line default
#line hidden
            BeginContext(3760, 63, true);
            WriteLiteral("                                            <p>  Product </p>\r\n");
            EndContext();
#line 87 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"

                                        }

#line default
#line hidden
            BeginContext(3868, 147, true);
            WriteLiteral("                                    </td>\r\n                                    <td class=\"text-center\">\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4015, "\"", 4104, 1);
#line 91 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 4022, Url.Action("TransactionProductDetails", "Inventory", new { id = item.ProductId }), 4022, 82, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4105, 213, true);
            WriteLiteral(" target=\"_blank\" class=\"material-tooltip-main btn-warning  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Transaction\"> <i class=\"fas fa-info-circle \" style=\"font-size:15px; margin-top:-5px;\"></i></a>\r\n\r\n");
            EndContext();
#line 93 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                         if (item.ShowUpdateBtns == false)
                                        {


#line default
#line hidden
            BeginContext(4439, 155, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-primary  btn btn-floating my-0 p-0\" data-toggle=\"tooltip\" title=\"Edit\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 4594, "\"", 4625, 1);
#line 96 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 4599, item.ProductId + "edit", 4599, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 4626, "\"", 4672, 3);
            WriteAttributeValue("", 4636, "javascript:editQunt(", 4636, 20, true);
#line 96 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 4656, item.ProductId, 4656, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4671, ")", 4671, 1, true);
            EndWriteAttribute();
            BeginContext(4673, 177, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-edit \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
            BeginContext(4854, 163, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-danger  btn btn-floating my-0 p-0 d-none\" data-toggle=\"tooltip\" title=\"Cancel\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5017, "\"", 5050, 1);
#line 101 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 5022, item.ProductId + "cancle", 5022, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 5051, "\"", 5088, 3);
            WriteAttributeValue("", 5061, "cancelQunt(", 5061, 11, true);
#line 101 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 5072, item.ProductId, 5072, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 5087, ")", 5087, 1, true);
            EndWriteAttribute();
            BeginContext(5089, 185, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-times-circle \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>\r\n");
            EndContext();
            BeginContext(5276, 162, true);
            WriteLiteral("                                            <button class=\"material-tooltip-main btn-success  btn btn-floating my-0 p-0 d-none\" data-toggle=\"tooltip\" title=\"Save\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 5438, "\"", 5469, 1);
#line 105 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 5443, item.ProductId + "save", 5443, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 5470, "\"", 5505, 3);
            WriteAttributeValue("", 5480, "saveQunt(", 5480, 9, true);
#line 105 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
WriteAttributeValue("", 5489, item.ProductId, 5489, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 5504, ")", 5504, 1, true);
            EndWriteAttribute();
            BeginContext(5506, 179, true);
            WriteLiteral(">\r\n                                                <i class=\"fas fa-save \" style=\"font-size:15px; margin-top:-5px;\"></i>\r\n                                            </button>  \r\n");
            EndContext();
#line 108 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                                        }

#line default
#line hidden
            BeginContext(5728, 82, true);
            WriteLiteral("                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 111 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(5927, 202, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n\r\n                                    data Not Found\r\n                                </td>\r\n\r\n                            </tr>\r\n");
            EndContext();
#line 123 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(6179, 155, true);
            WriteLiteral("                </tbody>\r\n\r\n            </table>\r\n\r\n\r\n\r\n        </div><!--  end card  -->\r\n\r\n\r\n    </div> <!-- end col-md-12 -->\r\n</div> <!-- end row -->\r\n");
            EndContext();
            BeginContext(6350, 1313, true);
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

        window.location.href = ""Inventory/TransactionProductDetails/"" + id;

");
            EndContext();
            BeginContext(7978, 11, true);
            WriteLiteral("\r\n    }\r\n\r\n");
            EndContext();
            BeginContext(8026, 317, true);
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
            BeginContext(8381, 381, true);
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
            BeginContext(8783, 116, true);
            WriteLiteral("    function changeQunt(id) {\r\n        var change = $(\"#\" + id).val();\r\n        $(\"#temp\").val(change);\r\n\r\n    }\r\n\r\n");
            EndContext();
            BeginContext(8926, 2949, true);
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
                                        confirmButtonClass: ""btn btn-primary"",
                                        buttonsStyling: false
                                    })

                                }
                                else {
                                    swal.fire({
                                        text: data.message,
                                        icon: 'error',
                                        confirmButtonClass: ""btn btn-primary"",

                                    })

                                }

                            }


                            $(""#"" + id + ""save"").toggleClass('d-inline');
                            $(""#"" + id + ""edit"").toggleClass('d-none');
                            $(""#"" + id + ""cancle"").toggleClass('d-inline');
                            $(""#"" + id).prop('disabled', true);

");
            WriteLiteral(@"
                        }
                    });
                }
                else {
                    var temp = $(""#temp"").val();
                    $(""#"" + id).val(temp);

                }
            }
            else {
                swal.fire({
                    title: 'Nothing has changed !!',
                    icon: 'info',
                    confirmButtonClass: ""btn btn-primary"",
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
            BeginContext(11876, 29, false);
#line 324 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\_ProductTransaction.cshtml"
           Write(Url.Action("ExportInventory"));

#line default
#line hidden
            EndContext();
            BeginContext(11905, 941, true);
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
                icon: 'error',
                text: 'An error occured',
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AGMPOP.BL.Models.ViewModels.ProductDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591

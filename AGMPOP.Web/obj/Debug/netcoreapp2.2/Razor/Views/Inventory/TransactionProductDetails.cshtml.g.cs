#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f54f58a281e07c0ccb6ef7cc4e6ed3e179474c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_TransactionProductDetails), @"mvc.1.0.view", @"/Views/Inventory/TransactionProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventory/TransactionProductDetails.cshtml", typeof(AspNetCore.Views_Inventory_TransactionProductDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f54f58a281e07c0ccb6ef7cc4e6ed3e179474c0c", @"/Views/Inventory/TransactionProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_TransactionProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AGMPOP.Web.Models.Inventory.InventoryTransaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
  
    if (Model?.Count() > 0)
    {
        ViewData["Title"] = "Product Transactions log";
    }
    else
    {
        ViewData["Title"] = "Transactions log";
    }
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(297, 92, true);
            WriteLiteral("\r\n<div class=\"card card-body mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n");
            EndContext();
#line 17 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
             if (Model.Count()>0)
            {

#line default
#line hidden
            BeginContext(439, 76, true);
            WriteLiteral("                <h2 class=\"mt-1\"><i class=\"fas fa-box-open\"></i>&nbsp;&nbsp;");
            EndContext();
            BeginContext(516, 42, false);
#line 19 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                                                       Write(Model.Select(f => f.Name).FirstOrDefault());

#line default
#line hidden
            EndContext();
            BeginContext(558, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 20 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(613, 102, true);
            WriteLiteral("               <h2 class=\"mt-1\"><i class=\"fas fa-box-open\"></i>&nbsp;&nbsp;Product Transactions</h2>\r\n");
            EndContext();
#line 24 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
            }

#line default
#line hidden
            BeginContext(730, 59, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-6 text-right\">\r\n");
            EndContext();
#line 27 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#line 29 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
            BeginContext(897, 248, true);
            WriteLiteral("                    <button type=\"button\" class=\"btn btn-success btn-md\" onclick=\"ExportTransactionInventory()\">\r\n                        Export&nbsp;&nbsp;\r\n                        <i class=\"fas fa-file-excel\"></i>\r\n                    </button>\r\n");
            EndContext();
#line 35 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                }

#line default
#line hidden
#line 35 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                 

            }

#line default
#line hidden
            BeginContext(1181, 856, true);
            WriteLiteral(@"
        </div>
        <div class=""col-12"">
            <hr />
        </div>
        <div class=""col-md-12"">
            <div class=""pl-2 pr-2"">
                <table id=""dtInventoryLog"" class=""table table-striped"" cellspacing=""0"">
                    <thead>
                        <tr>

                            <th class=""text-center""></th>
                            <th>Cycle Name</th>
                            <th class=""text-center"">Old Quantity</th>
                            <th class=""text-center""> Quantity</th>
                            <th class=""text-center"">New Quantity</th>

                            <th class=""text-center"">Created Date</th>
                            <th class=""text-center"">Created By</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 61 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                         if (Model.Count()>0)
                        {

                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(2201, 153, true);
            WriteLiteral("                        <tr>\r\n\r\n                            <td class=\"text-center\">\r\n                                <div class=\"img-circle product-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2354, "\"", 2417, 3);
            WriteAttributeValue("", 2362, "background-image:url(\'", 2362, 22, true);
#line 69 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
WriteAttributeValue("", 2384, item.image.Replace(@"\", "/"), 2384, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 2414, "\');", 2414, 3, true);
            EndWriteAttribute();
            BeginContext(2418, 76, true);
            WriteLiteral(" />\r\n\r\n                                <input type=\"text\" id=\"tempProductId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2494, "\"", 2517, 1);
#line 71 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
WriteAttributeValue("", 2502, item.ProductId, 2502, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2518, 117, true);
            WriteLiteral(" hidden />\r\n                            </td>\r\n                            <td>\r\n                                <b> ");
            EndContext();
            BeginContext(2636, 14, false);
#line 74 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                               Write(item.CycleName);

#line default
#line hidden
            EndContext();
            BeginContext(2650, 127, true);
            WriteLiteral("</b>\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(2778, 16, false);
#line 77 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                           Write(item.OldQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(2794, 93, true);
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td class=\"text-center\">\r\n");
            EndContext();
#line 81 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                 if (item.typeId == (int)AGMPOP.BL.Models.ViewModels.POPEnums.InventoryActionType.Increment)
                                {

#line default
#line hidden
            BeginContext(3048, 78, true);
            WriteLiteral("                                    <p class=\"text-success\">  <b >(+) </b>    ");
            EndContext();
            BeginContext(3127, 13, false);
#line 83 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                                                         Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3140, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 84 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"


                                }

#line default
#line hidden
            BeginContext(3185, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 87 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                 if (item.typeId == (int)AGMPOP.BL.Models.ViewModels.POPEnums.InventoryActionType.Decrement)
                                {

#line default
#line hidden
            BeginContext(3346, 74, true);
            WriteLiteral("                                    <p class=\"text-danger\"><b>(-) </b>    ");
            EndContext();
            BeginContext(3421, 13, false);
#line 89 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                                                     Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3434, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 90 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"

                                }

#line default
#line hidden
            BeginContext(3478, 126, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"text-center\">\r\n                                <b>");
            EndContext();
            BeginContext(3605, 16, false);
#line 95 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                              Write(item.NewQuantity);

#line default
#line hidden
            EndContext();
            BeginContext(3621, 94, true);
            WriteLiteral("</b>\r\n                            </td>\r\n                            <td class=\"text-center\"> ");
            EndContext();
            BeginContext(3716, 9, false);
#line 97 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                                Write(item.date);

#line default
#line hidden
            EndContext();
            BeginContext(3725, 61, true);
            WriteLiteral(" </td>\r\n                            <td class=\"text-center\"> ");
            EndContext();
            BeginContext(3787, 14, false);
#line 98 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                                Write(item.createdBy);

#line default
#line hidden
            EndContext();
            BeginContext(3801, 41, true);
            WriteLiteral(" </td>\r\n\r\n                        </tr>\r\n");
            EndContext();
#line 101 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"



                            }

                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3965, 180, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"text-center\" colspan=\"7\">  No transaction for this inventory </td>\r\n                            </tr>\r\n");
            EndContext();
#line 112 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"

                        }

#line default
#line hidden
            BeginContext(4174, 128, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(4318, 122, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n\r\n\r\n    $(document).ready(function () {\r\n        $(\'.material-tooltip-main\').tooltip();\r\n");
            EndContext();
#line 128 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
          if (Model.Count() > 0)
         {
        

#line default
#line hidden
            BeginContext(4500, 69, true);
            WriteLiteral(" $(\'#dtInventoryLog\').DataTable({\r\n             \"autoWidth\": false});");
            EndContext();
#line 131 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
                                         
         }

#line default
#line hidden
            BeginContext(4590, 327, true);
            WriteLiteral(@"        //activate the tooltips after the data table is initialized
        $('[rel=""tooltip""]').tooltip();

        $(window).resize(function () {
            $table.bootstrapTable('resetView');
        });

    });

</script>

<script>
    function TransactionProduct(id) {

        $.ajax({
            url: '");
            EndContext();
            BeginContext(4918, 39, false);
#line 148 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
             Write(Url.Action("TransactionProductDetails"));

#line default
#line hidden
            EndContext();
            BeginContext(4957, 481, true);
            WriteLiteral(@"',
            method: 'POST',
            data: {id},
            success: response => {
                console.log(response);

                if (response && response.length) {

                }
            }
        });

    }

</script>
<script>


    async function ExportTransactionInventory() {
        debugger;
        var id = $(""#tempProductId"").val();
        console.log(id);
        var now = moment().format();
        fetch(
            '");
            EndContext();
            BeginContext(5439, 52, false);
#line 172 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Inventory\TransactionProductDetails.cshtml"
        Write(Url.Action("ExportTransactionInventory","Inventory"));

#line default
#line hidden
            EndContext();
            BeginContext(5491, 1180, true);
            WriteLiteral(@"' + '?id=' + id, {
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
            a.download = `TranactionInventoryLog_${now}.xlsx`;
            document.body.appendChild(a);
            a.click();
            window.URL.revokeObjectURL(url);
            }).catch(err => {
        ");
            WriteLiteral("        swal.fire({\r\n                icon: \'error\',\r\n                text: \'An error occured\',\r\n            });\r\n        });\r\n    }\r\n</script>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AGMPOP.Web.Models.Inventory.InventoryTransaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04802ec0d717655b165d255b9f06c93b06e2445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CycleActions_ConfirmTransaction), @"mvc.1.0.view", @"/Views/CycleActions/ConfirmTransaction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CycleActions/ConfirmTransaction.cshtml", typeof(AspNetCore.Views_CycleActions_ConfirmTransaction))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04802ec0d717655b165d255b9f06c93b06e2445", @"/Views/CycleActions/ConfirmTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_CycleActions_ConfirmTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mobile/assets/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml"
  
    ViewData["Title"] = "New Delivery Confirmation";

#line default
#line hidden
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(65, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a04802ec0d717655b165d255b9f06c93b06e24454286", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(126, 2645, true);
            WriteLiteral(@"
<!--TOP BAR-->
<div class=""TopBar0 pl-4 mt-2"" style=""padding:10px;"">
    <div class=""row"">
        <div class=""col-8 col-lg-9 d-flex flex-column justify-items-center align-self-center cycleDetails"">

        </div>
        <div class=""col-4 col-lg-3 text-right align-self-center"">
            <!-- Horizontal Steppers -->
            <div class=""row"">
                <div class=""col-md-12"">

                </div>
            </div>
        </div>
    </div>
</div>

<!--CONTENT AFTER TOP BAR-->
<div class=""ContentAfterTopBar"">

    <div id=""div_firstForm"" style=""display:none"">
        <div class="" card card-body mb-2 pl-md-5 pr-md-5"" id=""trans_actions_container"">
            <h4 class=""text-center mb-4"">Your last clearance</h4>

        </div>
        <div class=""text-right"">
            <input class=""btn btn-primary"" type=""button"" value=""Next"" id=""btnNextid"" onclick=""Nextbtn()"" />
        </div>
    </div>


    <div class="" card card-body mb-4  pl-md-5 pr-md-5  NewDeliveryConf");
            WriteLiteral(@"irmationBBX"" style=""display:none"">

        <h4 class=""text-center mb-4"">Review & confirm  quantity</h4>

    </div>

    <div class=""viewAll text-right mt-3 mb-3"">
    </div>

</div>
<!-- MODAL -->
<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content mt-3 p-3"">
            <div class=""modal-body text-center"">
                <h3 class=""text-center""></h3>
                <button type=""button"" class=""m-1 px-3 btn btn-success"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>


<style>
    .table tbody tr td {
        vertical-align: middle;
    }

    .product-img {
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
        border: 1px solid #ccc;
        border-radius: 50%;
        height: 50px;
        width: 50px;
        margin");
            WriteLiteral(@": 0 auto;
    }
</style>


<script>
    // ================== GLOBAL VARIABLES ================== //
    var x = Object.fromEntries(new URLSearchParams(location.search));
    var CycleID = x.CycleId;
    var TransID = x.TransactionId;
    var NotificationID = x.NotificationId;

    // ================== GET NEW ITEMS TO RECIVE AND CONFIRM FUNCTION ================== //
    // second form
    function DeliveryConfirm() {
        var cycleId = CycleID;
        var TransID = x.TransactionId;
        var NotificationID = x.NotificationID;

        $.ajax({
            url: '");
            EndContext();
            BeginContext(2772, 51, false);
#line 94 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml"
             Write(Url.Action("GetTransactionDetails", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(2823, 2274, true);
            WriteLiteral(@"',
            type: ""Get"",
            data: { cycleId, TransID },
            success: response => {
                var res = response.data;

               // console.log(response);
                if (res) {
                         var header = ` <div class=""row mt-4"" >
                       <div class=""col-3 m-auto  text-center"">
                          <b>  Image </b>
                       </div>
                       <div class=""col-3 m-auto text-center"">
                          <b>  Name </b>
                       </div>
                       <div class=""col-3 m-auto text-center"">
                          <b> Code  </b>
                       </div>
                       <div class=""col-3  m-auto text-center"">
                         <b> Quantity  </b>
                       </div>
                   </div><hr />`
                $("".NewDeliveryConfirmationBBX"").append(header);

                    for (i = 0; i < res.length; i++) {
                        var ad");
            WriteLiteral(@"dDelivery = ` <div class=""row"">
                <div class=""col-3 m-auto text-center"">
                    <img src=""${res[i].productImg}"" class=""img-circle product-img"">
                </div>
                <div class=""col-3 m-auto text-center"">
                    <h6>${res[i].productName}</h6>
                </div>
                <div class=""col-3 m-auto text-center"">
                    <h6>${res[i].code}</h6>
                </div>

                <div class=""col-3 m-auto text-center"">
                    <span class=""d-inline ProductsNum"">${res[i].quantity}</span>
                </div>
            </div><hr /> `
                        $("".NewDeliveryConfirmationBBX"").append(addDelivery);
                    }

                    var ConfirmBtn =`<button class=""btn btn-primary"" onclick=""ConfirmBtn()"">Confirm</button>`
                    $("".viewAll"").append(ConfirmBtn);
                }

            },
            //ShowNotification()


        })

    }


    // ");
            WriteLiteral("================== GET CURRENT CYCLE NAME ================== //\r\n        function GetCycleName() {\r\n            var cycleId = CycleID;\r\n            var NotificationID = x.NotificationID;\r\n\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(5098, 42, false);
#line 156 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml"
             Write(Url.Action("GetCycleName", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(5140, 1130, true);
            WriteLiteral(@"',
            type: ""Get"",
            data: { cycleId },
            success: response => {
              //  console.log(response);
                var res = response;
                if (res) {
                    var cycletype = res.cycleType == 1 ? ""NationWide"" : ""Event"";
                    var Name = `<h4 style=""display:contents"">${res.name}</h4><label style=""display:contents; font-size : 16px"" > - ${cycletype}</label>
                    <label class=""mt-2"">${moment(res.startDate).format('DD/MM/YYYY HH:mm')} - ${moment(res.endDate).format('DD/MM/YYYY HH:mm')}</label>`
                    $("".cycleDetails"").append(Name);
                }
                else {
                    $("".cycleDetails"").append(""ERROR"");
                }
               // GetCycleDetails();
            },

        });

    }

    // ====================== Get current cycle details ==========================//

    function GetCycleDetails() {
        var cycleId = CycleID;
        var TransID = x");
            WriteLiteral(".TransactionId;\r\n        var NotificationID = x.NotificationID;\r\n\r\n\r\n         $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(6271, 45, false);
#line 187 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml"
             Write(Url.Action("GetCycleDetalis", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(6316, 1211, true);
            WriteLiteral(@"',
            type: ""Get"",
             data: { cycleId, TransID},
            success: response => {
             //   console.log(response);
                 var res;
                    res = response;
                    if (res) {
                        //append total items
                        var AvailableItems = `${res.allItems}`
                        $("".BigNum"").append(AvailableItems);
                        //append cycle name & date
                        var CycleDetails = ` <label>
                           ${res.user_id == userID ? `<label><b>to : </b> ${res.toUserName}</label>` : `<label><b>from: </b> ${res.fromUserName}</label>`}`
                         $("".cycleDetails"").append(CycleDetails);
                    }
                    else {
                        $("".cycleDetails"").append(""ERROR"");
                    }

                DeliveryConfirm();
             },

        });

    }

    // ================== CONFIRM FUNCTION ==================");
            WriteLiteral(" //\r\n\r\n    function ConfirmBtn() {\r\n\r\n        var obj = getFormData();\r\n        var finalObj = {clearnceData: obj }\r\n        console.log(finalObj);\r\n\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(7528, 48, false);
#line 223 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml"
             Write(Url.Action("UpdateNotification", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(7576, 5869, true);
            WriteLiteral(@"',
            type: ""POST"",
            data: finalObj,
            success: response => {

                var res;
                if (response.success) {
                    res = response;
                    if (res.message != null) {


                        $(""#exampleModal"").empty();
                        var modal = `<div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content mt-3 p-3"">
                            <div class=""modal-body text-center"">
                                <h3 class=""text-center""></h3>
                                <a class=""m-1 px-3 btn btn-success"" href=""/CycleActions/CycleTransaction?cycleId=${CycleID}"">Close</a>
                            </div>
                        </div>
                    </div> `
                        swal.fire({
                            icon: 'success',
                            text: res.message,
                            content: modal

                        }).then(fu");
            WriteLiteral(@"nction () {
                            window.location.replace(""/cycleactions/notifications"");
                         });

                     } else {
                        swal.fire({
                            icon: 'error',
                            text: res.message,
                            content: modal

                        }).then(function () {
                            window.location.replace(""/cycleactions/notifications"");
                        });

                    }
                }
            },


        });
    }


</script>

<script>


    function getUserClearanceProducts() {
        var ValArray = [], y;
        $.ajax({
            url: ""/CycleActions/GetUserClearanceProducts"",
            type: ""Get"",
            data: { CycleID, TransID },
            success: response => {
               // console.log(response);

                var res;
                res = response.data;
                if (res) {
                     ");
            WriteLiteral(@"    var header = ` <div class=""row mt-4"" >
                       <div class=""col-3 m-auto text-center"">
                          <b>  Image </b>
                       </div>
                       <div class=""col-3 m-auto text-center"">
                          <b>  Name </b>
                       </div>
                       <div class=""col-3 m-auto text-center"">
                          <b> Code  </b>
                       </div>
                       <div class=""col-3 m-auto text-center"">
                         <b> Quantity</b>
                       </div>
                   </div><hr />`
                    $(""#trans_actions_container"").append(header);

                    for (let transaction of res) {

                        var trans_action = ` <div class=""row"">
                                            <div class=""col-3 m-auto text-center"">
                                                <img src=""${transaction.productImg} class=""img-circle product-img"">
            ");
            WriteLiteral(@"                                </div>
                                            <div class=""col-3 m-auto text-center"">
                                                <h6>${transaction.productName}</h6>
                                            </div>
                                            <div class=""col-3 m-auto text-center"">
                                                <h6>${transaction.code}</h6>
                                            </div>

                                            <div class=""col-3 m-auto text-center"">
                                                <input class=""ProductCount"" id=${transaction.productId} type=""number"" data-trans=${transaction.quantity} data-product=${transaction.productId} name=""value"" maxlength=""4"" size=""1"" style=""height:40px; width:70px; text-align:center; font-size:16px; border-radius:5px;"" onkeyup=""checkValues(event)"" min=0 value=""0""> <h4 class=""d-inline"">
 / ${transaction.quantity}</h4>
                                            </d");
            WriteLiteral(@"iv>
                                        </div><hr />`
                        $(""#trans_actions_container"").append(trans_action);
                        y = `${transaction.quantity}`
                        ValArray.push(y);
                    }

                }

                else {
                    $(""#Transactions"").append(`<div class=""alert alert-dark text-center"" style=""font-size:25px;"" role=""alert"">No Actions Available !!</div>`);
                }
                $('#dtBasicExample').DataTable();
                $("".loader"").fadeOut();

            },
        });

    }



    // ================== CONFIRM WITH VALIDATION FUNCTIONS ================== //

    function GetUserInputProductNum() {
        var ProductUserInputArray = [];

        for (let item of $("".ProductCount"")) {

            var Product = $(item);
            var obj = {
                ""productId"": Product.data('product'),
                ""count"": Product.val()
            };
           ");
            WriteLiteral(@" if (obj.count > 0) {
                ProductUserInputArray.push(obj)
            }
        }
         return ProductUserInputArray;
    }

    function Nextbtn() {
        $("".NewDeliveryConfirmationBBX"").css(""display"", ""block"");
        $(""#div_firstForm"").css(""display"", ""none"")
         getFormData();
        GetCycleDetails();
    }

    function getFormData() {

        var obj = {
            ""cycle_id"": CycleID,
            ""TransactionId"": TransID,
            ""NotificationId"": NotificationID,
            ""transaction_items"": GetUserInputProductNum(),
        };
        return obj;
    }


    // ================== JQUERY ================== //
    $(document).ready(function () {
        var firstForm =  ");
            EndContext();
            BeginContext(13446, 33, false);
#line 382 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\ConfirmTransaction.cshtml"
                    Write(Json.Serialize(ViewBag.FirstForm));

#line default
#line hidden
            EndContext();
            BeginContext(13479, 598, true);
            WriteLiteral(@"
            console.log(firstForm) ;
        $('.dataTables_length').addClass('bs-select');
        $(""select"").removeClass(""custom-select"");
        $(""#AvailableActions"").hide();
        $(""#hello1"").text(""New Delivery Confirmation"");
        $("".cycleDetails"").empty();

        GetCycleName();
        if (firstForm) {

            $(""#div_firstForm"").css(""display"", ""block"");

            getUserClearanceProducts();
        }
        else {
            $("".NewDeliveryConfirmationBBX"").css(""display"", ""block"");
            DeliveryConfirm();
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

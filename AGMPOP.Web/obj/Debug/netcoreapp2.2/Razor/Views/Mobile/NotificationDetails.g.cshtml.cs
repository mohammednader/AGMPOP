#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NotificationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eef4ce7076d5156841bdff82b28bef5a681c9db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_NotificationDetails), @"mvc.1.0.view", @"/Views/Mobile/NotificationDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mobile/NotificationDetails.cshtml", typeof(AspNetCore.Views_Mobile_NotificationDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eef4ce7076d5156841bdff82b28bef5a681c9db", @"/Views/Mobile/NotificationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_NotificationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NotificationDetails.cshtml"
  
    ViewData["Title"] = "Transfer Details";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4eef4ce7076d5156841bdff82b28bef5a681c9db4237", async() => {
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
            BeginContext(117, 1483, true);
            WriteLiteral(@"
<div class=""TopBar0 pl-4"">

    <div class=""row "">
        <div class=""col-6 col-lg-8 d-flex justify-content-center flex-column  cycleDetails"">
        </div>


        <div class=""col-6 col-lg-4  text-right "">
            <span class=""pt-3 pb-3 stock-card d-flex flex-column justify-content-center align-items-center float-right"">
                <h5>Total Items</h5>
                <span class=""BigNum""></span>
            </span>
        </div>
    </div>


</div>

<div class=""ContentAfterTopBar"">
    <label class=""p-2"">Transactions Details</label>


    <div class="" card card-body mb-4  pl-md-5 pr-md-5 TransferDetails"">

    </div>

</div>


<style>
    .table tbody tr td {
        vertical-align: middle;
    }
</style>

<script>
    // ================== JQUERY ================== //
    $(document).ready(function () {
        $('.dataTables_length').addClass('bs-select');
        $(""select"").removeClass(""custom-select"");
        $(""#AvailableActions"").hide();
     ");
            WriteLiteral(@"   GetCycleName();
    });

    // ================== GLOBAL VARIABLES ================== //
    var x = Object.fromEntries(new URLSearchParams(location.search));
    var CycleID = x.CycleId;
    var NotificationID = x.NotificationId;
    var TransID = x.TransactionId;
    // ================== GET TRANSACTION DETAILS ================== //
 

        function GetCycleName() {
        var cycleId = CycleID;
        $.ajax({
            url: '");
            EndContext();
            BeginContext(1601, 42, false);
#line 62 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NotificationDetails.cshtml"
             Write(Url.Action("GetCycleName", "Notification"));

#line default
#line hidden
            EndContext();
            BeginContext(1643, 2539, true);
            WriteLiteral(@"',
            type: ""Get"",
            data: { cycleId },
            success: response => {
              //  console.log(response);
                var res = response;
                if (res) {
                    var cycletype = res.cycleType == 1 ? ""NationWide"" : ""Event"";
                    var Name = `<h2 style=""display:contents"">${res.name}</h2><label style=""display:contents; font-size : 16px"" > - ${cycletype}</label>
                    <label class=""mt-2"">${moment(res.startDate).format('DD/MM/YYYY')} - ${moment(res.endDate).format('DD/MM/YYYY')}</label>`
                    $("".cycleDetails"").append(Name);
                }
                else {
                    $("".cycleDetails"").append(""ERROR"");
                }
                DeliveryConfirm();
                GetCycleDetails();
            },

        });

    }

    //async function GetTransactionDetails() {
    //    var currLocation = await getCurrentLocation();
    //    var userlat = currLocation.latitude;
 ");
            WriteLiteral(@"   //    var userlng = currLocation.longitude;
    //    const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/"" + userID + ""/cycles/"" + CycleID;
    //    let apiResponse = await fetch(proxyurl + APIurl, {
    //        method: 'GET',
    //        headers: {
    //            'Authorization': 'Bearer ' + AccessToken,
    //            'Accept': 'application/json',
    //            'Content-Type': 'application/json',
    //            'Access-Control-Allow-Origin': '*',
    //        },
    //    });
    //    var res;
    //    if (apiResponse.ok) {
    //        res = await apiResponse.json();
    //        if (res.data) {
    //            var cycletype = res.data.type.id == 0 ? ""NW"" : ""Ev"";
    //            var CycleName = `<h2 style=""display:contents"">${res.data.name}</h2><label style=""display:contents; font-size : 16px"" > - ${cycletype}</label>
    //                <label class=""mt-2"">${moment(res.data.start_date).format('DD/MM/YYYY')} - ${moment(res.data.end_date");
            WriteLiteral(@").format('DD/MM/YYYY')}</label> `
    //            $("".cycleDetails"").append(CycleName);
    //        }
    //        else {
    //            $("".cycleDetails"").empty();
    //        }
    //    } GetProductsDetails();
    //    ShowNotification()
    //}

    // ================== GET PRODUCTS DETAILS ================== //


      function DeliveryConfirm() {
        var cycleId = CycleID;
        var TransID = x.TransactionId;

        $.ajax({
            url: '");
            EndContext();
            BeginContext(4183, 45, false);
#line 123 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NotificationDetails.cshtml"
             Write(Url.Action("GetTransactions", "Notification"));

#line default
#line hidden
            EndContext();
            BeginContext(4228, 1600, true);
            WriteLiteral(@"',
            type: ""Get"",
            data: { cycleId, TransID },
            success: response => {
                var res = response;

                 if (res) {
                    // ======== append cycle date =======
                    for (i = 0; i < res.length; i++) {
                        var Products_List = ` <div class=""row"">
                            <div class=""col-2 m-auto"">
                                <img src=""${res[i].productImg}"" style=""border-radius:50%"" width=""80"" height=""80"">
                            </div>
                            <div class=""col-3 m-auto"">
                                <h4>${res[i].productName}</h4>
                            </div>
                            <div class=""col-3 m-auto"">
                                <h4>${res[i].code}</h4>
                            </div>
                            <div class=""col-2 m-auto"">
                                <h4>${res[i].typeName}</h4>
                            </div>
    ");
            WriteLiteral(@"                        <div class=""col-2 text-center text-md-right m-auto"">
                                <span class=""ProductsNum"">${res[i].quantity}</span>
                            </div>
                        </div><hr /> `
                        $("".TransferDetails"").append(Products_List);
                    }
                }
 
            },
            //ShowNotification()


        })

    }

    function GetCycleDetails() {
        var cycleId = CycleID;
        var TransID = x.TransactionId;

         $.ajax({
            url: '");
            EndContext();
            BeginContext(5829, 45, false);
#line 166 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NotificationDetails.cshtml"
             Write(Url.Action("GetCycleDetalis", "Notification"));

#line default
#line hidden
            EndContext();
            BeginContext(5874, 4936, true);
            WriteLiteral(@"',
            type: ""Get"",
             data: { cycleId, TransID},
            success: response => {
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

             },

        });

    }


    //async function GetProductsDetails() {
    //    var currLocation = await getCurrentLocation();
    //    var userlat = currLocat");
            WriteLiteral(@"ion.latitude;
    //    var userlng = currLocation.longitude;
    //    var x = Object.fromEntries(new URLSearchParams(location.search));
    //    var CycleID = x.cycleId;
    //    var TransID = x.TransactionId;
    //    const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/"" + userID + ""/transcations/"" + TransID;

    //    let apiResponse = await fetch(proxyurl + APIurl, {
    //        method: 'GET',
    //        headers: {
    //            'Authorization': 'Bearer ' + AccessToken,
    //            'Accept': 'application/json',
    //            'Content-Type': 'application/json',
    //            'Access-Control-Allow-Origin': '*',
    //        },
    //    });

    //    var res;
    //    if (apiResponse.ok) {
    //        res = await apiResponse.json();
    //        if (res.data) {
    //            $('#cycleName').text(res.data.type.name + "" Details"");
    //            // ======== append total items =======
    //            var AvailableItems = `${");
            WriteLiteral(@"res.data.total_items}`
    //            $("".BigNum"").append(AvailableItems);
    //            // ======== append cycle name =======
    //            var CycleDetails = `
    //            ${res.data.from.user_id == userID ? `<label ><b>to : </b> ${res.data.to.Full_Name}</label>` : `<label><b>from: </b> ${res.data.from.Full_Name}</label>`}`
    //            $("".cycleDetails"").append(CycleDetails);
    //            // ======== append cycle date =======
    //            for (i = 0; i < res.data.items.length; i++) {
    //                var Products_List = ` <div class=""row"">
    //                        <div class=""col-2 m-auto"">
    //                            <img src=""${res.data.items[i].product.image}"" style=""border-radius:50%"" width=""80"" height=""80"">
    //                        </div>
    //                        <div class=""col-3 m-auto"">
    //                            <h4>${res.data.items[i].product.name}</h4>
    //                        </div>
    //                      ");
            WriteLiteral(@"  <div class=""col-3 m-auto"">
    //                            <h4>${res.data.items[i].product.code}</h4>
    //                        </div>
    //                        <div class=""col-2 m-auto"">
    //                            <h4>${res.data.items[i].product.type.name}</h4>
    //                        </div>
    //                        <div class=""col-2 text-center text-md-right m-auto"">
    //                            <span class=""ProductsNum"">${res.data.items[i].total_items}</span>
    //                        </div>
    //                    </div><hr /> `
    //                $("".TransferDetails"").append(Products_List);
    //            }
    //        }
    //        //$('#dtBasicExample').DataTable();
    //    } $("".loader"").fadeOut();
    //}

    // ================== NOTIFICATION FUNCTION ================== //

    async function ShowNotification() {
        var currLocation = await getCurrentLocation();
        var userlat = currLocation.latitude;
        var u");
            WriteLiteral(@"serlng = currLocation.longitude;
        const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/users/"" + userID + ""/notification/"" + NotificationID;

        let apiResponse = await fetch(proxyurl + APIurl, {
            method: 'POST',
            headers: {
                'Authorization': 'Bearer ' + AccessToken,
                //'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*',
            },
            body: JSON
        });

        var res;
        if (apiResponse.ok) {

            res = await apiResponse.json();
            if (res[""data""] != null) {
                console.log(res[""data""])
            } else {
                console.log(""false"")
            }
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\NotificationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8648c02304a553d482fdd49bee5dd540e22048b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CycleActions_NotificationDetails), @"mvc.1.0.view", @"/Views/CycleActions/NotificationDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CycleActions/NotificationDetails.cshtml", typeof(AspNetCore.Views_CycleActions_NotificationDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8648c02304a553d482fdd49bee5dd540e22048b", @"/Views/CycleActions/NotificationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_CycleActions_NotificationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\NotificationDetails.cshtml"
  
    ViewData["Title"] = "Transfer Details";

#line default
#line hidden
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(56, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8648c02304a553d482fdd49bee5dd540e22048b4285", async() => {
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
            BeginContext(117, 1488, true);
            WriteLiteral(@"
<div class=""TopBar0 pl-4 mt-2"">

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
            WriteLiteral(@"        GetCycleName();
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
            BeginContext(1606, 42, false);
#line 62 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\NotificationDetails.cshtml"
             Write(Url.Action("GetCycleName", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(1648, 1094, true);
            WriteLiteral(@"',
            type: ""Get"",
            data: { cycleId },
            success: response => {
              //  console.log(response);
                var res = response;
                if (res) {
                    var cycletype = res.cycleType == 1 ? ""NationWide"" : ""Event"";
                    var Name = `<h4 style=""display:contents"">${res.name}</h4><label style=""display:contents; font-size : 16px"" > - ${cycletype}</label>
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

 

    // ================== GET PRODUCTS DETAILS ================== //


      function DeliveryConfirm() {
        var cycleId = CycleID;
        ");
            WriteLiteral("var TransID = x.TransactionId;\r\n\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(2743, 51, false);
#line 95 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\NotificationDetails.cshtml"
             Write(Url.Action("GetTransactionDetails", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(2794, 1451, true);
            WriteLiteral(@"',
            type: ""Get"",
            data: { cycleId, TransID },
            success: response => {
                var res = response.data;

                 if (res) {
                    // ======== append cycle date =======
                    for (i = 0; i < res.length; i++) {
                        var Products_List = ` <div class=""row"">
                            <div class=""col-3 m-auto"">
                                <img src=""${res[i].productImg}"" style=""border-radius:50%"" width=""80"" height=""80"">
                            </div>
                            <div class=""col-3 m-auto"">
                                <h6>${res[i].productName}</h6>
                            </div>
                            <div class=""col-3 m-auto"">
                                <h6>${res[i].code}</h6>
                            </div>
 
                            <div class=""col-3 text-center text-md-right m-auto"">
                                <span class=""ProductsNum"">${res[i].");
            WriteLiteral(@"quantity}</span>
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
            BeginContext(4246, 45, false);
#line 134 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\CycleActions\NotificationDetails.cshtml"
             Write(Url.Action("GetCycleDetalis", "CycleActions"));

#line default
#line hidden
            EndContext();
            BeginContext(4291, 1958, true);
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
 

    // ================== NOTIFICATION FUNCTION ================== //

    async function ShowNotification() {
        var currLocat");
            WriteLiteral(@"ion = await getCurrentLocation();
        var userlat = currLocation.latitude;
        var userlng = currLocation.longitude;
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

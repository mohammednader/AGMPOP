#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NewDelivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "420c7a01c7ea98f67c5ba267aef676fe3d13d7cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_NewDelivery), @"mvc.1.0.view", @"/Views/Mobile/NewDelivery.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mobile/NewDelivery.cshtml", typeof(AspNetCore.Views_Mobile_NewDelivery))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"420c7a01c7ea98f67c5ba267aef676fe3d13d7cb", @"/Views/Mobile/NewDelivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Mobile_NewDelivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mobile/assets/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Mobile\NewDelivery.cshtml"
  
    ViewData["Title"] = "New Delivery";

#line default
#line hidden
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(52, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "420c7a01c7ea98f67c5ba267aef676fe3d13d7cb4591", async() => {
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
            BeginContext(113, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(189, 226, true);
            WriteLiteral("<div class=\"TopBar0 pl-4\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 col-6 align-self-center\">\r\n            <!-- Basic dropdown -->\r\n            <select id=\"SelectAgent\" class=\"mdb-select md-form\">\r\n                ");
            EndContext();
            BeginContext(415, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "420c7a01c7ea98f67c5ba267aef676fe3d13d7cb6190", async() => {
                BeginContext(450, 11, true);
                WriteLiteral("Choose user");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(470, 419, true);
            WriteLiteral(@"
            </select>
        </div>
        <div class=""col-md-9 col-6 text-md-right align-self-center"">
            <span class=""stock-card d-flex flex-column justify-content-center align-items-center float-right"" id=""AvailableStock"">
                <h5>Available Stock</h5>
                <span class=""SmallNum""><span class=""BigNum""></span>/</span>
            </span>
        </div>
    </div>
</div>
");
            EndContext();
            BeginContext(974, 321, true);
            WriteLiteral(@"

<div class=""ContentAfterTopBar0 mb-4"">
    <label class=""p-2"">BBO’s & Products</label>
    <div class="" card card-body mb-4  pl-md-5 pr-md-5"" id=""trans_actions_container"">

    </div>
    <div class=""viewAll text-right mt-3 mb-3"">
        <button onclick=""ConfirmAction()"">Confirm</button>
    </div>
</div>
");
            EndContext();
            BeginContext(1368, 13512, true);
            WriteLiteral(@"<div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content mt-3 p-3"">
            <div class=""modal-body text-center"">
                <h3 class=""text-center""></h3>
                <a class=""m-1 px-3 btn btn-success"" data-dismiss=""modal"" style=""color:white"">Close</a>
            </div>
        </div>
    </div>
</div>
<style>
    .table tbody tr td {
        vertical-align: middle;
    }
</style>

<script>
    var ToId;
    $('#SelectAgent').on('change', function () {
        ToId = $('#SelectAgent').val()
    });
    // ================== JQUERY ================== //
    $(document).ready(function () {
        $('.dataTables_length').addClass('bs-select');
        $(""select"").removeClass(""custom-select"");
        $(""#AvailableActions"").hide();
        $(""#hello1"").text(""New Delivery - Cycle Name Here"");
        GetAgent();
    });
   ");
            WriteLiteral(@" // ================== GLOBAL VARIABLES ================== //
    var x = Object.fromEntries(new URLSearchParams(location.search));
    var CycleID = x.cycleId;
    var ActionId = x.ActionId;
    // ================== GET AVAILABLE USERS FUNCTION ================== //


    function GetUsers() {
        $.ajax({
            url: ""CyclcApi/GetUsers"",
            type: ""Get"",
            success: response => {
                console.log(response);  
                var res;

                 res = response;
                    if (res) {
                        var x = 0;
                        for (let item of res) {
                            var Agent = `<option class=""dropdown-item"" value ='${item.user_id}' > ${item.Full_Name} - <span class=""d-inline"" style=""opacity:0.5"">${item.Type.name}</span></option>`
                            Available_Agent.append(Agent);
                        }
                    }
                    else {
                        Available_Agent.empt");
            WriteLiteral(@"y();
                    }
             
                GetCycleTotalItems();
            },
            

        });

    }

    async function GetAgent() {
        var currLocation = await getCurrentLocation();
        var userlat = currLocation.latitude;
        var userlng = currLocation.longitude;
        const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/users/"" + userID + ""/"" + CycleID + ""/"" + ActionId;
        var Available_Agent = $(""#SelectAgent"");

        let apiResponse = await fetch(proxyurl + APIurl, {
            method: 'GET',
            headers: {
                'Authorization': 'Bearer ' + AccessToken,
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*',
            },
        });

        var res;
        if (apiResponse.ok) {
            res = await apiResponse.json();
            if (res.data) {
                var x = 0;
            ");
            WriteLiteral(@"    for (let item of res.data) {
                    var Agent = `<option class=""dropdown-item"" value ='${item.user_id}' > ${item.Full_Name} - <span class=""d-inline"" style=""opacity:0.5"">${item.Type.name}</span></option>`
                    Available_Agent.append(Agent);
                }
            }
            else {
                Available_Agent.empty();
            }
        }
        GetCycleTotalItems();
    }

    // ================== GET AVAILABLE TRANSACTION PRODUCTS ================== //
    var ValArray = [],
        y;
    async function GetTransactions() {
        var currLocation = await getCurrentLocation();
        var userlat = currLocation.latitude;
        var userlng = currLocation.longitude;
        const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/"" + userID + ""/transcations/items/"" + CycleID + ""?AllItems=false"";
        $(""#trans_actions_container"").empty();

        let apiResponse = await fetch(proxyurl + APIurl, {
            method:");
            WriteLiteral(@" 'GET',
            headers: {
                'Authorization': 'Bearer ' + AccessToken,
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*',
            },
        });
        var res;
        if (apiResponse.ok) {
            res = await apiResponse.json();

            if (res.data && res.data.length) {
                for (let transaction of res.data) {
                    var trans_action = ` <div class=""row"">
                                            <div class=""col-2 m-auto"">
                                                <img src=""${transaction.product.image}"" style=""border-radius:50%"" width=""80"" height=""80"">
                                            </div>
                                            <div class=""col-3 m-auto"">
                                                <h4>${transaction.product.name}</h4>
                                            </div>
                    ");
            WriteLiteral(@"                        <div class=""col-3 m-auto"">
                                                <h4>${transaction.product.code}</h4>
                                            </div>
                                            <div class=""col-2 m-auto"">
                                                <h4>${transaction.product.type.name}</h4>
                                            </div>
                                            <div class=""col-2 text-md-right m-auto"">
                                                <input class=""ProductCount"" type=""text"" data-product=${transaction.product.id} name=""value"" maxlength=""4"" size=""1"" style=""height:40px; width:70px; text-align:center; font-size:18px; border-radius:5px;"" value=""0""> <h4 class=""d-inline""> &nbsp;/ </h4>
                                                <h4 class=""d-inline-block"" style=""width:60px"">${transaction.available_items}</h4>
                                            </div>
                                        </div><hr />");
            WriteLiteral(@"`
                    $(""#trans_actions_container"").append(trans_action);
                    y = `${transaction.available_items}`
                    ValArray.push(y);
                }

            }
        }
        else {
            $(""#Transactions"").append(`<div class=""alert alert-dark text-center"" style=""font-size:25px;"" role=""alert"">No Actions Available !!</div>`);
        }
        $('#dtBasicExample').DataTable();
        $("".loader"").fadeOut();
    }

    // ================== CONFIRM WITH VALIDATION FUNCTIONS ================== //

    async function ConfirmAction() {

        var currLocation = await getCurrentLocation();
        var userlat = currLocation.latitude;
        var userlng = currLocation.longitude;
        const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/"" + userID + ""/transcations"";
        var ActionData = {
            ""cycle_id"": CycleID,
            ""to_user_id"": ToId,
            ""from_user_id"": userID,
            ""transacti");
            WriteLiteral(@"on_type_id"": ActionId,
            ""transaction_items"": []
        };
        var ProductUserInputArray = ActionData.transaction_items;

        function GetUserInputProductNum() {
            for (let item of $("".ProductCount"")) {
                var Product = $(item)
                var obj = {
                    ""product_id"": Product.data('product'),
                    ""count"": Product.val()
                };
                ProductUserInputArray.push(obj)
            }
        } GetUserInputProductNum();

        // ================== VALIDATION FUNCTIONS ================== //
        function Validation_Function() {
            var AllProductValueEntered = [];
            if (ToId > 0) {
                for (i = 0; i < ProductUserInputArray.length; i++)
                    if (ProductUserInputArray[i].count != """" && ProductUserInputArray[i].count != null) {
                        AllProductValueEntered.push(ProductUserInputArray[i]);
                    } else {
              ");
            WriteLiteral(@"          $("".modal-body h3"").text(""Please complete Products numbers1"").addClass(""success"");
                        $(""#exampleModal"").modal(""show"");
                        break;
                    }
                if (ProductUserInputArray.length == AllProductValueEntered.length) {
                    var SumOfAllProducts = 0;
                    var d;
                    var e = [];
                    for (i = 0; i < AllProductValueEntered.length; i++) {
                        if (Number(AllProductValueEntered[i].count) <= Number(ValArray[i]) && Number(AllProductValueEntered[i].count) >= 0) {
                            d = Number(AllProductValueEntered[i].count);
                            e.push(d);
                            SumOfAllProducts += Number(AllProductValueEntered[i].count);

                            if (e.length == AllProductValueEntered.length) {
                                if (SumOfAllProducts > 0) {
                                    $("".loader"").fadeIn();
            WriteLiteral(@"
                                    startPost();
                                } else {
                                    $("".modal-body h3"").text(""Error! .. you should enter a quantity for one product at least"").addClass(""success"");
                                    $(""#exampleModal"").modal(""show"");
                                }
                            }
                        } else {
                            $("".modal-body h3"").text(""Error! .. transferred quantities should not exceed available ones"").addClass(""success"");
                            $(""#exampleModal"").modal(""show"");
                            break;
                        }
                    }
                } else {
                    $("".modal-body h3"").text(""Every product should have quantity"").addClass(""success"");
                    $(""#exampleModal"").modal(""show"");
                }
            } else {

                $("".modal-body h3"").text(""Please Select One Agent"").addClass(""success"");
            WriteLiteral(@"
                $(""#exampleModal"").modal(""show"");
            }
        }
        Validation_Function()

        // ================== CONFIRM FUNCTION ================== //
        async function startPost() {

            let apiResponse = await fetch(proxyurl + APIurl, {
                method: 'POST',
                headers: {
                    'Authorization': 'Bearer ' + AccessToken,
                    'Accept': 'application/json',
                    'Content-Type': 'application/json',
                    'Access-Control-Allow-Origin': '*',
                },
                body: JSON.stringify(ActionData)
            });
            console.log(apiResponse)
            var res;
            if (apiResponse.ok) {
                console.log(apiResponse)
                res = await apiResponse.json();
                if (res[""data""] != null) {
                    console.log(res[""data""])
                    $(""#exampleModal"").empty()
                    var modal = `
    ");
            WriteLiteral(@"                <div class=""modal-dialog"" role=""document"">
                        <div class=""modal-content mt-3 p-3"">
                            <div class=""modal-body text-center"">
                                <h3 class=""text-center""></h3>
                                <a class=""m-1 px-3 btn btn-success"" href=""CycleName?cycleId=${CycleID}"">Close</a>
                            </div>
                        </div>
                    </div> `
                    $(""#exampleModal"").append(modal);
                    $("".loader"").fadeOut();
                    $("".modal-body h3"").text(""Confirmed"").addClass(""success"")
                    $(""#exampleModal"").modal(""show"");
                } else {
                    $("".loader"").fadeOut();
                    $("".modal-body"").text(""Failed"").addClass(""danger"")
                    $(""#exampleModal"").modal(""show"");
                }
            }
        }

    }
    // ================== CYCLE TOTAL AND AVAILABLE ITEMS FUNCTIONS ======");
            WriteLiteral(@"============
    async function GetCycleTotalItems() {

        var currLocation = await getCurrentLocation();
        var userlat = currLocation.latitude;
        var userlng = currLocation.longitude;
        const APIurl = BaseAPIurl + userlat + ""/"" + userlng + ""/"" + DeviceId + ""/"" + userID + ""/cycles/"" + CycleID;

        let apiResponse = await fetch(proxyurl + APIurl, {
            method: 'GET',
            headers: {
                'Authorization': 'Bearer ' + AccessToken,
                'Accept': 'application/json',
                'Content-Type': 'application/json',
                'Access-Control-Allow-Origin': '*',
            },
        });

        var res;
        if (apiResponse.ok) {
            res = await apiResponse.json();
            if (res.data) {
                var total_items = `${res.data.total_items}`;
                var available_items = `${res.data.available_items}`
                $("".BigNum"").append(available_items);
                $("".SmallNum"").ap");
            WriteLiteral("pend(total_items);\r\n            }\r\n            else {\r\n                $(\".BigNum\").empty();\r\n                $(\".SmallNum\").empty();\r\n            }\r\n        } GetTransactions();\r\n    }\r\n</script>\r\n\r\n");
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
#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505761a2d47ecdfabd5a18d30399fc0ecc939779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transaction_CancelTransaction), @"mvc.1.0.view", @"/Views/Transaction/CancelTransaction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Transaction/CancelTransaction.cshtml", typeof(AspNetCore.Views_Transaction_CancelTransaction))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505761a2d47ecdfabd5a18d30399fc0ecc939779", @"/Views/Transaction/CancelTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Transaction_CancelTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewTransactionVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdb-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cycleDDL"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
  
    ViewData["Title"] = "Cancel Transaction";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(126, 965, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505761a2d47ecdfabd5a18d30399fc0ecc9397794776", async() => {
                BeginContext(132, 195, true);
                WriteLiteral("\r\n    <div class=\"card card-body my-2\">\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-sm-4\">\r\n                <label  class=\"control-label\">Cycle   </label>\r\n                ");
                EndContext();
                BeginContext(327, 323, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505761a2d47ecdfabd5a18d30399fc0ecc9397795369", async() => {
                    BeginContext(386, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(408, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505761a2d47ecdfabd5a18d30399fc0ecc9397795793", async() => {
                        BeginContext(425, 10, true);
                        WriteLiteral("Select One");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(444, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 13 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
                     foreach (var item in Model.CycleList)
                    {

#line default
#line hidden
                    BeginContext(529, 24, true);
                    WriteLiteral("                        ");
                    EndContext();
                    BeginContext(553, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "505761a2d47ecdfabd5a18d30399fc0ecc9397797701", async() => {
                        BeginContext(582, 9, false);
#line 15 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
                                               Write(item.Text);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 15 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
                           WriteLiteral(item.Value);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(600, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 16 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
                    }

#line default
#line hidden
                    BeginContext(625, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 11 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CycleId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(650, 434, true);
                WriteLiteral(@"
                <span class=""text-danger"" id=""errDDL""></span>
            </div>
            
        </div>
    </div>
    <div class=""my-3 mt-2 Dfooter"" style=""display:none"">
        <div class=""card"">
            <div class=""card-header"">
                <h5 class=""font-weight-bolder""  >Cancel Transaction</h5>
            </div>
            <div class=""card-body"" id=""divResult""></div>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1091, 328, true);
            WriteLiteral(@"

<script>
    $(""#cycleDDL"").change(function () {
        var CycleId = $(""#cycleDDL"").val();
        $('#divResult').html('');
        $("".Dfooter"").hide();
        console.log(CycleId);

            if (CycleId) {
                //Get Partial for product cycle
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(1420, 31, false);
#line 44 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
                     Write(Url.Action("_CycleTransaction"));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 627, true);
            WriteLiteral(@"',
                    method: 'Get',
                    data: { CycleId },
                    success: response => {
                        if (response) {
                            $('#divResult').html(response);
                            $("".Dfooter"").show();
                        }
                    }, error: function () {
                        alert(""Error"");
                    }
                });
              
               
            }

        });
  




      //show Product details in transaction
    function showDetials(Tid) {

        $.ajax({

            url: '");
            EndContext();
            BeginContext(2079, 33, false);
#line 71 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
             Write(Url.Action("_TransactionDetails"));

#line default
#line hidden
            EndContext();
            BeginContext(2112, 787, true);
            WriteLiteral(@"',
            method: 'Get',
            data: { Tid },
            success: function (data, jqXHR) {
                $('#DetialContainer').html(data);
                $('#DetialModal').modal('show');


            }
        });
    }



   // Cancel_Transaction post

    function CancelTransaction(id) {
        var item = $(""#"" + id + ""cancel"")[0];
        console.log(item);
        swal.fire({
            text: 'Are you sure you want to cancel this transaction?',
            icon: 'question',
            showCancelButton: true,           
            confirmButtonText: 'Ok',

        }).then((result) => {

            if (result.value) {
                var _parameters = { TransactionId: id };
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(2900, 31, false);
#line 101 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Transaction\CancelTransaction.cshtml"
                     Write(Url.Action("CancelTransaction"));

#line default
#line hidden
            EndContext();
            BeginContext(2931, 776, true);
            WriteLiteral(@"',
                    type: ""POST"",
                    data: _parameters,
                    success: function (data, textStatus, jqXHR) {
                        if (data && data.success) {
                            Swal.fire({
                                icon: 'success',
                                text: data.message,
                                showConfirmButton: true,


                            }).then((e) => {
                                item.closest(""tr"").remove();
                            });
                        }

                    }
                });
            }
            else (result.dismiss === swal.DismissReason.cancel)
            {

            }
        }

        );

    }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewTransactionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
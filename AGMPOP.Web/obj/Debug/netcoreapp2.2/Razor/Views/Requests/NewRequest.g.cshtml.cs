#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\NewRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb0047205d2747e5a929b5bfedf6f86e73dcce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Requests_NewRequest), @"mvc.1.0.view", @"/Views/Requests/NewRequest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Requests/NewRequest.cshtml", typeof(AspNetCore.Views_Requests_NewRequest))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cb0047205d2747e5a929b5bfedf6f86e73dcce0", @"/Views/Requests/NewRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Requests_NewRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AGMPOP.BL.Models.Domain.Request>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mdb-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cycle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\NewRequest.cshtml"
  
    ViewData["Title"] = "New Request";

#line default
#line hidden
            BeginContext(89, 101, true);
            WriteLiteral("\r\n<div class=\"card card-body mt-2\">\r\n    <div class=\"row\">\r\n        <div class=\"col-4\">\r\n            ");
            EndContext();
            BeginContext(190, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cb0047205d2747e5a929b5bfedf6f86e73dcce04818", async() => {
                BeginContext(215, 5, true);
                WriteLiteral("Cycle");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 10 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\NewRequest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CycleId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(228, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(242, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cb0047205d2747e5a929b5bfedf6f86e73dcce06474", async() => {
                BeginContext(298, 19, true);
                WriteLiteral(" \r\n                ");
                EndContext();
                BeginContext(317, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cb0047205d2747e5a929b5bfedf6f86e73dcce06875", async() => {
                    BeginContext(334, 10, true);
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
                BeginContext(353, 16, true);
                WriteLiteral("  \r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 11 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\NewRequest.cshtml"
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
            BeginContext(378, 698, true);
            WriteLiteral(@"
        </div>
    </div>
</div>

<div class=""card-body card"" id=""div_productlist"" style=""display:none"">

    <div id=""ProductList"">


    </div>
    <div class=""d-flex justify-content-end"">
        <button type=""button"" onclick=""AddNewRequest()"" class=""btn btn-blue"">Add</button>

    </div>

</div>

 
<script>

    $(document).ready(function () {
        $("".ProductList"").addClass('d-none');
        function DisplyFooter() {
            $("".ProductList"").removeClass('d-none');
            $("".Dfooter"").addClass('d-inline');
        }
        loadCycleName();
    });
</script>
<script>
        function loadCycleName() {
         $.ajax({
            url: '");
            EndContext();
            BeginContext(1077, 40, false);
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\NewRequest.cshtml"
             Write(Url.Action("RequestUserCycle", "Common"));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 808, true);
            WriteLiteral(@"',
            type: ""Get"",
            contentType: ""application/json; charset=utf-8"",
             success: function (data) {
                 if (data.length >0) {

                     for (var i = 0; i < data.length; i++) {
                         $('#cycle').append(new Option(data[i].name, data[i].cycleId));

                     }
                 }
             },
            //error: function (x) {
            //    alert(""error"" + x);
            //},
        });
    }




    $(""#cycle"").change(function () {
        var CycleId = $(""#cycle"").val(); 
        if (CycleId) {
            $(""#div_productlist"").css(""display"", ""block""); 
            //Get Partial for product cycle
            var IsRequest = true;
                $.ajax({
                    url: '");
            EndContext();
            BeginContext(1926, 45, false);
#line 74 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Requests\NewRequest.cshtml"
                     Write(Url.Action("_CycleProductList","Transaction"));

#line default
#line hidden
            EndContext();
            BeginContext(1971, 543, true);
            WriteLiteral(@"',
                    method: 'Get',
                    data: { CycleId, IsRequest },
                    success: response => {
                        if (response) {
                            $('#ProductList').html('');
                            $('#ProductList').html(response);
                        }
                    }, error: function () {
                        alert(""Error"");
                    }
                })

            //    DisplyFooter();
            }
       
        });


</script>

");
            EndContext();
            BeginContext(2534, 15, true);
            WriteLiteral(" \r\n\r\n<script>\r\n");
            EndContext();
            BeginContext(2573, 2801, true);
            WriteLiteral(@"    function AddNewRequest() {
        var cycleId = $(""#cycle"").val();
        var Arr = [];
        var checkValues = 0;
        var myTrackingContent = ""<table class='table table-bordered' width='100%'>""
        $("".product"").each(function (i, item) {
            var id = item.id;
            var name = item.name;
            var val = $(""#"" + item.id).val();
            checkValues++;
            Arr.push(id + "":"" + val);
            myTrackingContent += ""<tr><td class='text-left'><span>"" + name + ""</span></td> <td><span>"" + val + ""</span></td></tr>"";
        });
        myTrackingContent += ""</table>"";
        if (checkValues > 0) {
            swal.fire({
                text: ""Review & Confirm"",
                html: myTrackingContent,
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#888',
                confirmButtonText: 'Ok',
            }).then((result) => {
         ");
            WriteLiteral(@"       if (result.value) {
                    $.ajax({
                        url: '/Requests/NewRequest',
                        type: ""POST"",
                        data: { cycleId, Arr },
                        success: function (result) {
                            if (result != null) {
                                // done
                                if (result.success) {
                                    Swal.fire({
                                        text: result.message,
                                        icon: 'success',

                                    }
                    
                                    ).then(
                                        function () {
                                            location.reload();
                                        }
                                    );
                                }
                                // when cant add
                                else {
                  ");
            WriteLiteral(@"                  Swal.fire({
                                        text: result.message,
                                        icon: 'error',
                                    })
                                }

                            }

                        },
                        error: function (err) {
                            alert(err.statusText);
                        }
                    });
                }
                else if (result.dismiss === swal.DismissReason.cancel) {
                    swal.fire({
                        text: 'No Request created.',
                        icon: 'info',
                     })
                }
            });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AGMPOP.BL.Models.Domain.Request> Html { get; private set; }
    }
}
#pragma warning restore 1591

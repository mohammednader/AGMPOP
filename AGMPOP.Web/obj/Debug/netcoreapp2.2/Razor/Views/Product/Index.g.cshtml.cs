#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8cbf36231bdff4b5d954e151354486cd8cf3d9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8cbf36231bdff4b5d954e151354486cd8cf3d9e", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AGMPOP.BL.Models.ViewModels.ProductDTO>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("productform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "BBOs & Products";

#line default
#line hidden
            BeginContext(100, 145, true);
            WriteLiteral("\r\n\r\n<div class=\"text-right mt-1\">\r\n    <button type=\"button\" class=\"material-tooltip-main px-3 btn btn-blue-grey  mr-0 mt-0\" style=\"height:37px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 245, "\"", 303, 3);
            WriteAttributeValue("", 255, "location.href=\'", 255, 15, true);
#line 9 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
WriteAttributeValue("", 270, Url.Action("index","inventory"), 270, 32, false);

#line default
#line hidden
            WriteAttributeValue("", 302, "\'", 302, 1, true);
            EndWriteAttribute();
            BeginContext(304, 1195, true);
            WriteLiteral(@">
        Inveintory &nbsp; <i class=""fa fa-align-center"" style=""vertical-align: middle !important; font-size:20px;""> </i>
    </button>
    <button type=""button"" class=""material-tooltip-main  btn btn-primary  text-center mr-0 mt-0 px-3 waves-effect waves-light "" style=""height:37px;"" onclick=""Create()"">
        Add Product &nbsp; <i class=""fal  fa-plus fa-align-center"" style=""vertical-align: middle !important; font-size:20px;""> </i>
    </button>

</div>


<!--Search bar -->
<div class="" card px-3 py-1 m-0   accordion"">

    <div class="""" style=""overflow: visible"">
        <div class=""d-flex justify-content-between  ""
             data-toggle=""collapse""
             href=""#divCollapseSearch""
             role=""button""
             aria-expanded=""false""
             aria-controls=""divCollapseSearch""
             style=""cursor: pointer"">
            <h5 class=""mt-2 font-weight-bold""><i class=""far fa-search "" style=""font-size: 20px;""></i>  Search</h5>
            <span><i class=""fa fa-angle");
            WriteLiteral("-double-down \" style=\"margin-top:10px\"></i></span>\r\n\r\n        </div>\r\n\r\n        <div id=\"divCollapseSearch\" class=\"collapse mb-2 \">\r\n            <hr /><br />\r\n            ");
            EndContext();
            BeginContext(1499, 1626, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8cbf36231bdff4b5d954e151354486cd8cf3d9e6948", async() => {
                BeginContext(1522, 178, true);
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"form-group col-sm-6 col-md-4\">\r\n                        <label>Product Name</label>\r\n                        ");
                EndContext();
                BeginContext(1700, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8cbf36231bdff4b5d954e151354486cd8cf3d9e7519", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 41 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1752, 122, true);
                WriteLiteral("\r\n                    </div>\r\n\r\n\r\n                    <div class=\"form-group col-sm-6 col-md-4\">\r\n                        ");
                EndContext();
                BeginContext(1874, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8cbf36231bdff4b5d954e151354486cd8cf3d9e9330", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 46 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Department);

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
                BeginContext(1910, 160, true);
                WriteLiteral("\r\n                        <select id=\"DepartmentIds\" name=\"DepartmentIds\" class=\"mdb-select\" multiple Searchable=\"Search here...\">\r\n                            ");
                EndContext();
                BeginContext(2070, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8cbf36231bdff4b5d954e151354486cd8cf3d9e11097", async() => {
                    BeginContext(2105, 17, true);
                    WriteLiteral("Select Department");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2131, 65, true);
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n");
                EndContext();
                BeginContext(2595, 523, true);
                WriteLiteral(@"
                    <div class=""col-12 text-right"">
                        <button type=""button"" class=""btn btn-secondary px-4 m-0"" onclick=""clearBTN()"">
                            Clear &nbsp; <i class=""fa fa-trash""></i>
                        </button>
                        <button id=""btnsearch"" type=""button"" class=""btn btn-primary"">
                            Search&nbsp; <i class=""fa fa-search""></i>
                        </button>

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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3125, 892, true);
            WriteLiteral(@"

        </div>
    </div>
</div>







<!--PartialIndex Modal -->
<div id=""PartialIndex"" class=""mt-2"">


</div>

<!--ShowProductDetails Modal -->
<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <img id=""ProductImg"" />

                <p id=""code""></p>
                <p id=""Name""></p>
");
            EndContext();
            BeginContext(4056, 1785, true);
            WriteLiteral(@"                <p id=""Department""></p>
                <p id=""InventoryQnty""></p>
                <p id=""CreatedBy""></p>
                <p id=""CreatedDate""></p>
                <p id=""created""></p>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-grey"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>

<!--Edit Modal -->
<div class=""modal fade"" id=""editProductModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""editProductModalTitle""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>

            <div id=""re");
            WriteLiteral(@"sult"">

            </div>

        </div>
    </div>
</div>


<!--Create Modal -->
<div class=""modal fade"" id=""CreateProductModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""CreateProductModalTitle""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""resultCreate"">

            </div>

        </div>
    </div>
</div>



");
            EndContext();
            BeginContext(5865, 123, true);
            WriteLiteral("<script>\r\n\r\n    function ShowProductDetails(ProductId) {\r\n        var id = ProductId;\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(5989, 32, false);
#line 161 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("Details", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(6021, 1604, true);
            WriteLiteral(@"',
            data: { id },
            type: ""Get"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {
                debugger;
                console.log(data);
                 if (data != null) {
                    $('#exampleModalLongTitle').text(""Product Detalis"");
                    $('#exampleModalLongTitle').css(""text-align"", ""center"")

                     $('#Name').text(""Name: "" + data.data.name);
                     $('#code').text(""Code: "" + data.data.code);
                    // type
                    //if (data.data.type==1) {
                    //    $('#Type').text(""Type: BBO"");
                    //}
                    //if (data.data.type==2) {
                    //    $('#Type').text(""Type: Product"");
                    // }
                     $('#Department').text(""Department: "" + data.data.department);
                     $('#InventoryQnty').text(""Inventory quantity : "" + data.data.qunt);
            ");
            WriteLiteral(@"         $('#CreatedDate').text(""Created Date: "" +data.data.createdDate);
                     //img style
                    $('#ProductImg').attr(""src"", data.data.image);
                    $('#ProductImg').css(""float"", ""right"");
                    $('#ProductImg').css(""width"", ""120px"");
                    $('#ProductImg').css(""height"", ""120px"");
                    $('#exampleModalCenter').modal('show');
                }

            },
            error: function (x) {
                console.log(x);
            },
        });
    }

</script>


");
            EndContext();
            BeginContext(7645, 10, true);
            WriteLiteral("<script>\r\n");
            EndContext();
            BeginContext(8073, 17, true);
            WriteLiteral("\r\n</script>\r\n\r\n\r\n");
            EndContext();
            BeginContext(8100, 109, true);
            WriteLiteral("<script>\r\n\r\n    function Edit(ProductId) {\r\n        var id = ProductId;\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(8210, 36, false);
#line 228 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("EditProduct", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(8246, 472, true);
            WriteLiteral(@"',
            data: { id },
            type: ""Get"",
            contentType: ""application/json; charset=utf-8"",
             success: function (data) {
                 $('#result').html(data);
                 $('#editProductModalTitle').text(""Edit Product"");
                  $('#editProductModal').modal('show');

            },
            error: function (x) {
                alert(""error"" + x);
            },
        });
    }

</script>



");
            EndContext();
            BeginContext(8731, 75, true);
            WriteLiteral("<script>\r\n\r\n    function Create() {\r\n\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(8807, 31, false);
#line 254 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("Create", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(8838, 992, true);
            WriteLiteral(@"',
            type: ""Get"",
            contentType: ""application/json; charset=utf-8"",
            success: function (data) {

                $('#resultCreate').html(data);


                $('#CreateProductModalTitle').text(""Create Product"");
                $('#CreateProductModalTitle').css(""text-align"", ""center"")

                $('#CreateProductModal').modal('show');

                // Remove validation.
                $(""formId"").removeData(""validator"").removeData(""unobtrusiveValidation"");

                // Add validation again.


            },
            complete: function  () {

                var form = $(""#resultCreate"").closest(""form"");
                form.removeData('validator');
                form.removeData('unobtrusiveValidation');
                $.validator.unobtrusive.parse(form);

            }  ,
            error: function (x) {
                alert(""error"" + x);
            },
        });

    }

</script>
");
            EndContext();
            BeginContext(9849, 221, true);
            WriteLiteral("<script>\r\n\r\n    function saveNewProduct() {\r\n\r\n        var formData = new FormData($(\'#formCreateProduct\')[0]);\r\n        formData.append(\'file\', $(\'#CreateFileUploader\')[0].files[0]);\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(10071, 31, false);
#line 298 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("Create", "Product"));

#line default
#line hidden
            EndContext();
            BeginContext(10102, 1032, true);
            WriteLiteral(@"',
            method: 'POST',
            enctype: ""multipart/form-data"",
            processData: false,
            contentType: false,
            data: formData,
            success: function (data) {
                if (data != null) {
                    if (data.success) {
                        $('#CreateProductModal').modal('hide');

                        Swal.fire({
                            text: data.message,
                            icon:""success"",

                        }

                        ).then(function () {
                            loadProduct();

                        })
                     }
                }
            },
            error: function (x) {
                alert(""error"" + x);
            },
        });
    }
</script>

<script>
    function getAllTypes() {
        $('#Types').empty();
        $('#Types').append('<option class=""default"" value="""" selected disabled>Select Type</option>');

        $.ajax({
          ");
            WriteLiteral("  url: \'");
            EndContext();
            BeginContext(11135, 41, false);
#line 335 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("GetAllProductTypes","common"));

#line default
#line hidden
            EndContext();
            BeginContext(11176, 632, true);
            WriteLiteral(@"',
            method: 'GET',
            async: false,
            success: response => {
                console.log(response);

                if (response && response.length) {
                    response.forEach(r => {
                        $('#Types').append(`<option value=""${r.id}"">${r.name}</option>`);
                    });
                }
            }
        });
    }

     function getAllDepts() {
        $('#DepartmentIds').empty();
         $('#DepartmentIds').append('<option class=""default"" value="""" selected disabled>Select Department</option>');

        $.ajax({
            url: '");
            EndContext();
            BeginContext(11809, 41, false);
#line 355 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("GetAllDepartments", "common"));

#line default
#line hidden
            EndContext();
            BeginContext(11850, 402, true);
            WriteLiteral(@"',
            method: 'GET',
            async: false,

            success: response => {
                console.log(response);
                if (response ) {
                    response.forEach(d => {
                        $('#DepartmentIds').append(`<option value=""${d.id}"">${d.name}</option>`);
                    });
                }
            }
        });
    }




");
            EndContext();
            BeginContext(12275, 225, true);
            WriteLiteral("    function loadProduct(e) {\r\n        //if (e) {\r\n        //    e.preventDefault();\r\n        //    e.returnValue = false;\r\n        //}\r\n         var form = $(\'#productform\').serialize();\r\n        $.ajax({\r\n            url: \'");
            EndContext();
            BeginContext(12501, 20, false);
#line 381 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
             Write(Url.Action("Search"));

#line default
#line hidden
            EndContext();
            BeginContext(12521, 759, true);
            WriteLiteral(@"?' + form,
            method: 'GET',
            success: response => {
                if (response) {
                    $('#PartialIndex').html(response);
                }
                else {
                    Swal.fire({
                        icon: 'error',
                        text: 'Failed to load  ',
                    });
                }
            }
        });


    }

</script>
<script>
    $(() => {
        getAllDepts();
        getAllTypes();
        loadProduct();
        $('#btnsearch').on('click', loadProduct);
    })
</script>

<script>


    async function ExportProdcut() {

        var now = moment().format();
        var form = $('#productform').serialize();
 
         fetch('");
            EndContext();
            BeginContext(13281, 27, false);
#line 417 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
           Write(Url.Action("ExportProduct"));

#line default
#line hidden
            EndContext();
            BeginContext(13308, 1352, true);
            WriteLiteral(@"?' + form, {
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
            a.download = `Product_${now}.xlsx`;
            document.body.appendChild(a);
            a.click();
            window.URL.revokeObjectURL(url);
            }).catch(err => {
                swal.fire({");
            WriteLiteral(@"
                icon: 'error',
                text: 'An error occured',
            });
        });
    }
</script>

<script>

    function clearBTN() {
        console.log(""reset"");
        $(""#productform"").resetForm();
        $("".default"").attr('selected', true);
        loadProduct();
    }
</script>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(14678, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 465 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Product\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AGMPOP.BL.Models.ViewModels.ProductDTO> Html { get; private set; }
    }
}
#pragma warning restore 1591
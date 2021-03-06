#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_ProductCycleDetalis.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ec62e6e256c1922de6b2e387a433e8086115f92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cycles__ProductCycleDetalis), @"mvc.1.0.view", @"/Views/Cycles/_ProductCycleDetalis.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cycles/_ProductCycleDetalis.cshtml", typeof(AspNetCore.Views_Cycles__ProductCycleDetalis))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ec62e6e256c1922de6b2e387a433e8086115f92", @"/Views/Cycles/_ProductCycleDetalis.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Cycles__ProductCycleDetalis : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_ProductCycleDetalis.cshtml"
   
    Layout = null;

#line default
#line hidden
            BeginContext(28, 1799, true);
            WriteLiteral(@"
<style>
    #lstProducts, #product-filter-field {
        max-height: 55vh;
        overflow-y: auto;
    }
</style>
<div>
    <div class=""container-fluid"" id=""product-tab-container"">
        <div class=""row"">

            <div class=""col-12"">
                <input type=""text"" id=""txtSearchProduct"" class=""form-control"" placeholder=""Search for products..."" />
            </div>
            <div id=""product-filter-field"" class=""col-6 col-sm-3"">
                <div>
                    <button class=""btn btn-link text-primary pt-4 px-0"" id=""btnViewAllProducts"" onclick=""clearFilterProducts()"">View All</button>
                </div>
                <div style=""display: none"" id=""divProductDepartmentSearch"" class=""flex-column align-items-start"">
                    <h5>Department</h5>
                    <div id=""lstProductDepartments"" class=""d-flex flex-column align-items-start""></div>
                </div>
                <div style=""display: none"" id=""divProductTypeSearch"" class=""flex-");
            WriteLiteral(@"column align-items-start"">
                    <h5>Job Title</h5>
                    <div id=""lstProductTypes"" class=""d-flex flex-column align-items-start""></div>
                </div>
            </div>
            <div class=""col-6 col-sm-9 pt-4"">
                <p class=""font-weight-bold"" id=""productCount""></p>
                <div id=""lstProducts"" class=""list-group""></div>
            </div>


        </div>
    </div>
</div>


<script>

    $(() => {
        getAllProductTypes();

        //if (CycleDepartment == 0) {
        //    getAllDepartments();
        //}
        getAllProducts();
        $('#txtSearchProduct').on('keyup', e => {
            searchTextProducts($('#txtSearchProduct').val());
        });
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

#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CycleTerritoies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7859114232e1a8592517feafdf6f6cb3d396bfd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cycles__CycleTerritoies), @"mvc.1.0.view", @"/Views/Cycles/_CycleTerritoies.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cycles/_CycleTerritoies.cshtml", typeof(AspNetCore.Views_Cycles__CycleTerritoies))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7859114232e1a8592517feafdf6f6cb3d396bfd7", @"/Views/Cycles/_CycleTerritoies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Cycles__CycleTerritoies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CycleTerritoies.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 263, true);
            WriteLiteral(@"
<div>
    <fieldset>
        <div class=""col-12"">
            <div id=""geo-tree""></div>
            <input type=""hidden"" name=""jsfields"" id=""jsfields"" value="""" />
        </div>
    </fieldset>
</div>
<script>
    $(function () {

        var url = '");
            EndContext();
            BeginContext(291, 38, false);
#line 16 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\_CycleTerritoies.cshtml"
              Write(Url.Action("TerritoiesData", "Cycles"));

#line default
#line hidden
            EndContext();
            BeginContext(329, 2276, true);
            WriteLiteral(@"';
        if (CycleId) {
            url += `?cycleId=${CycleId}`;
        }
        $.ajax({
            url,
            method: ""Get"",
            success: (data) => {
                LoadExtOrgTree(data.data);
            },
            error: (e) => { console.log(e); }
        });
    });
    //load Territories
    function LoadExtOrgTree(data) {

        $('#geo-tree')
            .jstree({
                ""core"": {
                    ""animation"": 0,
                    ""check_callback"": true,
                    'force_text': true,
                    ""themes"": { """": true },
                    'data': JSON.parse(data)
                }
                ,
                ""types"": {
                    ""#"": { ""max_children"": 1, ""max_depth"": 4, ""valid_children"": [""root""] },
                    ""root"": { ""icon"": """", ""valid_children"": [""default""] },
                    ""default"": { ""icon"": ""fas fa-file text-primary"", ""valid_children"": [""default"", ""file""] },
                  ");
            WriteLiteral(@"  ""file"": { ""icon"": """", ""valid_children"": [] }
                },
                ""plugins"": [""types"", ""wholerow"", ""checkbox""]
            }).on('changed.jstree', function (e, data) {
                if (data.selected.length) {
                    $('#hfTerritories').val(data.selected.join(','));
                } else {
                    $('#hfTerritories').val('');
                }

                var i, j, r = [];
                for (i = 0, j = data.selected.length; i < j; i++) {
                    r.push(data.instance.get_node(data.selected[i]).id.trim());
                }

                $('#jsfields').val(r.join(', '));
            });
    };


// Next Step
    function validateCycleTerritories() {
        var selected = $('#jsfields').val();
        if (!selected) {

            swal.fire({
                //title: 'Select Territories',
                text: ""No Territories Selected"",
                icon: 'warning',
                showCancelButton: false,
       ");
            WriteLiteral("         //cancelButtonClass: \'btn btn-danger\',\r\n                confirmButtonText: \'Ok\',\r\n            });\r\n            return null;\r\n        }\r\n        else {\r\n            return selected;\r\n        }\r\n    }\r\n\r\n\r\n</script>\r\n\r\n\r\n");
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
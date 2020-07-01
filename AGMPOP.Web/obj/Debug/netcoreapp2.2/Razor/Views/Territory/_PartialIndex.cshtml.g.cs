#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Territory\_PartialIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c780ae75f7449c5b19e36811abad1a7f94516f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Territory__PartialIndex), @"mvc.1.0.view", @"/Views/Territory/_PartialIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Territory/_PartialIndex.cshtml", typeof(AspNetCore.Views_Territory__PartialIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c780ae75f7449c5b19e36811abad1a7f94516f6", @"/Views/Territory/_PartialIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Territory__PartialIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Territory\_PartialIndex.cshtml"
  
    ViewData["Title"] = "_PartialIndex";
    Layout = null;

#line default
#line hidden
            BeginContext(71, 227, true);
            WriteLiteral("\r\n<input type=\"text\" id=\"geo-tree_q\" value=\"\" class=\"form-control mb-md mb-4\" placeholder=\"Search\">\r\n<div class=\"alert alert-info text-center\"> Maximum Territories Level is 10 </div>\r\n    <div id=\"geo-tree\">\r\n\r\n    </div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(315, 319, true);
            WriteLiteral(@"
<script>


    function LoadExtOrgTree() {
        $('#geo-tree')
            .jstree({
                ""core"": {
                    ""animation"": 0,
                    ""check_callback"": true,
                    'force_text': true,
                    ""themes"": { """": true },
                    'data': ");
            EndContext();
            BeginContext(635, 26, false);
#line 27 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Territory\_PartialIndex.cshtml"
                       Write(Html.Raw(ViewBag.TreeData));

#line default
#line hidden
            EndContext();
            BeginContext(661, 6389, true);
            WriteLiteral(@"

                },
                ""types"": {
                    ""#"": { ""max_children"": 10, ""max_depth"": 10, ""valid_children"": [""root""] },
                    ""root"": { ""icon"": ""fas fa-suitcase text-success"", ""valid_children"": [""default""] },
                    ""default"": { ""icon"": ""fas fa-suitcase text-info"", ""valid_children"": [""default"", ""file""] },
                    ""file"": { ""icon"": ""fas fa-user"", ""valid_children"": [] }

                },
                ""plugins"": [""contextmenu"", ""dnd"", ""search"", ""state"", ""types"", ""wholerow""]
                ,
                ""contextmenu"": {
                    ""items"": function (node) {
                        var defaultItems = $.jstree.defaults.contextmenu.items();
                      //  console.log(""default items : "" + JSON.stringify(defaultItems));
                        delete defaultItems.ccp;

                        return defaultItems;
                    }
                }
            });
    };


</script>
 
 
<script>
");
            WriteLiteral(@"
    $(function () {

   

              LoadExtOrgTree();

        //search
        var to = false;
        $('#geo-tree_q').keyup(function () {
            if (to) { clearTimeout(to); }
            to = setTimeout(function () {
                var v = $('#geo-tree_q').val();
                $('#geo-tree').jstree(true).search(v);
            }, 250);
        });


        //Rename
        $('#geo-tree')
            // listen for event
            .on('rename_node.jstree', function (e, data) {
                if (!data.text || data.text.toLowerCase() == ""new node"") {

                    Swal.fire({
                        icon: ""info"",
                        text: 'You shoud enter territory name',
                    }).then(
                        function () {
                            PartialTerritoies();
                        });
                }
                else {


                    var dataToSend = JSON.stringify(data.node);
                    //let _u");
            WriteLiteral(@"rl = '/Territory/Create';
                    //if (data.node.id) {
                    //    _url = '/Territory/Edit';
                    //}
                    //   console.log(dataToSend);
                    $.ajax({
                        url: '/Territory/Create',
                        type: 'POST',
                        data: { str: dataToSend },
                        dataType: 'json',
                        success: function (data) {
                            if (data != null) {
                                if (data.success == true) {
                                    PartialTerritoies();
                                    Swal.fire({
                                        text: data.message,
                                        icon: 'success',
                                    })
                                }
                                else if (data.success == false) {
                                    PartialTerritoies();

                    ");
            WriteLiteral(@"                Swal.fire({
                                        text: data.message,
                                        icon: 'error',
                                    })
                                }
                            }
                        },
                        error: function () {
                            alert('Error in Create or Edit');
                        }
                    });

                }
            })
            // create the instance
            .jstree();

        //************************************************
        $('#geo-tree')
            // listen for event
            .on('delete_node.jstree', function (e, data) {
                //console.log(data.node);
                //var dataToSend = JSON.stringify(data.node);
                //var _id = data.node.id;

                    Swal.fire({
                        text: ""Are you sure you want to remove this territory?"",
                        icon: 'question',");
            WriteLiteral(@" 
                        showCancelButton: true,
                        confirmButtonColor: '#4285f4',
                        cancelButtonColor: '#a1a1a1',
                        confirmButtonText: 'Ok'


                    // when press yes remove
                }).then((result) => {
                    if (result.value) {
                        $.ajax({
                            url: '/Territory/Delete/' + data.node.id,
                            dataType: 'json',
                            type: ""GET"",
                            success: function (data) {
                                if (data != null) {
                                    // when remove done
                                    if (data.success) {
                                        Swal.fire({
                                           text: data.message,
                                            icon: 'success',
                                        }
              
                           ");
            WriteLiteral(@"             ).then(
                                            function () {
                                                PartialTerritoies();
                                            }
                                        );
                                    }
                                    // when cant remove [there are child]
                                    else {
                                        Swal.fire({
                                            text: data.message,
                                            icon: 'error',
                                        }).then(
                                            function () {
                                                PartialTerritoies();
                                            }
                                        );
                                    }
                                }
                            },
                        });
                    }
                  ");
            WriteLiteral("  // when cancel sweet alert\r\n                    else {\r\n                        PartialTerritoies();\r\n                    }\r\n\r\n                })\r\n\r\n            })\r\n            // create the instance\r\n          .jstree();\r\n    });\r\n\r\n</script>");
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

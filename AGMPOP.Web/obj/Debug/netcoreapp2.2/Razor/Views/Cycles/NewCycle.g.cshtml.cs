#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c228a8c7a30e8eaab0dc0898e27a616e2c446b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cycles_NewCycle), @"mvc.1.0.view", @"/Views/Cycles/NewCycle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cycles/NewCycle.cshtml", typeof(AspNetCore.Views_Cycles_NewCycle))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c228a8c7a30e8eaab0dc0898e27a616e2c446b", @"/Views/Cycles/NewCycle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_Cycles_NewCycle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AGMPOP.Web.Models.Cycle._CycleDetalisTab>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/create-cycle-general.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/create-cycle-product.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/create-cycle-user.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
  
    ViewData["Title"] = ViewBag.Title;

#line default
#line hidden
            BeginContext(98, 910, true);
            WriteLiteral(@"<style>
    .select-wrapper span.caret {
        right: 30px;
    }
</style>
<div class="" card card-body mt-2"">
    <ul id=""tabs"" class=""nav nav-tabs"">
        <li id=""liStep_1"" class=""nav-item active"">
            <a class=""nav-link active"" href=""#home"" data-step=""1"" data-toggle=""tab"">Cycle Details</a>
        </li>
        <li id=""liStep_2"" class=""nav-item"">
            <a class=""nav-link"" href=""#territories"" data-step=""2"" data-toggle=""tab"">Territories</a>
        </li>
        <li id=""liStep_3"" class=""nav-item"">
            <a class=""nav-link"" href=""#products"" data-step=""3"" data-toggle=""tab"">Products</a>
        </li>
        <li id=""liStep_4"" class=""nav-item"">
            <a class=""nav-link"" href=""#users"" data-step=""4"" data-toggle=""tab"">Users</a>
        </li>
    </ul>
    <div class=""tab-content"">
        <div id=""home"" class=""tab-pane fade in active show"">
            ");
            EndContext();
            BeginContext(1009, 49, false);
#line 28 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
       Write(await Html.PartialAsync("CycleDetalisTab", Model));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 1123, true);
            WriteLiteral(@"
        </div>
        <div id=""territories"" class=""tab-pane fade in""></div>
        <div id=""products"" class=""tab-pane fade in""></div>
        <div id=""users"" class=""tab-pane fade in""></div>
    </div>
    <div class="" col-12 text-right"">
        <button type=""button"" class=""btn btn-dark px-3 mr-0"" id=""btnBack"" disabled>Back</button>
        <button type=""button"" class=""btn btn-primary px-3 mr-0"" id=""btnNext"">Next</button>
    </div>
</div>

<div class=""modal fade"" id=""ChooseHrModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Select HR User</h4>
            </div>
            <div class=""modal-body text-center"">
                <div id=""ModelContent"">
                    <div class=""form-group"">
                        <label>select HR user</label>
                        <select id=""fi");
            WriteLiteral("rstHr\" name=\"firstHr\" class=\"mdb-select\" Searchable=\"Search here...\">\r\n                            ");
            EndContext();
            BeginContext(2181, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c228a8c7a30e8eaab0dc0898e27a616e2c446b7534", async() => {
                BeginContext(2216, 15, true);
                WriteLiteral("Select First Hr");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            BeginContext(2240, 527, true);
            WriteLiteral(@"
                        </select>
                        <span class=""text-danger"" id=""firstHrMsg""> </span>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btn_cancelHR"" class=""btn btn-secondary"">Cancel</button>
                <button type=""button"" id=""btn_chooseHR"" class=""btn btn-success"">Save</button>
            </div>
        </div>
    </div>
</div>
<script>
    var CycleObj = {};
    var CycleId = ");
            EndContext();
            BeginContext(2768, 8, false);
#line 66 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
             Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2776, 223, true);
            WriteLiteral(";\r\n</script>\r\n\r\n<script>\r\n\r\n    function GetfirstHr() {\r\n        $(\'#firstHr\').empty();\r\n        $(\'#firstHr\').append(\'<option value=\"\" selected disabled>Select First Hr</option>\');\r\n          $.ajax({\r\n              url: \'");
            EndContext();
            BeginContext(3000, 39, false);
#line 75 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
               Write(Url.Action("LoadCycleStatus", "cycles"));

#line default
#line hidden
            EndContext();
            BeginContext(3039, 454, true);
            WriteLiteral(@"',
              method: 'GET',
              async: false,

              success: response => {
                  if (response) {
                      response.forEach(d => {
                          $('#firstHr').append(`<option value=""${d.statusId}"">${d.name}</option>`);
                      });
                  }
              }
          });
    }
</script>
<script>


    function loadTerrtiroiesTab() {
        var url = '");
            EndContext();
            BeginContext(3494, 30, false);
#line 93 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
              Write(Url.Action("_CycleTerritoies"));

#line default
#line hidden
            EndContext();
            BeginContext(3524, 467, true);
            WriteLiteral(@"';
        if (CycleId) {
            url += `?cycleId=${CycleId}`;
        }
        $.ajax({
            url,
            method: 'GET',
            success: response => {
                if (response) {
                    $('#territories').html(response);
                    $('.nav-tabs a[href=""#territories""]').tab('show');
                }
            }
        })
    }

    function loadProductsTab() {
        $.ajax({
            url: '");
            EndContext();
            BeginContext(3992, 34, false);
#line 111 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
             Write(Url.Action("CreateCycle_Products"));

#line default
#line hidden
            EndContext();
            BeginContext(4026, 344, true);
            WriteLiteral(@"',
            method: 'GET',
            success: response => {
                if (response) {
                    $('#products').html(response);
                    $('.nav-tabs a[href=""#products""]').tab('show');
                }
            }
        })
    }

    function loadUsersTab() {
        $.ajax({
            url: '");
            EndContext();
            BeginContext(4371, 31, false);
#line 124 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
             Write(Url.Action("CreateCycle_Users"));

#line default
#line hidden
            EndContext();
            BeginContext(4402, 999, true);
            WriteLiteral(@"',
            method: 'GET',
            success: response => {
                if (response) {
                    $('#users').html(response);
                    $('.nav-tabs a[href=""#users""]').tab('show');
                }
            }
        })
    }

    function ChooseFirstHr() {
        var obj = SelectedUserIds;
        data = JSON.stringify(obj);
         $.ajax({
            url: ""/Cycles/GetHrUsers"",
            type:""POST"",
             data: data,
             contentType: ""application/json"",
            success: response => {
                console.log(response);

                $('#ModelContent').html(response);
                $('#ChooseHrModal').modal('show');

             },
             error: function (x, y, z) {
                 console.log(x);
                 console.log(y);
                 console.log(z);
             }

        });


    }



    function submitCreateCycle() {
        $.ajax({
            url: '");
            EndContext();
            BeginContext(5402, 25, false);
#line 165 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
             Write(Url.Action("CreateCycle"));

#line default
#line hidden
            EndContext();
            BeginContext(5427, 335, true);
            WriteLiteral(@"',
            method: 'POST',
            data: CycleObj,
            success: response => {
                if (response.ok) {
                    Swal.fire({
                        icon: 'success',
                        text: response.message,
                    }).then(_ => {
                        location.href = '");
            EndContext();
            BeginContext(5763, 28, false);
#line 174 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
                                    Write(Url.Action("List", "Cycles"));

#line default
#line hidden
            EndContext();
            BeginContext(5791, 440, true);
            WriteLiteral(@"';
                    });
                }
                else {
                    Swal.fire({
                        icon: 'error',
                        text: response.message,
                    })
                }
            }
        })
    }

    function submitUpdateCycle() {
        if (CycleObj.details.id) {
            CycleObj.id = CycleObj.details.id;
        }
        $.ajax({
            url: '");
            EndContext();
            BeginContext(6232, 25, false);
#line 192 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
             Write(Url.Action("UpdateCycle"));

#line default
#line hidden
            EndContext();
            BeginContext(6257, 335, true);
            WriteLiteral(@"',
            method: 'POST',
            data: CycleObj,
            success: response => {
                if (response.ok) {
                    Swal.fire({
                        icon: 'success',
                        text: response.message,
                    }).then(_ => {
                        location.href = '");
            EndContext();
            BeginContext(6593, 28, false);
#line 201 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
                                    Write(Url.Action("List", "Cycles"));

#line default
#line hidden
            EndContext();
            BeginContext(6621, 7228, true);
            WriteLiteral(@"';
                    });
                }
                else {
                    Swal.fire({
                        icon: 'error',
                        text: response.message,
                    })
                }
            }
        })
    }

    async function setDisabledTabs() {
        var step = await getCurrentStep();
        switch (step) {
            case 1:
                $('.nav-link[data-step=1]').css('pointer-events', '');
                $('.nav-link[data-step=2],.nav-link[data-step=3],.nav-link[data-step=4]').css('pointer-events', 'none');
                break;
            case 2:
                $('.nav-link[data-step=1],.nav-link[data-step=2]').css('pointer-events', '');
                $('.nav-link[data-step=3],.nav-link[data-step=4]').css('pointer-events', 'none');
                break;
            case 3:
                $('.nav-link[data-step=1],.nav-link[data-step=2],.nav-link[data-step=3]').css('pointer-events', '');
                $('.nav-l");
            WriteLiteral(@"ink[data-step=4]').css('pointer-events', 'none');
                break;
            case 4:
                $('.nav-link[data-step=1],.nav-link[data-step=2],.nav-link[data-step=3],.nav-link[data-step=4]').css('pointer-events', '');
                break;
        }
    }

    async function setButtonText() {
        var step = await getCurrentStep();
        if (step == 4) {
            $('#btnNext').text('Save');
        }
        else {
            $('#btnNext').text('Next');
        }
    }

    function getCurrentStep() {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                var tab = $('.nav-link.active');
                resolve(tab.data('step'));
            }, 100);
        })
    }
</script>

<script>
    $(() => {
        setDisabledTabs();
        setButtonText();
        $('#btnNext').on('click', async e => {
            var step = await getCurrentStep();
            if (step == 1) {
                let detailsObj = awai");
            WriteLiteral(@"t validateCycleDetails();
                if (detailsObj) {
                    CycleObj['details'] = detailsObj;
                    loadTerrtiroiesTab();
                    $('#btnBack').prop('disabled', false);
                }
                else {
                    CycleObj = {};
                    return;
                }
            } else if (step == 2) {
                let territoriesObj = validateCycleTerritories();
                if (territoriesObj) {
                    CycleObj['territories'] = territoriesObj;
                    CycleDepartment = CycleObj['details']['department'];
                    loadProductsTab();
                    resetSelectedProducts();
                } else {
                    return;
                }
            } else if (step == 3) {
                let productsObj = validateCycleProducts();
                if (productsObj) {
                    CycleObj['products'] = productsObj;
                    CycleDepartment = CycleObj['");
            WriteLiteral(@"details']['department'];
                    loadUsersTab();
                    resetSelectedUsers();
                } else {
                    return;
                }
            }
            else if (step == 4) {
                let usersObj = validateCycleUsers();
                if (usersObj) {
                    // check
                    console.log(usersObj);
                    let HRUsers = usersObj.filter(u => u.jobTitleName && u.jobTitleName.toLowerCase() == 'hr');
                    if (HRUsers.length > 1 && !CycleId) {
                        var hrId = await GetHrUsers(HRUsers);
                        console.log(hrId);
                        if (hrId <= 0) {
                            Swal.fire({
                                icon: 'warning',
                                text: 'You must select hr user',
                            });
                            return;
                        }
                        CycleObj.hRUser = hrId;
         ");
            WriteLiteral(@"           }
                    else if (HRUsers.length == 1) {
                        CycleObj.hRUser = HRUsers[0].id;
                    }
                    let BBxUsers = usersObj.filter(u => u.jobTitleName && u.jobTitleName.toLowerCase() == 'bbx');
                    if (BBxUsers.length == 1) {
                        CycleObj.bBXUser = BBxUsers[0].id;
                    }

                    CycleObj['users'] = usersObj.map(p => p.id);
                    if (CycleId) {
                        submitUpdateCycle();
                    } else {
                        submitCreateCycle();
                    }
                }
            } else {
                return;
            }
            setDisabledTabs();
            setButtonText();
        });
    });

    $('#btnBack').on('click', async e => {
        var step = await getCurrentStep();
        if (step == 1) {
            $('#btnBack').prop('disabled', true);
            return;
        }
        else if ");
            WriteLiteral(@"(step == 2) {
            CycleObj = {};
            $('#btnBack').prop('disabled', true);
            $('.nav-tabs a[href=""#home""]').tab('show');
        }
        else if (step == 3) {
            delete CycleObj['territories'];
            resetSelectedProducts();
            $('.nav-tabs a[href=""#territories""]').tab('show');
        }
        else if (step == 4) {
            delete CycleObj['products'];
            resetSelectedUsers();
            $('.nav-tabs a[href=""#products""]').tab('show');
        } else {
            return;
        }
        setDisabledTabs();
        setButtonText();
    });

    $('.nav-item, .nav-link').on('click', e => {
        setDisabledTabs();
        setButtonText();
    });
    async function GetHrUsers(hrUsers) {
        return new Promise(function (resolve, reject) {
            try {
                var done = false;
                $('#firstHr').empty();
                $('#firstHr').append('<option value="""" selected disabled>Select Fir");
            WriteLiteral(@"st Hr</option>');
                $('#firstHrMsg').text('');
                for (var item of hrUsers) {
                    $('#firstHr').append('<option value=' + item.id + ' >' + item.name + ' </option>');
                }
                $('#firstHr').materialSelect()
                $('#ChooseHrModal').modal('show');
                $('#btn_chooseHR').on('click', function (e) {
                    var hr = $('#firstHr').val();
                    if (hr) {
                        done = true;
                        $('#ChooseHrModal').modal('hide');
                        resolve(hr);
                    }
                    else {
                        $('#firstHrMsg').text('Choose one hr');
                    }

                });
                $('#ChooseHrModal').on('hidden.bs.modal', function () {
                    if (!done) {
                        resolve(0);
                    }
                });
            }
            catch (e) {
                resol");
            WriteLiteral("ve(0);\r\n            }\r\n        });\r\n    }\r\n\r\n</script>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(13867, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(13873, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c228a8c7a30e8eaab0dc0898e27a616e2c446b24436", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13930, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(13936, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c228a8c7a30e8eaab0dc0898e27a616e2c446b25694", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(13993, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(13999, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c228a8c7a30e8eaab0dc0898e27a616e2c446b26952", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(14053, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 408 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\Cycles\NewCycle.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AGMPOP.Web.Models.Cycle._CycleDetalisTab> Html { get; private set; }
    }
}
#pragma warning restore 1591

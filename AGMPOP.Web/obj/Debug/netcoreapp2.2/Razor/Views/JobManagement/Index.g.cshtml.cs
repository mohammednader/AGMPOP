#pragma checksum "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\JobManagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7a73350ab2c55b6df71f374cd9a8b39fd6ba1d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JobManagement_Index), @"mvc.1.0.view", @"/Views/JobManagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JobManagement/Index.cshtml", typeof(AspNetCore.Views_JobManagement_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7a73350ab2c55b6df71f374cd9a8b39fd6ba1d0", @"/Views/JobManagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3344144602cec692e91fef16bcf12fc0a4de791", @"/Views/_ViewImports.cshtml")]
    public class Views_JobManagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AGMPOP.BL.Models.Domain.JobTitle>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\JobManagement\Index.cshtml"
  
    ViewBag.Title = "Jobs Management";

#line default
#line hidden
            BeginContext(101, 2931, true);
            WriteLiteral(@"<style>

    .btn btn-default btn-icon table-action {
        display: none
    }

    ul {
        list-style: none;
    }
</style>

<div class=""card  px-3 py-2"">
    <div class=""row"">
        <div class=""col-sm-12 col-md-3 d-inline-block""> 
            <div class=""ui-widget"">
                <input class=""form-control mt-1"" placeholder=""Job Title"" id=""jobName"" style=""height:39px;"">
                <span class=""d-none"" id=""sp_msg"" style=""color:red"">This field is required.</span>
            </div> 
        </div>
        <div class=""text-right"">
            <button type=""button"" class=""btn btn-secondary px-3 mr-0"" style=""height: 35px;"" id=""cancelMsg"">Cancel</button>


            <button class=""btn btn-primary px-3"" id=""save"" style=""height: 35px;""> Add job</button>
        </div>

        
    </div>

</div>




<div class=""card card-body my-3"">
         <div id=""divResult""></div>
 </div><!--  end card  -->

<script type=""text/javascript"">
    var show = 0;
    $(docum");
            WriteLiteral(@"ent).ready(function () {
        
         GetJobs();
        $('#mn-admin').addClass('active');
        $('#adminlinks').addClass('in');
         $('#mn-jobs').addClass('active');

        $(""#cancelMsg"").click(function () { $(""#jobName"").val(""""); });   

        //   ** Add job  **//
        $(""#save"").click(function () {

            if ($(""#jobName"").val() != null && $(""#jobName"").val() != '') {
                var JobTitle = $(""#jobName"").val()

                $.ajax({
                    url: ""/JobManagement/AddJob"",
                    type: ""post"",
                    data: { JobTitle },
                    success: function (data, textStatus, jqXHR) {
                        $(""#sp_msg"").addClass('d-none');
                        if (data) {
                            if (data.success) {

                                Swal.fire({
                                    icon: 'success',
                                    text: data.message,
                                ");
            WriteLiteral(@"    showConfirmButton:'btn btn-primary',
                                  

                                }).then((result) => { GetJobs(); $(""#jobName"").val(""""); });

                            }
                            else {
                                Swal.fire({
                                    icon: 'error',
                                    text: data.message,
                                }).then((result) => { $(""#jobName"").val(""""); });
                              
                              
                            }

                        }
                    }


                });
            }
            else {
                $(""#sp_msg"").removeClass(""d-none"");
            }

        });
    });

    // ** Get partial view **//
      function GetJobs() {

             $.ajax({
            url: '");
            EndContext();
            BeginContext(3033, 27, false);
#line 104 "E:\TFS\POPAGM\AGMPOP_Core\AGMPOP.Web\Views\JobManagement\Index.cshtml"
             Write(Url.Action("_JobTitleList"));

#line default
#line hidden
            EndContext();
            BeginContext(3060, 5739, true);
            WriteLiteral(@"',
            method: 'Get',

            success: response => {
                if (response) {
                    $('#divResult').html('');
                    $('#divResult').html(response);
                    //bootstrapTable();

                }
                 }, error: function () {
                alert(""Error"");
                 }
        })


        }

    //   **edit button partial view**   //
    function editJob(id) {
        if (show == 0) {
            $(""#"" + id).prop('disabled', false);
            $(""#"" + id + ""save"").toggleClass('d-inline');
            $(""#"" + id + ""edit"").toggleClass('d-none');
            $(""#"" + id + ""cancle"").toggleClass('d-inline');
            $(""#msg"").addClass('d-none');
            changeJob(id);
        }
        show = 1;
    }

    //  ** cancel button partial view **//
    function cancleJob(id) {
        $(""#"" + id).val($(""#temp"").val());
        $(""#"" + id + ""save"").toggleClass('d-inline');
        $(""#"" + id + ""edit""");
            WriteLiteral(@").toggleClass('d-none');
        $(""#"" + id + ""cancle"").toggleClass('d-inline');

        $(""#msg"").addClass('d-none');
        $(""#"" + id).prop('disabled', true);
        show = 0;

    }

    // **  save temp data ** //
    function changeJob(id) {

        var change = $(""#"" + id).val();
        $(""#temp"").val(change);
    }

    //   **update Job** //
    function saveJob(id) {
        show = 0;
        if (!$(""#"" + id).val()) {

            $(""#msg"").addClass(""d-none"");

        }
        else {

            // check two values temp vs actual

            if ($(""#"" + id).val() != $(""#temp"").val()) {

                if ($(""#"" + id).val() != null) {
                    var _parameters = { Id: id, JobTitle: $(""#"" + id).val() }
                }
                else {
                    var _parameters = { Id: id }

                }


                $.ajax({
                    url: ""/JobManagement/EditJob"",
                    type: ""GET"",
                    da");
            WriteLiteral(@"ta: _parameters,
                    success: function (data, textStatus, jqXHR) {
                        if (data) {
                            if (data.success) {

                                Swal.fire({
                                    icon: 'success',
                                    text: data.message,
                                })
                                $(""#msg"").addClass('d-none');
                            }
                            else {
                                Swal.fire({
                                    icon: 'error',
                                    text: data.message,
                                })
                                $(""#msg"").addClass('d-none');
                                $(""#"" + id).val($(""#temp"").val()); 
                            }
                        }
                        $(""#"" + id + ""save"").toggleClass('d-inline');
                        $(""#"" + id + ""edit"").toggleClass('d-none');
         ");
            WriteLiteral(@"               $(""#"" + id + ""cancle"").toggleClass('d-inline');
                        $(""#"" + id).prop('disabled', true);

                    }
                });

            }
            else {
                Swal.fire({
                    text: 'Nothing changes !',
                    icon: 'info',
                });
                $(""#"" + id + ""save"").toggleClass('d-inline');
                $(""#"" + id + ""edit"").toggleClass('d-none');
                $(""#"" + id + ""cancle"").toggleClass('d-inline');
                $(""#"" + id).prop('disabled', true);


            }
        }
    }

    // ** delete job **//
    function showSwal(id) {

        console.log(""deleted"");
        console.log(id);

        Swal.fire({
            text: 'Are you sure delete this job title?',
          
            icon: 'error',
            showCancelButton: true,
            confirmButtonClass: 'btn btn-danger',
            //cancelButtonClass: 'btn btn-secondary',
            confirmBu");
            WriteLiteral(@"ttonText: 'Yes, Delete it!',
        }).then((result) => {

            if (result.value) {
                var _parameters = { JobId: id };
                $.ajax({
                    url: ""/JobManagement/DeleteJob"",
                    type: ""GET"",
                    data: _parameters,
                    success: function (data, textStatus, jqXHR) {
                        //$('#divUsers').html(data);
                        // window.location.href = ""/JobManagement/Index"";
                        GetJobs();
                       

                    }
                }).then((data) => {
                    if (data.success) {
                        Swal.fire({
                            icon: 'success',
                            text: data.message,
                        })
                    }
                    else {
                        Swal.fire({
                            icon: 'error',
                            text: data.message,
                       ");
            WriteLiteral(@"    
                        })
                    }
                    });

               
            } else if (

                // Read more about handling dismissals
                result.dismiss === swal.DismissReason.cancel
            ) {
                //swal({
                //    title: 'Canceled!',
                //    text: 'Your file has been not deleted.',
                //    type: 'success',
                //    confirmButtonClass: ""btn btn-primary"",
                //    buttonsStyling: false
                //})
            }

        });

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AGMPOP.BL.Models.Domain.JobTitle>> Html { get; private set; }
    }
}
#pragma warning restore 1591

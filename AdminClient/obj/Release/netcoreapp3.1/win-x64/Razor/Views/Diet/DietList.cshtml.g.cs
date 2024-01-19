#pragma checksum "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2db628d292eee100f4cb5776a531c227384c38f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diet_DietList), @"mvc.1.0.view", @"/Views/Diet/DietList.cshtml")]
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
#nullable restore
#line 1 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2db628d292eee100f4cb5776a531c227384c38f0", @"/Views/Diet/DietList.cshtml")]
    #nullable restore
    public class Views_Diet_DietList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Diet/DietCreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon btn-sm text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
  
    ViewBag.Title = "Diet";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .btn-secondary {
        color: #fff;
        background: #0099ff !important;
        border-color: #0099ff;
    }

    .h-7 {
        height: 1rem !important;
    }

    .w-7 {
        width: 1rem !important;
    }
</style>
<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i> Diet</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Diet-List</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2db628d292eee100f4cb5776a531c227384c38f04634", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Diet Create\r\n        ");
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
            WriteLiteral(@"

    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">File export Datatable</div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""diet"" class=""table table-striped table-bordered text-nowrap w-100"">
                        <thead>
                            <tr>
                                <th>Patient Name</th>
                                <th>Bed No</th>
                                <th>Floor Name</th>
                                <th>Service Type</th>
                                <th>Status</th>
                                <th>Pickup Date/Time</th>
                                <th>Deliver Date/Time</th>
                                <th>Collect Date/Time</th>
                                <th>Feedback</th>
                                <th>Actio");
            WriteLiteral(@"n</th>
                            </tr>
                        </thead>

                    </table>
                    <div class=""row"">
                        <div class=""col-md-6 col-lg-4 col-sm-6"">
                            <div class=""d-flex align-items-center mb-3 mt-3"">
                                <div class=""w-7 h-7 bg-gray  mr-4""></div>
                                <div>
                                    <strong>QrCode generate</strong>
                                </div>
                            </div>
                            <div class=""d-flex align-items-center mb-3 mt-3"">
                                <div class=""w-7 h-7 bg-purple  mr-4""></div>
                                <div>
                                    <strong>Out From Kitchen</strong>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 col-lg-4 col-sm-6"">
                            <di");
            WriteLiteral(@"v class=""d-flex align-items-center mb-3 mt-3"">
                                <div class=""w-7 h-7 bg-yellow  mr-4""></div>
                                <div>
                                    <strong>Deliver to Patient</strong>
                                </div>
                            </div>
                            <div class=""d-flex align-items-center mb-3 mt-3"">
                                <div class=""w-7 h-7 bg-lime  mr-4""></div>
                                <div>
                                    <strong>Clearance</strong>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-6 col-lg-4 col-sm-6"">
                            <div class=""d-flex align-items-center mb-3 mt-3"">
                                <div class=""w-7 h-7 bg-red  mr-4""></div>
                                <div>
                                    <strong>Pending</strong>
                          ");
            WriteLiteral("      </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        loadDiet()
        function loadDiet() {
             var table = $('#diet').DataTable();
             table.destroy();
             table = $('#diet').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'Bfrtip',
                ""buttons"": ['copy', 'csv', 'excel', 'pdf', 'print'],
                ""searching"": true,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 126 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DIETMaster/GetHospitalwiseDietList/\' + ");
#nullable restore
#line 126 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
                                                                          Write(Context.Session.GetInt32("HospitalMasterid"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 130 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
                                            Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    ""error"": function (data) {
                        if (data.status == 401) {
                            window.location.replace('/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }
                    }
                },

                ""order"": [],
                ""columns"": [
                    { ""data"": ""patientName"", ""orderable"": true },
                    { ""data"": ""bedNo"", ""orderable"": true },
                    { ""data"": ""floorsName"", ""orderable"": true },
                    { ""data"": ""foodServiceTypeName"", ""orderable"": true },
                   
                    {
                        ""render"": function (data, type, row) {

                            if (row.status === 'BarCode generate') {
                                return '<p class=""tag tag-gray-dark"">' + row.status + '</p>';
        ");
                WriteLiteral(@"                    }
                            else if (row.status === 'Out From Kitchen') {
                                return '<p class=""tag tag-purple"">' + row.status + '</p>';
                            }
                            else if (row.status === 'Deliver to Patient') {
                                return '<p class=""tag tag-yellow"">' + row.status + '</p>';
                            }
                            else if (row.status === 'Clearance') {
                                return '<p class=""tag tag-lime"">' + row.status + '</p>';
                            }
                            else if (row.status === 'Pending') {
                                return '<p class=""tag tag-red"">' + row.status + '</p>';
                            }

                        }
                    },
                    {
                        ""data"": ""plateReciveDate"",
                        ""orderable"": true,
                        ""render"": function (data, type, ");
                WriteLiteral(@"row) {
                            return row.plateReciveDate != null ? row.plateReciveDate.substring(0, 10) : '';
                        }
                    },
                    {
                        ""data"": ""plateDeliverDate"",
                        ""orderable"": true,
                        ""render"": function (data, type, row) {
                            return row.plateDeliverDate != null ? row.plateDeliverDate.substring(0, 10) : '';
                        }
                    },
                    {
                        ""data"": ""plateCollectionDate"",
                        ""orderable"": true,
                        ""render"": function (data, type, row) {
                            return row.plateCollectionDate != null ? row.plateCollectionDate.substring(0, 10) : '';
                        }
                    },
                    {
                        ""render"": function (data, type, row) {

                            if (row.feedback === 'Feedback not add");
                WriteLiteral(@"ed') {
                                return '<span class=""badge badge-pill badge-default"">' + row.feedback + '</span>';
                            }
                            if (row.feedback === 'Brilliant') {
                                return '<span class=""badge badge-pill badge-primary"">' + row.feedback + '</span>';
                            }
                            if (row.feedback === 'Good') {
                                return '<span class=""badge badge-pill badge-success"">' + row.feedback + '</span>';
                            }
                            if (row.feedback === 'Ok') {
                                return '<span class=""badge badge-pill badge-info"">' + row.feedback + '</span>';
                            }
                            if (row.feedback === 'Not Good') {
                                return '<span class=""badge badge-pill badge-danger"">' + row.feedback + '</span>';
                            }

                        }
         ");
                WriteLiteral(@"           },
                    {
                        ""render"": function (data, type, row) {
                            return '<a class=""btn btn-success"" href=""../Diet/DietEdit?dietMasterId=' + row.dietMasterId + '""><i class=""fa fa-edit""></i></a>' + '&nbsp&nbsp<button class=""btn btn-success"" data-target=""#delete"" data-id=' + row.dietMasterId + ' data-title=""Delete""><i class=""fe fe-check mr-2""></i>Discharge</button> ';
                        }
                    }

                ]
            });
        }

       //Delete
        $('#diet tbody').on('click', 'button[data-target=""#delete""]', function () {
            var id = $(this).data('id');
            swal({
                html: true,
                title: ""Are you sure?"",
                text: ""You will not be able to recover this data!"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonColor: ""#DD6B55"",
                confirmButtonText: ""Yes, confirm it!"",
       ");
                WriteLiteral("         closeOnConfirm: false\r\n            }, function () {\r\n                $.ajax({\r\n                    type: \"GET\",\r\n                    url: \"");
#nullable restore
#line 236 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DIETMaster/DeleteDiet/\" +id+\"/\"+");
#nullable restore
#line 236 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
                                                                 Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 239 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\Diet\DietList.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        if (xhr.status == 200) {
                            $('#diet').DataTable().ajax.reload(null, false);
                            sweetAlert({
                                html: true,
                                title: ""FoodType"",
                                text: ""Successfully deleted!"",
                                type: ""success""
                            });
                        } else if (xhr.status == 202) {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else {
                            sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                        }
                    },
                    error: function (data) {
                        if (data.status == 401) {
                            window.location.replace(");
                WriteLiteral(@"'/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }
                    }
                });
            });
        });

        

    </script>

");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

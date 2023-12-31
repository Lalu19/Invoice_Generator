#pragma checksum "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7a37b88117eb8d770f03daa98f49a95690719f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invoice_InvoiceList), @"mvc.1.0.view", @"/Views/Invoice/InvoiceList.cshtml")]
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
#line 1 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7a37b88117eb8d770f03daa98f49a95690719f", @"/Views/Invoice/InvoiceList.cshtml")]
    #nullable restore
    public class Views_Invoice_InvoiceList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Invoice/InvoiceCreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
  
    ViewBag.Title = "Invoice";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css"" rel=""stylesheet"">
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>User Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Invoice List</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7a37b88117eb8d770f03daa98f49a95690719f4380", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Add New\r\n        ");
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
                <div class=""card-title"">Invoice List</div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""Stability_Tb"" class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>Invoice</th>
                                <th>Invoice No</th>
                                <th>Bill from </th>
                                <th>Bill To </th>
                                <th>Invoice Date</th>
                                <th>Due Date</th>
                                <th>Payment Term</th>
                                <th>PO Number</th>
                                <th>Subtotal</th>
                         ");
            WriteLiteral(@"       <th>Discounts</th>
                                <th>Vat</th>
                                <th>GrandTotal</th>
                                <th>AmountPaid</th>
                                <th>BalanceDue</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        //List
        loadSingleLTlist()
        async function loadSingleLTlist() {
            var table = $('#Stability_Tb').DataTable();
            table.destroy();
            table = $('#Stability_Tb').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'Bfrtip',
                ""buttons"": ['csv', 'excel'],
                ""searching"": true,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 74 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Invoice/InvoiceListbyuserid/\' + ");
#nullable restore
#line 74 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
                                                                   Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 78 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
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
                   
                    {
                        ""render"": function (data, type, row) {
                            return '<a class=""btn btn-sm btn-danger"" href=""../Invoice/Invoic?invoiceId=' + row.invoiceId + '""><i class=""fas fa-file-pdf""></i></a>';

                        }
                    },
                    { ""data"": ""invoiceNo"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""billFrom"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""billTo"", ""orderable"": true, ""visib");
                WriteLiteral(@"le"": true },
                    {
                        ""data"": ""invoiceDate"",
                        ""render"": function (data) {
                            if (data === null) return """";
                            var date = new Date(data);
                            var day = date.getDate();
                            var month = date.getMonth() + 1;
                            var year = date.getFullYear();
                            var hour = date.getHours();
                            var amOrPm = hour >= 12 ? ""PM"" : ""AM"";

                            // Convert 24-hour format to 12-hour format
                            if (hour > 12) {
                                hour = hour - 12;
                            } else if (hour === 0) {
                                hour = 12;
                            }
                            return (
                                (day < 10 ? ""0"" + day : day) +
                                ""/"" +
                           ");
                WriteLiteral(@"     (month < 10 ? ""0"" + month : month) +
                                ""/"" +
                                year.toString().substring(2) +
                                ""&nbsp;&nbsp;"" +
                                (hour < 10 ? ""0"" + hour : hour) +
                                "":"" +
                                (date.getMinutes() < 10 ? ""0"" + date.getMinutes() : date.getMinutes()) +
                                "" "" +
                                amOrPm
                            );
                        }
                    },
                    {
                        ""data"": ""dueDate"",
                        ""render"": function (data) {
                            if (data === null) return """";
                            var date = new Date(data);
                            var day = date.getDate();
                            var month = date.getMonth() + 1;
                            var year = date.getFullYear();
                            var hour = dat");
                WriteLiteral(@"e.getHours();
                            var amOrPm = hour >= 12 ? ""PM"" : ""AM"";

                            // Convert 24-hour format to 12-hour format
                            if (hour > 12) {
                                hour = hour - 12;
                            } else if (hour === 0) {
                                hour = 12;
                            }
                            return (
                                (day < 10 ? ""0"" + day : day) +
                                ""/"" +
                                (month < 10 ? ""0"" + month : month) +
                                ""/"" +
                                year.toString().substring(2) +
                                ""&nbsp;&nbsp;"" +
                                (hour < 10 ? ""0"" + hour : hour) +
                                "":"" +
                                (date.getMinutes() < 10 ? ""0"" + date.getMinutes() : date.getMinutes()) +
                                "" "" +
                         ");
                WriteLiteral(@"       amOrPm
                            );
                        }
                    },

                    { ""data"": ""paymentTerm"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""poNumber"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""subTotal"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""discounts"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""vat"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""grandTotal"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""amountPaid"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""balanceDue"", ""orderable"": true, ""visible"": true },

                ]
            });
        }

        // //Delete
        // $('#Stability_Tb tbody').on('click', 'button[data-target=""#delete""]', function () {
        //     var id = $(this).data('id');
        //     swal({
        //         html: true,
   ");
                WriteLiteral(@"     //         title: ""Are you sure?"",
        //         text: ""You will not be able to recover this data!"",
        //         type: ""warning"",
        //         showCancelButton: true,
        //         confirmButtonColor: ""#DD6B55"",
        //         confirmButtonText: ""Yes, confirm it!"",
        //         closeOnConfirm: false
        //     }, function () {
        //         $.ajax({
        //             type: ""GET"",
        //             url: """);
#nullable restore
#line 193 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
                        Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/StabilityCertificate/DeleteCategory/\" + id + \"/\" + ");
#nullable restore
#line 193 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
                                                                                       Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n        //             contentType: \"application/json; charset=utf-8\",\r\n        //             headers: {\r\n        //                 \"authorization\": \"Bearer ");
#nullable restore
#line 196 "D:\Invoice\AdminClient\Views\Invoice\InvoiceList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
        //             },
        //             dataType: ""json"",
        //             success: function (data, statusText, xhr) {
        //                 if (xhr.status == 200) {
        //                     $('#Stability_Tb').DataTable().ajax.reload(null, false);
        //                     sweetAlert({
        //                         html: true,
        //                         title: ""Certificate Of Stability"",
        //                         text: ""Successfully deleted!"",
        //                         type: ""success""
        //                     });
        //                 } else if (xhr.status == 202) {
        //                     sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
        //                 } else {
        //                     sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
        //                 }
        //             },
        //             error: function (data) {
        //               ");
                WriteLiteral(@"  if (data.status == 401) {
        //                     window.location.replace('/Message/TokenExpire');
        //                 } else if (data.status == 403) {
        //                     window.location.replace('/Message/Unauthorize');
        //                 }
        //             }
        //         });
        //     });
        // });
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

#pragma checksum "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "928fd4f4d4e3d9899360725941b9466eaf948577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dietician_DieticianEdit), @"mvc.1.0.view", @"/Views/Dietician/DieticianEdit.cshtml")]
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
#line 1 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"928fd4f4d4e3d9899360725941b9466eaf948577", @"/Views/Dietician/DieticianEdit.cshtml")]
    #nullable restore
    public class Views_Dietician_DieticianEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Dietician/DieticianList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
  
    ViewBag.Title = "Dietician";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i> Dietician</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Dietician-Edit</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "928fd4f4d4e3d9899360725941b9466eaf9485774463", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Dietician List\r\n        ");
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
<!-- PAGE-HEADER END -->

<div class=""row"">
    <div class=""col-md"">
        <div class=""card overflow-hidden"">
            <div class=""card-header"">
                <h3 class=""card-title"">Dietician Edit</h3>
            </div>
            <div class=""card-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                   <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Dietician Name</label>
                                <input type=""text"" class=""form-control"" id=""dieticianname"" placeholder=""Dietician Name"" required>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Mobile No</label>
                                <input type=""text"" class=""form-control"" id=""mobileno"" placeholder=""Mobile No"" required>
        ");
            WriteLiteral(@"                    </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Re-Password</label>
                                <input type=""password"" class=""form-control"" id=""repassword"" placeholder=""Re-Password"" required>
                            </div>
                        </div>
                        <div class=""col-md-6"">

                            <div class=""form-group"">
                                <label class=""form-label"">Hospital</label>
                                <Select class=""form-control"" id=""hospitalid"" required></select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">EmployeeId</label>
                                <input type=""text"" class=""form-control"" id=""employeeId"" placeholder=""EmployeeId"" required>
                            </div>
                            <div class=""form-group"">
       ");
            WriteLiteral(@"                         <label class=""form-label"">Password</label>
                                <input type=""password"" class=""form-control"" id=""password"" placeholder=""Password"" required>
                            </div>
                        </div>
                    
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 text-center"">
                            <button type=""button"" id=""btnupdate"" class=""btn btn-radius btn-success"">Update</button>
                        </div>

                    </div>
                </form>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var dieticianMasterId = ");
#nullable restore
#line 81 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                           Write(ViewBag.dieticianMasterId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        loadSingleDietician()\r\n            function loadSingleDietician() {\r\n\r\n          $.ajax({\r\n              type: \"GET\",\r\n              url: \"");
#nullable restore
#line 87 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
               Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Dietician/GetSingleDieticianId/\" + dieticianMasterId,\r\n              contentType: \"application/json; charset=utf-8\",\r\n              headers: {\r\n                  \"authorization\": \"Bearer ");
#nullable restore
#line 90 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                                      Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
              },
              dataType: ""json"",
              success: function (data) {
                  //console.log(data);
                  if (data) {
                      $('#dieticianname').val(data.dieticianName);
                      $('#mobileno').val(data.mobileNo);
                      $('#employeeId').val(data.employeeId);
                      HospitalList(data.hospitalMasterid);
                      $('#password').val(data.password);
                      $('#repassword').val(data.rePassword);
                     // loadParent();
                  }
                  else {
                      sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                  }
              },
              error: function (data) {
                  if (data.status == 401) {
                      window.location.replace('/Message/TokenExpire');
                  } else if (data.status == 403) {
                      window.location.replace('/Message/Unautho");
                WriteLiteral(@"rize');
                  }
              }
          });
        }

        $(""#btnupdate"").click(function (e) {
           if (!document.getElementById(""formPost"").checkValidity()) {
               e.preventDefault();
           } else {
               var model = {
                   dieticianMasterId: dieticianMasterId,
                   dieticianName: $.trim($(""#dieticianname"").val()),
                   mobileNo: $.trim($(""#mobileno"").val()),
                   employeeId: $.trim($(""#employeeId"").val()),
                   hospitalMasterid: parseInt($(""#hospitalid"").val()),
                   password: $.trim($(""#password"").val()),
                   rePassword: $.trim($(""#repassword"").val()),
                   updatedBy:");
#nullable restore
#line 130 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                        Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n               }\r\n               console.log(model)\r\n               $.ajax({\r\n                   type: \"POST\",\r\n                   url: \"");
#nullable restore
#line 135 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                    Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Dietician/UpdateDietician\",\r\n                   data: JSON.stringify(model),\r\n                   contentType: \"application/json; charset=utf-8\",\r\n                   headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 139 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                   },

                   success: function (data, statusText, xhr) {
                       console.log(data)
                       if (xhr.status === 200) {
                           $('#dietician').DataTable().ajax.reload(null, false);
                           sweetAlert({
                               html: true,
                               icon: ""success"",
                               title: ""Dietician"",
                               text: ""Successfully updated!"",
                               type: ""success""
                           });
                       } else if (data.status === ""duplicate"") {
                           sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                       } else if (data.status === ""error"") {
                           sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                       } else {
                           sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""war");
                WriteLiteral(@"ning"");
                       }
                   },
                   error: function (data) {
                       console.log(data);
                       if (data.status == 401) {
                           window.location.replace('/Message/TokenExpire');
                       } else if (data.status == 403) {
                           window.location.replace('/Message/Unauthorize');
                       } else if (data.status == 400) {
                           sweetAlert(""Validation Alert!"", ""Please check input data!"", ""warning"");
                       }
                   }
               });
           }
        });


        
        function HospitalList(Id) {
            var opt = '';
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 181 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                   \"authorization\": \"Bearer ");
#nullable restore
#line 184 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Dietician\DieticianEdit.cshtml"
                                       Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
               success: function (res) {
                    console.log(res)
                    var options = [];
                    options.push('<option value="""">Select Hospital</option>');
                    for (var i = 0; i < res.data.length; i++) {
                        if (Id == res.data[i].hospitalMasterid) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].hospitalMasterid + '"" ' + opt + '>' + res.data[i].hospitalName+ '</option>');
                    }
                    $(""#hospitalid"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                   ");
                WriteLiteral("     window.location.replace(\'/Message/Unauthorize\');\r\n                    }\r\n                }\r\n            });\r\n        }\r\n    </script>\r\n");
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

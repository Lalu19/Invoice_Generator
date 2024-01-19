#pragma checksum "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e1d2a6150dba49f5afff1b015d495ed3c908331"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodProviderLogin_FPLoginEdit), @"mvc.1.0.view", @"/Views/FoodProviderLogin/FPLoginEdit.cshtml")]
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
#line 1 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e1d2a6150dba49f5afff1b015d495ed3c908331", @"/Views/FoodProviderLogin/FPLoginEdit.cshtml")]
    #nullable restore
    public class Views_FoodProviderLogin_FPLoginEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/foodProviderLogin/FPLoginList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
  
    ViewBag.Title = "Food Provider Login";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Food Provider</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Food Provider -EDIT</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e1d2a6150dba49f5afff1b015d495ed3c9083314535", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Food Provider List\r\n        ");
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
                <h3 class=""card-title"">Food Provider Create</h3>
            </div>
            <div class=""card-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Name</label>
                                <input type=""text"" class=""form-control"" id=""name"" placeholder=""Name"">
                            </div>

                            <div class=""form-group"">
                                <label class=""form-label"">Mobile Number</label>
                                <input type=""text"" class=""form-control"" id=""mobileno"" placeholder=""Mobile Number"">
                            </div>
  ");
            WriteLiteral(@"                          <div class=""form-group"">
                                <label class=""form-label"">Re-Password</label>
                                <input type=""password"" class=""form-control"" id=""repassword"" placeholder=""Re-Password"">
                            </div>

                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Hospital</label>
                                <Select class=""form-control"" id=""hospitalid"" required></select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Employee ID</label>
                                <input type=""text"" class=""form-control"" id=""empid"" placeholder=""Employee ID"">
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">");
            WriteLiteral(@"Password</label>
                                <input type=""password"" class=""form-control"" id=""password"" placeholder=""Password"">
                            </div>
                        </div>
                    </div>
                   
                    <div class=""row"">
                        <div class=""col-md-6"">
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
                WriteLiteral("\r\n    <script>\r\n        var foodProviderLoginId = ");
#nullable restore
#line 80 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
                             Write(ViewBag.foodProviderLoginId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        loadSinglefoodProviderLogin()\r\n        function loadSinglefoodProviderLogin() {\r\n          $.ajax({\r\n              type: \"GET\",\r\n              url: \"");
#nullable restore
#line 85 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
               Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/FoodProviderLogin/GetSingleFoodProviderLoginId/\" + foodProviderLoginId,\r\n              contentType: \"application/json; charset=utf-8\",\r\n              headers: {\r\n                  \"authorization\": \"Bearer ");
#nullable restore
#line 88 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
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
                      $('#name').val(data.foodProviderName);
                      HospitalList(data.hospitalMasterid);
                      $('#mobileno').val(data.mobileNo);
                      $('#empid').val(data.empId);
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
                      window.location.replace('/Message/Unauthorize');
     ");
                WriteLiteral(@"             }
              }
          });
        }

        $(""#btnupdate"").click(function (e) {
           if (!document.getElementById(""formPost"").checkValidity()) {
               e.preventDefault();
           } else {
               var model = {
                   foodProviderLoginId: foodProviderLoginId,
                   foodProviderName: $.trim($(""#name"").val()),
                   hospitalMasterid: parseInt($(""#hospitalid"").val()),
                   mobileNo: $.trim($(""#mobileno"").val()),
                   empId: $.trim($(""#empid"").val()),
                   password: $.trim($(""#password"").val()),
                   rePassword: $.trim($(""#repassword"").val()),
                   updatedBy:");
#nullable restore
#line 129 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
                        Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n               }\r\n               console.log(model)\r\n               $.ajax({\r\n                   type: \"POST\",\r\n                   url: \"");
#nullable restore
#line 134 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
                    Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/FoodProviderLogin/UpdateFoodproviderlogin\",\r\n                   data: JSON.stringify(model),\r\n                   contentType: \"application/json; charset=utf-8\",\r\n                   headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 138 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                   },

                   success: function (data, statusText, xhr) {
                       console.log(data)
                       if (xhr.status === 200) {
                           $('#FoodProvider_Tb').DataTable().ajax.reload(null, false);
                           sweetAlert({
                               html: true,
                               icon: ""success"",
                               title: ""Food Provider "",
                               text: ""Successfully updated!"",
                               type: ""success""
                           });
                       } else if (data.status === ""duplicate"") {
                           sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                       } else if (data.status === ""error"") {
                           sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                       } else {
                           sweetAlert(""Validation Alert!"", ""Something unexpec");
                WriteLiteral(@"ted!"", ""warning"");
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
#line 178 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                   \"authorization\": \"Bearer ");
#nullable restore
#line 181 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginEdit.cshtml"
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

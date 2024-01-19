#pragma checksum "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd3d262382fe04089f5b0ed75a9322edef5883ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodProviderLogin_FPLoginCreate), @"mvc.1.0.view", @"/Views/FoodProviderLogin/FPLoginCreate.cshtml")]
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
#line 1 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd3d262382fe04089f5b0ed75a9322edef5883ae", @"/Views/FoodProviderLogin/FPLoginCreate.cshtml")]
    #nullable restore
    public class Views_FoodProviderLogin_FPLoginCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/FoodProviderLogin/FPLoginList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
  
    ViewBag.Title = "Food Provider Login";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Food Provider Create</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Food Provider Create</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd3d262382fe04089f5b0ed75a9322edef5883ae4559", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span>Food Provider List\r\n        ");
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
            WriteLiteral(@"                        <div class=""form-group"">
                                <label class=""form-label"">Re-Password</label>
                                <input type=""password"" class=""form-control"" id=""repassword"" placeholder=""Re-Password"">
                            </div>

                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Hospital</label>
                                <Select class=""form-control"" id=""hospitalid"" disabled></select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Employee ID</label>
                                <input type=""text"" class=""form-control"" id=""empid"" placeholder=""Employee ID"">
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Pa");
            WriteLiteral(@"ssword</label>
                                <input type=""password"" class=""form-control"" id=""password"" placeholder=""Password"">
                            </div>
                        </div>
                    </div>
                   
                    <div class=""row"">
                        <div class=""col-md-12 text-center"">
                            <button type=""button"" id=""btnSave"" class=""btn btn-radius btn-success"">Save</button>
                            <a type=""button"" href=""/FoodProviderLogin/FPLoginCreate"" class=""btn btn-radius btn-danger"">Reset</a>
                        </div>

                    </div>
                </form>
            </div>
        </div>
    </div>
</div>



");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

     <script>

        $(function () {

            $(""#btnSave"").click(function (e) {
                
                if (!document.getElementById(""formPost"").checkValidity()) {
                   e.preventDefault();
                }
                else{
                    var model = {
                        foodProviderName: $.trim($(""#name"").val()),
                        hospitalMasterid: parseInt($(""#hospitalid"").val()),
                        mobileNo: $.trim($(""#mobileno"").val()),
                        empId: $.trim($(""#empid"").val()),
                        password: $.trim($(""#password"").val()),
                        rePassword: $.trim($(""#repassword"").val()),
                        createdBy:");
#nullable restore
#line 100 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
                             Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    //console.log(model)\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 105 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/FoodProviderLogin/CreateFoodProviderLogin"",
                        data: JSON.stringify(model),
                        contentType: ""application/json; charset=utf-8"",
                        headers: {
                                ""authorization"": ""Bearer ");
#nullable restore
#line 109 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
                                                    Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            //console.log(statusText);
                            //console.log(xhr.status);
                            if (xhr.status === 200) {
                                sweetAlert({
                                    html: true,
                                    icon: ""success"",
                                    title: ""Food Provider Login"",
                                    text: ""Successfully created!"",
                                    type: ""success""
                                    });
                            } else if (data.status === ""duplicate"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else if (data.status === ""error"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
        ");
                WriteLiteral(@"                    }else {
                                    sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                                   }
                        },
                        error: function (data) {
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
        });

        GetHospitalList()
        function GetHospitalList(Id) {
            var opt = '';
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 150 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalByUserId/\" + ");
#nullable restore
#line 150 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
                                                              Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                    \"authorization\": \"Bearer ");
#nullable restore
#line 153 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\FoodProviderLogin\FPLoginCreate.cshtml"
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
                    for (var i = 0; i < res.data.length; i++) {
                        if (Id == res.data[i].hospitalMasterid) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].hospitalMasterid + '"" ' + opt + '>' + res.data[i].hospitalName + '</option>');
                    }
                    $(""#hospitalid"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
");
                WriteLiteral("                }\r\n            });\r\n        }\r\n     </script>\r\n ");
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

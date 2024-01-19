#pragma checksum "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0972e5d83b08c5f60168d9157c2080fc2fbade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ChangePassword), @"mvc.1.0.view", @"/Views/User/ChangePassword.cshtml")]
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
#line 1 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0972e5d83b08c5f60168d9157c2080fc2fbade", @"/Views/User/ChangePassword.cshtml")]
    #nullable restore
    public class Views_User_ChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml"
  
    ViewBag.Title = "Settings";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">User Profile</li>
    </ol>
</div>

<div class=""row"">
    <div class=""col-lg-12"">

        <form action=""#"" role=""form"" class=""card validate"" id=""formPost"" enctype=""multipart/form-data"">
            <div class=""card-header"">
                <h3 class=""card-title"">Change Password</h3>
            </div>
            <div class="" card-body"">

                <div class=""row  mb-1"">
                    <div class=""col-lg-6  mb-1"">
                        <input type=""password"" id=""newPassword"" class=""form-control"" autocomplete=""off"" placeholder=""New Password"" required />
                    </div>
                    <div class=""col-lg-6  mb-1"">
                        <input type=""password"" id=""confirmNewPassword"" class=""form-control"" autocomplete=""off"" placehold");
            WriteLiteral(@"er=""Confirm New Password"" required />
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <button type=""button"" id=""btnSave"" class=""btn btn-radius btn-success"">Proceed</button>
                    </div>
                </div>

            </div>
        </form>
    </div>
</div>


");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btnSave"").click(function (e) {
                 if (!document.getElementById(""formPost"").checkValidity()) {
                     e.preventDefault();
                 } else if ($(""#newPassword"").val() != $(""#confirmNewPassword"").val()) {
                     sweetAlert(""Validation Alert!"", ""New Password not matched with Confirm New Password!"", ""warning"");
                 }
                 else {
                    var model = {
                        password: $.trim($(""#confirmNewPassword"").val()),
                        userId:");
#nullable restore
#line 60 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml"
                          Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    $.ajax({\r\n                            type: \"POST\",\r\n                            url: \"");
#nullable restore
#line 64 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml"
                             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/Users/ChangeUserPassword"",
                            data: JSON.stringify(model),
                            contentType: ""application/json; charset=utf-8"",
                            headers: {
                                    ""authorization"": ""Bearer ");
#nullable restore
#line 68 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\User\ChangePassword.cshtml"
                                                        Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                            },
                            dataType: ""json"",
                            success: function (data, statusText, xhr) {
                                if (xhr.status === 200) {
                                    sweetAlert({
                                        html: true,
                                        title: ""User"",
                                        text: ""Successfully changed!"",
                                        type: ""success""
                                    });
                                    resetInput('#formPost');
                                }else {
                                    sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                                }
                            },
                            error: function (data) {
                                if (data.status == 401) {
                                    window.location.replace('/Message/TokenExpire');
      ");
                WriteLiteral(@"                          } else if (data.status == 403) {
                                    window.location.replace('/Message/Unauthorize');
                                } else if (data.status == 400) {
                                    sweetAlert(""Validation Alert!"", ""Please check input data!"", ""warning"");
                                }
                            }
                        });
                    }
            });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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

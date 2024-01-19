#pragma checksum "D:\Invoice\AdminClient\Views\User\RoleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d6621fdb2d53f7f12a8ebd47fc27c21ae912e93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_RoleList), @"mvc.1.0.view", @"/Views/User/RoleList.cshtml")]
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
#line 1 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d6621fdb2d53f7f12a8ebd47fc27c21ae912e93", @"/Views/User/RoleList.cshtml")]
    #nullable restore
    public class Views_User_RoleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
  
    ViewBag.Title = "Role";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-pie-chart mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">User Roles</li>
    </ol>
    <div class=""ml-auto"">
        <a href=""#"" onclick=""showAddBtn()"" data-toggle=""modal"" data-target=""#roleModal"" class=""btn btn-primary btn-icon btn-sm text-white mr-2"">
            <span>
                <i class=""fe fe-plus""></i>
            </span> Create User Role
        </a>
    </div>
</div>

<div class=""col-md-12 col-lg-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-title"">Roles</div>
        </div>
        <div class=""card-body"">

            <div class=""table-responsive"">
                <table id=""roleTable""  class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                    <thead>
                        <tr>
               ");
            WriteLiteral(@"             <th>Name</th>
                            <th>Description</th>
                            <th>Menu Group</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                </table>
            </div>
         
        </div>
    </div>
</div>





<div id=""roleModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">

            </div>
            <div class=""modal-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Role&nbsp;<span style");
            WriteLiteral(@"=""color: red;""><b>*</b></span></label>
                                        <input type=""text"" class=""form-control"" autocomplete=""off"" id=""role"" placeholder=""Role"" required />
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Description&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <input type=""text"" class=""form-control"" autocomplete=""off"" placeholder=""Description"" id=""description"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Menu");
            WriteLiteral(@" Group&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <select id=""menuGrp"" class=""custom-select"" required></select>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <button type=""button"" id=""btnSave"" class=""btn btn-primary"" style=""display:none"">Save</button>
                                    <button type=""button"" id=""btnUpdate"" class=""btn btn-primary"" style=""display:none"">Update</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>");
            WriteLiteral("\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var roleIdForUpdate;

        $(function () {
            loadRoles();

            $('#roleTable tbody').on('click', 'button[data-target=""#roleModal""]', function () {
                var id = $(this).data('id');
                loadSingleRole(id);
                $('#btnUpdate').show();
                $('#btnSave').hide();
                roleIdForUpdate = id;
            });

            $('#roleTable tbody').on('click', 'button[data-target=""#delete""]', function () {
                var id = $(this).data('id');

                swal({
                    html: true,
                    title: ""Are you sure?"",
                    text: ""You will not be able to recover this data!"",
                    type: ""warning"",
                    showCancelButton: true,
                    confirmButtonColor: ""#DD6B55"",
                    confirmButtonText: ""Yes, confirm it!"",
                    closeOnConfirm: false
                }, function () {
                ");
                WriteLiteral("    $.ajax({\r\n                        type: \"GET\",\r\n                        url: \"");
#nullable restore
#line 135 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/DeleteSingleRole/\" + id,\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 138 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status == 200) {
                                $('#roleTable').DataTable().ajax.reload(null, false);
                                sweetAlert({
                                    html: true,
                                    title: ""Role"",
                                    text: ""Successfully deleted!"",
                                    type: ""success""
                                });
                            }else if (xhr.status == 202) {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                            }
                        },
                        error: function (data) {
                            if ");
                WriteLiteral(@"(data.status == 401) {
                                window.location.replace('/Message/TokenExpire');
                            } else if (data.status == 403) {
                                window.location.replace('/Message/Unauthorize');
                            }
                        }
                    });
                });
            });

            $(""#btnSave"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                        var model = {
                            roleName: $.trim($(""#role"").val()),
                            roleDesc: $.trim($(""#description"").val()),
                            menuGroupId: parseInt($(""#menuGrp"").val()),
                            isActive: true,
                            addedBy:");
#nullable restore
#line 176 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                               Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        }\r\n                    //console.log(model);\r\n\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 182 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/CreateUserRole\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 186 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        if (xhr.status === 200) {
                            $('#roleTable').DataTable().ajax.reload(null, false);
                            sweetAlert({
                                html: true,
                                title: ""Role"",
                                text: ""Successfully created!"",
                                type: ""success""
                                });
                        } else if (data.status === ""duplicate"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else if (data.status === ""error"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        }else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                           ");
                WriteLiteral(@" }
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

            $(""#btnUpdate"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                        var model = {
                        userRoleId: roleIdForUpdate,
                        roleName: $.trim($(""#role"").val()),
                        roleDesc: $.trim($(""#description"").val())");
                WriteLiteral(",\r\n                        lastUpdatedBy:");
#nullable restore
#line 227 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                                 Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        menuGroupId: parseInt($(\"#menuGrp\").val())\r\n                    }\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 232 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/UpdateUserRole\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 236 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            //console.log(xhr.status);
                            //console.log(statusText);
                            if (xhr.status==200) {
                                $('#roleTable').DataTable().ajax.reload(null, false);
                                    sweetAlert({
                                        html: true,
                                        title: ""Role"",
                                        text: ""Successfully updated!"",
                                        type: ""success""
                                    });
                            } else if (xhr.status == 202) {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
     ");
                WriteLiteral(@"                       }
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

        function loadSingleRole(id) {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 274 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetSingleRole/\" + id,\r\n                contentType: \"application/json; charset=utf-8\",\r\n                dataType: \"json\",\r\n                headers: {\r\n                    \"authorization\": \"Bearer ");
#nullable restore
#line 278 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                                        Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                success: function (data, statusText, xhr) {
                    console.log(xhr.status);
                    if (xhr.status == 200) {
                        $('#role').val(data.roleName);
                        $('#description').val(data.roleDesc);
                        menuGroupList(data.menuGroupId);
                    }
                    else {
                        sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                    }
                },
                error: function (data) {
                    console.log(data.status);
                    if (data.status == 401) {
                        console.log('un-authorized/token expired');
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        console.log('forbidden/no permission');
                        window.location.replace('/Message/Unauthorize');
           ");
                WriteLiteral(@"         }

                }
            });
        }

        function loadRoles() {
            var table = $('#roleTable').DataTable();
            table.destroy();

            table = $('#roleTable').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'Bfrtip',
                ""buttons"": ['copy', 'csv', 'excel', 'pdf', 'print'],
                ""searching"": false,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 318 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetUserRoleList\',\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 322 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
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
                    { ""data"": ""roleName"", ""orderable"": true },
                    { ""data"": ""roleDesc"", ""orderable"": true },
                    { ""data"": ""menuGroupName"", ""orderable"": true },
                    {
                        ""orderable"": false,
                        ""class"": ""action_button"",
                        ""render"": function (data, type, row) {
                            var id = row.userRoleId;
                            var actionButtonsHtml = """";
                            actionButtonsHtml += generateAction");
                WriteLiteral(@"ButtonForList(id, 'roleModal');
                            return actionButtonsHtml;
                        }
                    }
                ]
            });
        }

        function menuGroupList(id) {
            var opt = '';
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 355 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetMenuGroupList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                   \"authorization\": \"Bearer ");
#nullable restore
#line 358 "D:\Invoice\AdminClient\Views\User\RoleList.cshtml"
                                       Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (res) {

                    var options = [];
                    options.push('<option value="""">Select MenuGroup</option>');
                    for (var i = 0; i < res.data.length; i++) {
                        if (id == res.data[i].menuGroupID) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].menuGroupID + '"" ' + opt + '>' + res.data[i].menuGroupName+ '</option>');
                    }
                    $(""#menuGrp"").html(options.join(''));
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

        function showAddBtn() {
            menuGroupList('');
            $('#btnSave').show();
            $('#btnUpdate').hide();
            resetInput('#roleModal');
        }
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

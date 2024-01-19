#pragma checksum "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0491ada647b0b3a47838119d5ffe14b91ed338f1835d3fd9cb6807de18f8e8c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_UserList), @"mvc.1.0.view", @"/Views/User/UserList.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0491ada647b0b3a47838119d5ffe14b91ed338f1835d3fd9cb6807de18f8e8c2", @"/Views/User/UserList.cshtml")]
    #nullable restore
    public class Views_User_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
  
    ViewBag.Title = "User";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-pie-chart mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Users</li>
    </ol>
    <div class=""ml-auto"">
        <a href=""#"" onclick=""showAddBtn()"" data-toggle=""modal"" data-target=""#userModal"" class=""btn btn-primary btn-icon btn-sm text-white mr-2"">
            <span>
                <i class=""fe fe-plus""></i>
            </span> Create Users
        </a>

    </div>
</div>

<div class=""col-md-12 col-lg-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-title"">Users</div>
        </div>
        <div class=""card-body"">

            <div class=""table-responsive"">
                <table id=""userTable""  class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                    <thead>
                        <tr>
                        ");
            WriteLiteral(@"    <th>Photo</th>
                            <th>Name</th>
                            <th>Role</th>
                            <th>Mobile</th>
                            <th>Email</th>
                            <th>DOB</th>
                            <th>User Name</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                </table>
            </div>
  
        </div>
    </div>
</div>

<div id=""userModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">

            </div>
            <div class=""modal-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"" enctype=""multipart/form-data"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""row"">
                                <di");
            WriteLiteral(@"v class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Name&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <input type=""text"" class=""form-control"" id=""name"" autocomplete=""off"" placeholder=""Name"" required />
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Mobile&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <input type=""text"" class=""form-control"" id=""mobile"" autocomplete=""off"" placeholder=""Mobile"" required/>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                         ");
            WriteLiteral(@"       <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Email&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <input type=""email"" class=""form-control"" id=""email"" autocomplete=""off"" placeholder=""Email"" required/>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">User name&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <input type=""text"" class=""form-control"" id=""username"" autocomplete=""off"" placeholder=""User name"" required />
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
   ");
            WriteLiteral(@"                             <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Password&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <input type=""password"" class=""form-control"" id=""password"" autocomplete=""off"" placeholder=""Password"" required />
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Role&nbsp;<span style=""color: red;""><b>*</b></span></label>
                                        <select id=""role"" class=""custom-select"" required></select>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                       ");
            WriteLiteral(@"         <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Date of Birth</label>
                                        <div class=""input-group mb-2"">
                                            <div class=""input-group-prepend"">
                                                <div class=""input-group-text""><i class=""fas fa-calendar-alt""></i></div>
                                            </div>
                                            <input type=""text"" class=""form-control datepicker"" id=""dob"" autocomplete=""off"">
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Profile picture&nbsp;<span style=""color: red;""><b>*</b></span></label");
            WriteLiteral(@">
                                        <div class=""custom-file mt-0"">
                                            <input type=""file"" class=""custom-file-input"" id=""pp"" name=""pp"" required>
                                            <label class=""custom-file-label"" for=""proPic"">Choose file</label>
                                        </div>
                                    </div>
                                </div>
                               
                                <div class=""col-lg-2"">
                                    <div class=""text-center"">
                                        <img id=""profilePic""");
            BeginWriteAttribute("src", " src=\"", 7017, "\"", 7023, 0);
            EndWriteAttribute();
            WriteLiteral(@" width=""90"" class=""rounded-circle"" />
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <button type=""button"" id=""btnSave"" class=""btn btn-radius btn-success"" onclick=""ValidateTextBox()"" style=""display:none"">Save</button>
                                    <button type=""button"" id=""btnUpdate"" class=""btn btn-radius btn-success"" style=""display:none"">Update</button>
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
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        var userIdForUpdate;
        var imgPath;

        $("".custom-file-input"").on(""change"", function () {
            var fileName = $(this).val().split(""\\"").pop();
            if (checkImageFormat(fileName)) {
                $(this).siblings("".custom-file-label"").addClass(""selected"").html(fileName);
            } else {
                sweetAlert(""Validation Alert!"", ""Upload Image file only!"", ""warning"");
                resetInputFile('#userModal');
            }
        });

        $(function () {
            loadUsers();

            $('#userTable tbody').on('click', 'button[data-target=""#userModal""]', function () {
                var id = $(this).data('id');
                loadSingleUser(id);
                $('#btnUpdate').show();
                $('#btnSave').hide();
                userIdForUpdate = id;
            });

            $('#userTable tbody').on('click', 'button[data-target=""#delete""]', function () {
                var id = $(this).data('");
                WriteLiteral(@"id');

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
                    $.ajax({
                        type: ""GET"",
                        url: """);
#nullable restore
#line 195 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/DeleteSingleUser/\" + id,\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 198 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status == 200) {
                                $('#userTable').DataTable().ajax.reload(null, false);
                                sweetAlert({
                                    html: true,
                                    title: ""User"",
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
                            if");
                WriteLiteral(@" (data.status == 401) {
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
                    imgPath = '';
                    var Image = document.getElementById('pp').files.length;
                    if (Image > 0) {
                        uploadphoto();
                    }

                    var model = {
                        userRoleId: parseInt($(""#role"").val()),
                        fullName: $.trim($(""#name"").val()),
                        mobile: $.trim($(""#mobile"").val()),
                     ");
                WriteLiteral(@"   email: $.trim($(""#email"").val()),
                        dateOfBirth: $.trim($(""#dob"").val()) == '' ? null : $.trim($(""#dob"").val().replace(/\//g, '-')),
                        imagePath: imgPath,
                        userName: $.trim($(""#username"").val()),
                        password: $.trim($(""#password"").val()),
                        addedBy:");
#nullable restore
#line 246 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                           Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    //console.log(model);\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 251 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/CreateUser\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 255 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        //console.log(xhr.status);
                        //console.log(data);
                        if (xhr.status === 200) {
                            $('#userTable').DataTable().ajax.reload(null, false);
                            sweetAlert({
                                html: true,
                                title: ""User"",
                                text: ""Successfully created!"",
                                type: ""success""
                                });
                        } else if (data.status === ""duplicate"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else if (data.status === ""error"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        }else {
                               ");
                WriteLiteral(@" sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
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

            $(""#btnUpdate"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                    imgPath = '';
                    var currentImageSrc = '';
                    currentImageSrc = $");
                WriteLiteral(@"('#profilePic').attr('src');

                    if ($('.custom-file-label').text() != '' && $('.custom-file-label').text() !='Choose file') {
                        uploadphoto();
                    } else if (currentImageSrc!='') {
                        imgPath = currentImageSrc;
                    }
                    var model = {
                        userId: userIdForUpdate,
                        userRoleId: parseInt($(""#role"").val()),
                        fullName: $.trim($(""#name"").val()),
                        mobile: $.trim($(""#mobile"").val()),
                        email: $.trim($(""#email"").val()),
                        dateOfBirth: $.trim($(""#dob"").val()) == '' ? null : $.trim($(""#dob"").val().replace(/\//g, '-')),
                        imagePath: imgPath,
                        userName: $.trim($(""#username"").val()),
                        password: $.trim($(""#password"").val()),
                        hospitalMasterid: parseInt($(""#hopital"").val()),
     ");
                WriteLiteral("                   lastUpdatedBy:");
#nullable restore
#line 314 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                 Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    //console.log(model);\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 319 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/UpdateUser\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 323 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status==200) {
                                $('#userTable').DataTable().ajax.reload(null, false);
                                    sweetAlert({
                                        html: true,
                                        title: ""User"",
                                        text: ""Successfully updated!"",
                                        type: ""success""
                                    });
                            } else if (xhr.status == 202) {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                            }
                        },
                        error: function (data) {
        ");
                WriteLiteral(@"                    if (data.status == 401) {
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

        function loadSingleUser(id) {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 359 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetSingleUser/\" + id,\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 362 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (data) {
                    if (data) {
                        $('#name').val(data.fullName);
                        $('#mobile').val(data.mobile);
                        $('#email').val(data.email);
                        $('#username').val(data.userName);
                        $('#password').val(data.password);
                        if (data.dateOfBirth != null) {
                            var dateVal = data.dateOfBirth.substring(0, 10);
                            $('#dob').datepicker('setDate', new Date(dateVal.replace(/\-/g, '/')));
                        } else {
                            $('#dob').val('');
                        }
                        roleList(data.userRoleId);
                        $('#profilePic').attr('src', data.imagePath);
                        GetHospitalName(data.hospitalMasterid);
                    } else {
                        sweetAlert(""Vali");
                WriteLiteral(@"dation Alert!"", ""Something unexpected!"", ""warning"");
                    }
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }

        function loadUsers() {
            var table = $('#userTable').DataTable();
            table.destroy();

            table = $('#userTable').dataTable({
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
#line 408 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetUserList\',\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 412 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
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
                            if (row.imagePath === '')
                                return '';
                            else
                                return '<img style=""margin-left: 28px;"" class=""avatar avatar-md rounded-circle"" src=""' + row.imagePath + '""/>'
                        }
                    },
                    { ""data"": ""fullName"", ""orderable"": true },
                    { ""data"": ""roleName"", ""orderable"": true },
           ");
                WriteLiteral(@"         { ""data"": ""mobile"", ""orderable"": true },
                    { ""data"": ""email"", ""orderable"": true },
                    {
                        ""data"": ""dateOfBirth"",
                        ""orderable"": true,
                        ""render"": function (data, type, row) {
                            return row.dateOfBirth != null ? row.dateOfBirth.substring(0, 10) : '';
                        }
                    },
                    { ""data"": ""userName"", ""orderable"": true },
                    {
                        ""orderable"": false,
                        ""class"": ""action_button"",
                        ""render"": function (data, type, row) {
                            var id = row.userId;
                            var actionButtonsHtml = """";
                            actionButtonsHtml += generateActionButtonForList(id,'userModal');
                            return actionButtonsHtml;
                        }
                    }
                ]
        ");
                WriteLiteral("    });\r\n        }\r\n\r\n        function roleList(id) {\r\n            var opt = \'\';\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: \"");
#nullable restore
#line 462 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetUserRoleList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 465 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (res) {
                    //console.log(res.data[0].roleName);
                    //console.log(res.data.length);
                    var options = [];
                    options.push('<option value="""">Select Role</option>');
                    for (var i = 0; i < res.data.length; i++) {
                        if (id == res.data[i].userRoleId) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].userRoleId + '"" ' + opt + '>' + res.data[i].roleName+ '</option>');
                    }
                    $(""#role"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } els");
                WriteLiteral(@"e if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }

        GetHospitalName()
        function GetHospitalName(id) {
            var opt = '';
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 498 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 501 "D:\New Proj\EOrderBook\AdminClient\Views\User\UserList.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (res) {
                    var options = [];
                    options.push('<option value="""">Select Hospital</option>');
                    for (var i = 0; i < res.data.length; i++) {
                        if (id == res.data[i].hospitalMasterid) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].hospitalMasterid + '"" ' + opt + '>' + res.data[i].hospitalName + '</option>');
                    }
                    $(""#hopital"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/");
                WriteLiteral(@"Unauthorize');
                    }
                }
            });
        }

        function showAddBtn() {
            roleList('');
            $('#btnSave').show();
            $('#btnUpdate').hide();
            resetInput('#userModal');
            resetInputFile('#userModal');
        }

        function uploadphoto() {
           var totalFiles = document.getElementById('pp').files.length;
           if (totalFiles > 0) {
               var formData = new FormData();
               var files = document.getElementById('pp').files;
               formData.append(""file"", files[0]);
               $.ajax(
                   {
                       url: ""/Upload/ImgUpload"",
                       data: formData,
                       processData: false,
                       contentType: false,
                       async: false,
                       type: ""POST"",
                       success: function (data) {
                           imgPath = data;
          ");
                WriteLiteral(@"                 $('#profilePic').attr('src', imgPath);
                            resetInputFile('#userModal');
                       },
                       error: function (data) {
                           window.location.replace('/Message/SessionExpire');
                       }
                   }
               );
           }
        }  
    </script>
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#mobile"").change(function () {
                var inputvalues = $(this).val();
                var gstinformat = new RegExp('^[0-9]{10}$');
                if (gstinformat.test(inputvalues)) {
                    return true;
                } else {
                    alert('Please Enter Valid Mobile No');
                    $(""#mobile"").val;
                    $(""#mobile"").focus();
                }
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

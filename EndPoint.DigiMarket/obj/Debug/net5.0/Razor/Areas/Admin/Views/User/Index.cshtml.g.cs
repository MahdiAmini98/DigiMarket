#pragma checksum "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7ca0bc09807aa792f3861cbc00d7930461f992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
using DigiMarket.Common.Convertor;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7ca0bc09807aa792f3861cbc00d7930461f992", @"/Areas/Admin/Views/User/Index.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigiMarket.Application.Services.Users.Queries.GetUsers.ResualtGetUserDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "لیست کاربران";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
            WriteLiteral(@"<!-- Zero configuration table -->
<section id=""configuration"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title-wrap bar-success"">
                        <h4 class=""card-title"">لیست کاربران</h4>
                    </div>
                </div>
                <div class=""card-body collapse show"">
                    <div class=""card-block card-dashboard"">
                        <p class=""card-text"">لیست کاربران مورد نظر سایت جهت تغییرات</p>



                        <div id=""DataTables_Table_0_wrapper"" class=""dataTables_wrapper container-fluid dt-bootstrap4"">
                            <div class=""row"">

                                <div class=""col-sm-12 col-md-6"">
                                    <div class=""dataTables_length"" id=""DataTables_Table_0_length""><label>نمایش 
                                            <select name=""DataTables_Table_0_length"" aria-c");
            WriteLiteral(@"ontrols=""DataTables_Table_0"" class=""form-control form-control-sm"">
                                                <option value=""10"">10</option><option value=""25"">25</option>
                                                <option value=""50"">50</option>
                                                 <option value=""100"">100</option>
                                            </select> سطر</label>
                                        </div>
                                    </div>
                                <div class=""col-sm-12 col-md-6"">
                                    <form method=""get"" class=""col-xl-4 col-lg-6 col-md-12 mb-1"">
                                        <fieldset class=""form-group"">
                                            <input type=""text"" class=""form-control"" name=""serchkey"">
                                            <button class=""btn btn-success my-2"">جستجو</button>
                                        </fieldset>
                                    <");
            WriteLiteral(@"/form>
                                    </div>
                            </div><div class=""row"">
                                <div class=""col-sm-12"">
                                    <table class=""table table-striped table-bordered zero-configuration dataTable"" id=""DataTables_Table_0"" role=""grid"" aria-describedby=""DataTables_Table_0_info"">
                                        <thead>
                                            <tr role=""row"">
                                                <th class=""sorting_asc"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 154.417px;"" aria-sort=""ascending"" aria-label=""نام: activate to sort column descending"">نام</th>
                                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 287.183px;"" aria-label=""ایمیل: activate to sort column ascending"">ایمیل</th>
                                                <th class=""sorting"" t");
            WriteLiteral(@"abindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 106.133px;"" aria-label=""تاریخ عضویت: activate to sort column ascending"">تاریخ عضویت</th>
                                                <th class=""sorting"" tabindex=""0"" aria-controls=""DataTables_Table_0"" rowspan=""1"" colspan=""1"" style=""width: 106.133px;"" aria-label=""تغییرات: activate to sort column ascending"">تغییرات</th>

                                            </tr>
                                        </thead>
                                        <tbody>




");
#nullable restore
#line 74 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
                                             foreach (var item in Model.Users)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr role=\"row\" class=\"odd\">\r\n                                                    <td class=\"sorting_1\">");
#nullable restore
#line 77 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
                                                                     Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                    <td class=\"sorting_1\">");
#nullable restore
#line 79 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
                                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"sorting_1\">");
#nullable restore
#line 80 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
                                                                     Write(item.CrateDateTime.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    <td class=\"sorting_1\">\r\n                                                        <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4740, "\"", 4816, 9);
            WriteAttributeValue("", 4750, "ShowModalEdituser(\'", 4750, 19, true);
#nullable restore
#line 82 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4769, item.UserId, 4769, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4781, "\'", 4781, 1, true);
            WriteAttributeValue(" ", 4782, ",", 4783, 2, true);
            WriteAttributeValue(" ", 4784, "\'", 4785, 2, true);
#nullable restore
#line 82 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4786, item.FullName, 4786, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4800, "\',\'", 4800, 3, true);
#nullable restore
#line 82 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4803, item.Email, 4803, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4814, "\')", 4814, 2, true);
            EndWriteAttribute();
            WriteLiteral(">ویرایش</button>\r\n                                                        <button class=\"btn btn-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4921, "\"", 4957, 3);
            WriteAttributeValue("", 4931, "DeleteUser(\'", 4931, 12, true);
#nullable restore
#line 83 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 4943, item.UserId, 4943, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4955, "\')", 4955, 2, true);
            EndWriteAttribute();
            WriteLiteral(">حذف</button>\r\n");
#nullable restore
#line 84 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
                                                         if (item.IsActive)
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <button class=\"btn btn-warning\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5200, "\"", 5241, 3);
            WriteAttributeValue("", 5210, "UserSatusChange(\'", 5210, 17, true);
#nullable restore
#line 86 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5227, item.UserId, 5227, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5239, "\')", 5239, 2, true);
            EndWriteAttribute();
            WriteLiteral("> غیر فعال</button>\r\n");
#nullable restore
#line 87 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"

                                                        }
                                                        else
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <button class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5533, "\"", 5574, 3);
            WriteAttributeValue("", 5543, "UserSatusChange(\'", 5543, 17, true);
#nullable restore
#line 91 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 5560, item.UserId, 5560, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5572, "\')", 5572, 2, true);
            EndWriteAttribute();
            WriteLiteral("> فعال</button>\r\n");
#nullable restore
#line 92 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"

                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Areas\Admin\Views\User\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                        </tbody>\r\n");
            WriteLiteral(@"                                    </table>
                                </div>
                            </div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""DataTables_Table_0_info"" role=""status"" aria-live=""polite"">نمایش 1 تا 10 از 57 سطرها</div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""DataTables_Table_0_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""DataTables_Table_0_previous""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">قبلی</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-id");
            WriteLiteral(@"x=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""DataTables_Table_0_next""><a href=""#"" aria-controls=""DataTables_Table_0"" data-dt-idx=""7"" tabindex=""0"" class=""page-link"">بعدی</a></li></ul></div></div></div>
                        </div>


                    </div>
                </div>
            </div>
        </div>
    </div>
</section>



");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8c7ca0bc09807aa792f3861cbc00d7930461f99217176", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7ca0bc09807aa792f3861cbc00d7930461f99218355", async() => {
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
                WriteLiteral(@"

    <script>


        function DeleteUser(UserId) {
            swal.fire({
                title: 'حذف کاربر',
                text: ""کاربر گرامی از حذف کاربر مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'بله ، کاربر حذف شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {
                    var postData = {
                        'UserId': UserId,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""DeleteUser"",
                        data: postData,
                        success: function (data) {
                            if (data.isSuccess == true) {
        ");
                WriteLiteral(@"                        swal.fire(
                                    'موفق!',
                                    data.message,
                                    'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });
                            }
                            else {

                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );

                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }

                    });

                }
            })
        }


        function UserSatusChange(UserId) {
            swal.fire({
                title: 'تغییر وض");
                WriteLiteral(@"عیت کاربر',
                text: ""کاربر گرامی از تغییر وضعیت کاربر مطمئن هستید؟"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#7cacbe',
                confirmButtonText: 'بله ، تغییر وضعیت انجام شود',
                cancelButtonText: 'خیر'
            }).then((result) => {
                if (result.value) {

                    var postData = {
                        'UserId': UserId,
                    };

                    $.ajax({
                        contentType: 'application/x-www-form-urlencoded',
                        dataType: 'json',
                        type: ""POST"",
                        url: ""UserSatusChange"",
                        data: postData,
                        success: function (data) {
                            if (data.isSuccess == true) {
                                swal.fire(
                                    'موفق!',
     ");
                WriteLiteral(@"                               data.message,
                                    'success'
                                ).then(function (isConfirm) {
                                    location.reload();
                                });
                            }
                            else {

                                swal.fire(
                                    'هشدار!',
                                    data.message,
                                    'warning'
                                );

                            }
                        },
                        error: function (request, status, error) {
                            alert(request.responseText);
                        }

                    });

                }
            })
        }


        function Edituser() {

            var userId = $(""#Edit_UserId"").val();
            var fullName = $(""#Edit_Fullname"").val();
            var email = $(""#Edit_Email"").val();
");
                WriteLiteral(@"            
            var postData = {
                'UserId': userId,
                'FullName': fullName,
                'Email':email,
            };


            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: ""POST"",
                url: ""Edit"",
                data: postData,
                success: function (data) {
                    if (data.isSuccess == true) {
                        swal.fire(
                            'موفق!',
                            data.message,
                            'success'
                        ).then(function (isConfirm) {
                            location.reload();
                        });
                    }
                    else {
                        swal.fire(
                            'هشدار!',
                            data.message,
                            'warning'
                        );
                 ");
                WriteLiteral(@"   }
                },
                error: function (request, status, error) {
                    alert(request.responseText);
                }
            });

            $('#EditUser').modal('hide');

        }


        function ShowModalEdituser(UserId, fullName,email) {
            $('#Edit_Fullname').val(fullName);
            $('#Edit_UserId').val(UserId);
            $('#Edit_Email').val(email);

            $('#EditUser').modal('show');

        }
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
            DefineSection("Modals", async() => {
                WriteLiteral(@"
    <!-- Modal Edit User -->
    <div class=""modal fade"" id=""EditUser"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">ویرایش کاربر</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""col-xl-12 col-lg-12 col-md-12 mb-1"">
                        <fieldset class=""form-group"">
                            <input type=""hidden"" id=""Edit_UserId"" />
                            <label for=""basicInput"">نام و نام خانوادگی</label>
                            <input type=""text"" class=""form-control"" id=""Edi");
                WriteLiteral(@"t_Fullname"">
                            <label for=""basicInput"">نام ایمیل</label>
                            <input type=""email"" class=""form-control"" id=""Edit_Email"">
                        </fieldset>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <a class=""btn btn-secondary"" data-dismiss=""modal"">بستن</a>
                    <a class=""btn btn-primary"" onclick=""Edituser()"">اعمال تغییرات</a>
                </div>
            </div>
        </div>
    </div>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMarket.Application.Services.Users.Queries.GetUsers.ResualtGetUserDto> Html { get; private set; }
    }
}
#pragma warning restore 1591

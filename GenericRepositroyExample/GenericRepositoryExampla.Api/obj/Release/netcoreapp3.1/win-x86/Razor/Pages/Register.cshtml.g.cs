#pragma checksum "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97c60ca485cda1256c744e21697a80dd340f2be5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GenericRepositoryExampla.Api.Pages.Pages_Register), @"mvc.1.0.razor-page", @"/Pages/Register.cshtml")]
namespace GenericRepositoryExampla.Api.Pages
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
#line 1 "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\_ViewImports.cshtml"
using GenericRepositoryExampla.Api;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97c60ca485cda1256c744e21697a80dd340f2be5", @"/Pages/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e69b86c825aa7481aa1ddf9fde830c2b4958ab", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("quickForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition register-page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\Register.cshtml"
  

    ViewData["Title"] = "Title";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c60ca485cda1256c744e21697a80dd340f2be54401", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>AdminLTE 3 | Registration Page</title>

    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""../../plugins/fontawesome-free/css/all.min.css"">
    <!-- icheck bootstrap -->
    <link rel=""stylesheet"" href=""../../plugins/icheck-bootstrap/icheck-bootstrap.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""../../dist/css/adminlte.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c60ca485cda1256c744e21697a80dd340f2be56039", async() => {
                WriteLiteral(@"
    <div class=""register-box"">
        <div class=""register-logo"">
            <a href=""../../index2.html""><b>Admin</b>LTE</a>
        </div>

        <div class=""card"">
            <div class=""card-body register-card-body"">
                <p class=""login-box-msg"">Register a new membership</p>

                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97c60ca485cda1256c744e21697a80dd340f2be56630", async() => {
                    WriteLiteral(@"
                    <div class=""card-body"">

                        <div class=""form-group"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text"">
                                    <input type=""text"" name=""fullname"" class=""form-control"" id=""exampleInputFullname1"" placeholder=""Full name"">
                                    <span class=""fas fa-user""></span>
                                </div>
                            </div>
                        </div>


                        <div class=""form-group"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text"">
                                    <input type=""email"" name=""email"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""Enter email"">
                                    <span class=""fas fa-envelope""></span>
                                </div>
                            </div>
  ");
                    WriteLiteral(@"                      </div>

                        <div class=""form-group"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text"">
                                    <input type=""password"" name=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Password"">
                                    <span class=""fas fa-lock""></span>
                                </div>
                            </div>
                        </div>

                        <div class=""form-group"">
                            <div class=""input-group-append"">
                                <div class=""input-group-text"">
                                    <input type=""password"" name=""password"" class=""form-control"" id=""exampleInputRetypepassword1"" placeholder=""Retype password"">
                                    <span class=""fas fa-lock""></span>
                                </div>
                            </div>
   ");
                    WriteLiteral(@"                     </div>

                        <div class=""row"">
                            <div class=""col-8"">
                                <div class=""icheck-primary"">
                                    <input type=""checkbox"" id=""agreeTerms"" name=""terms"" value=""agree"">
                                    <label for=""agreeTerms"">
                                        I agree to the <a href=""#"">terms</a>
                                    </label>
                                </div>
                            </div>
                            <!-- /.col -->
                            <div class=""col-4"">
                                <button type=""submit"" class=""btn btn-primary"" id=""register"">Register</button>
                            </div>
                            <!-- /.col -->
                        </div>

                    </div>
                    <!-- /.card-body -->

                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                <div class=""social-auth-links text-center"">
                    <p>- OR -</p>
                    <a href=""#"" class=""btn btn-block btn-primary"">
                        <i class=""fab fa-facebook mr-2""></i>
                        Sign up using Facebook
                    </a>
                    <a href=""#"" class=""btn btn-block btn-danger"">
                        <i class=""fab fa-google-plus mr-2""></i>
                        Sign up using Google+
                    </a>
                </div>

                <a href=""login.html"" class=""text-center"">I already have a membership</a>
            </div>
            <!-- /.form-box -->
        </div><!-- /.card -->
    </div>
    <!-- /.register-box -->
    <!-- jQuery -->
    <!-- AdminLTE App -->
    <script src=""../../plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- jquery-validation -->
    <script src=""../../plu");
                WriteLiteral(@"gins/jquery-validation/jquery.validate.min.js""></script>

    <!-- jquery-validation -->
    <!--<script type=""text/javascript"" charset=""windows-1252"" src=""../../plugins/jquery-validation/jquery.validate.min.js""></script>
    <script type=""text/javascript"" charset=""windows-1252"" src=""../../plugins/jquery-validation/additional-methods.min.js""></script>-->
    <!-- AdminLTE App -->
    <!--<script src=""../../dist/js/adminlte.min.js""></script>-->
    <!-- AdminLTE for demo purposes -->
");
                WriteLiteral(@"    <script>
        $(function () {
            $.validator.setDefaults({
                submitHandler: function () {
                    alert(""Form successful submitted!"");
                }
            });
            $('#quickForm').validate({
                rules: {
                    fullname: {
                        required: true,
                        maxlength: 20,
                    },
                    email: {
                        required: true,
                        email: true,
                    },
                    password: {
                        required: true,
                        minlength: 5
                    },
                    terms: {
                        required: true
                    },
                },
                messages: {
                    Fullname: {
                        required: ""Please provide a password"",
                        minlength: ""Your full name must be no longer than 20 characters""
   ");
                WriteLiteral(@"                 },
                    Email: {
                        required: ""Please enter a email address"",
                        email: ""Please enter a valid email address""
                    },
                    Password: {
                        required: ""Please provide a password"",
                        minlength: ""Your password must be at least 5 characters long""
                    },
                    terms: ""Please accept our terms""
                },
                errorElement: 'span',
                errorPlacement: function (error, element) {
                    error.addClass('invalid-feedback');
                    element.closest('.form-group').append(error);
                },
                highlight: function (element, errorClass, validClass) {
                    $(element).addClass('is-invalid');
                },
                unhighlight: function (element, errorClass, validClass) {
                    $(element).removeClass('is-invalid');
    ");
                WriteLiteral(@"            }
            });
        });
    </script>
    <script type=""text/javascript"">


        $(""#register"").click(function () {
            debugger;
        
            var model = {
                nameSurname: $(""[name='fullname']"").val(),
                email: $(""[name='email']"").val(),
                password: $(""[name='password']"").val(),
                isActive: false
            };
            console.log(JSON.stringify(model));
            var user = JSON.stringify(model);
            $.ajax({
                type: 'POST',
                url: 'https://localhost:44303/api/login/create',
                contentType: 'application/json;charset=utf-8',
                dataType: 'json',
                data: user,
                success: function (gelenveri) {
                    $(""register"").removeAttr(""disabled"");
                    alert(""Kayıt işlemeniz başarılı"")
                },
                error: function (hata) {
                    $(""register"").");
                WriteLiteral("removeAttr(\"disabled\");\r\n                }\r\n            });\r\n        });\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericRepositoryExampla.Api.Pages.RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.RegisterModel>)PageContext?.ViewData;
        public GenericRepositoryExampla.Api.Pages.RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

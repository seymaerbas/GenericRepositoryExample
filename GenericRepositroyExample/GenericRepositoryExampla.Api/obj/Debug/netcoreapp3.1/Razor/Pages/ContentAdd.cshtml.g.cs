#pragma checksum "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\ContentAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7552ebb13e7dc98194d6fc6af7647057ab67c1dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GenericRepositoryExampla.Api.Pages.Pages_ContentAdd), @"mvc.1.0.razor-page", @"/Pages/ContentAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7552ebb13e7dc98194d6fc6af7647057ab67c1dd", @"/Pages/ContentAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e69b86c825aa7481aa1ddf9fde830c2b4958ab", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ContentAdd : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ContentAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\ContentAdd.cshtml"
  
    ViewData["Title"] = "Title";
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7552ebb13e7dc98194d6fc6af7647057ab67c1dd4415", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>AdminLTE 3 | Project Add</title>

<link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
<link rel=""stylesheet"" href=""../../plugins/fontawesome-free/css/all.min.css"">

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7552ebb13e7dc98194d6fc6af7647057ab67c1dd5814", async() => {
                WriteLiteral(@"

<div class=""wrapper"">

<div class=""content-wrapper"">

<section class=""content"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title""> Add Content</h3>

                </div>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7552ebb13e7dc98194d6fc6af7647057ab67c1dd6421", async() => {
                    WriteLiteral(@"
                    <div class=""card-body"">
                         <div class=""input-group-append"">

                            <label>Title</label>
                            <input type=""text"" name=""title"" class=""form-control"" id=""exampleInputTitle1"">
                        </div>

                    <div class=""form-group"">
                        <div class=""input-group-append"">

                            <label>Description</label>
                            <input type=""text"" name=""description"" class=""form-control"" id=""exampleInputDescription1"">
                        </div>
                    </div>
                    <div class=""form-group"">
                        <div class=""input-group-append"">

                            <label>Detail</label>
                            <input type=""text"" name=""detail"" class=""form-control"" id=""exampleInputDetail1"">
                        </div>
                    </div>
                        <div class=""form-group"">
        ");
                    WriteLiteral(@"                <div class=""input-group-append"">

                            <label>category_Id</label>
                            <input type=""number"" name=""category_Id"" class=""form-control"" id=""exampleInputCategoryId1"">
                        </div>
                    </div>

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
                    </div>
 /.card-body 
</div>
 /.card 
</div>

    </div>
    <div class=""row"">
        <div class=""col-12"">
            <a href=""window.location.href = "" Contents"" class=""btn btn-secondary"">Cancel</a>
            <button id=""AddContent"" type=""submit"" class=""btn btn-primary"">Content Ekle</button>
        </div>
    </div>
</section>

</div>
    
<aside class=""control-sidebar control-sidebar-dark"">

</aside>

</div>

<script src=""../../plugins/jquery/jquery.min.js""></script>
 Bootstrap 4 
<script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>

<script src=""../../plugins/jquery-validation/jquery.validate.min.js""></script>
");
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
            WriteLiteral(@"
</html>
<script>
    $(function () {
        $.validator.setDefaults({
            submitHandler: function () {
                alert(""Form successful submitted!"");
            }
        });
        $('#CategoryAdd').validate({
            rules: {

                title: {
                    required: true,
                    maxlength: 20
                },
                description: {
                    required: true,
                    minlength: 5
                },
                detail: {
                    required: true,
                    minlength: 10
                },
            },
            messages: {

                Title: {
                    required: ""Please enter a title"",
                    maxlength: ""Your title must be no longer than 15 characters""
                },
                Description: {
                    required: ""Please provide a password"",
                    maxlength: ""Your password must be at least 30 characters long""");
            WriteLiteral(@"
                },
                Detail: {
                    required: ""Please provide a password"",
                    maxlength: ""Your password must be at least 30 characters long""
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
            }
        });
    });
</script>

<script type=""text/javascript"">
    $(""#AddContent"").click(function () {
        debugger;
        var model = {
            Title: $(""[name='title']"").val(),
            Description: $(""[name='descriptio");
            WriteLiteral(@"n']"").val(),
            Detail: $(""[name='detail']"").val(),
     category_Id: $(""[name='category_Id']"").val(),
        };
        console.log(JSON.stringify(model));
        var content = JSON.stringify(model);
        $.ajax({
            type: 'POST',
            url: 'https://localhost:44303/api/content/create',
            contentType: 'application/json;charset=utf-8',
            dataType: 'json',
            data: content,
            success: function (gelenveri) {
                $(""AddContent"").removeAttr(""disabled"");
                alert(""Kayıt işlemeniz başarılı"")
            },
            error: function (hata) {
                $(""AddContent"").removeAttr(""disabled"");
            }
        });
    });

</script>



<!--<div class=""card-header"">
    <h3 class=""card-title"">Content Add</h3>

    <div class=""card-tools"">
        <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
            <i class=""fas fa-minus""></i>
        </");
            WriteLiteral(@"button>
    </div>
</div>
<!-- Main content -->
<!--<section class=""content"">

    <div class=""card"">

        <h4 class=""card-title"">Add Category</h4>
    </div>

    <div class=""card-body"">

        <div class=""card mb-4"">

            <div class=""card-body"">
                <form id=""ContentAdd"">
                    <div class=""form-group"">
                        <div class=""input-group-append"">

                            <label>Title</label>
                            <input type=""text"" name=""title"" class=""form-control"" id=""exampleInputTitle1"">
                        </div>

                        <div class=""form-group"">
                            <div class=""input-group-append"">

                                <label>Description</label>
                                <input type=""text"" name=""description"" class=""form-control"" id=""exampleInputDescription1"">
                            </div>
                        </div>
                        <div class=""form-gro");
            WriteLiteral(@"up"">
                            <div class=""input-group-append"">

                                <label>Detail</label>
                                <input type="""" name=""Detail"" class=""form-control"" id=""exampleInputDetail1"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <div class=""input-group-append"">

                                <label>category_Id</label>
                                <input type=""number"" name=""category_Id"" class=""form-control"" id=""exampleInputCategoryId1"">
                            </div>
                        </div>

                        <div class=""row"">-->

                            <!-- /.col -->
                            <!--<div class=""col-4"">
                                <button type=""submit"" name=""AddContent"" class=""btn btn-primary"" id=""AddContent"">Add Content</button>
                            </div>-->


                            <!--");
            WriteLiteral(@" /.col -->
                        <!--</div>


                </form>
            </div>
        </div>
    </div>


    <script src=""../../plugins/jquery/jquery.min.js""></script>-->
    <!-- Bootstrap 4 -->
    <!--<script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>-->
    <!-- jquery-validation -->
    <!--<script src=""../../plugins/jquery-validation/jquery.validate.min.js""></script>


</section>--><!-- /.content -->
<!--<script>
    $(function () {
        $.validator.setDefaults({
            submitHandler: function () {
                alert(""Form successful submitted!"");
            }
        });
        $('#ContentAdd').validate({
            rules: {

                title: {
                    required: true,
                    maxlength: 20
                },

                description: {
                    required: true,
                    minlength: 5
                },
                detail: {
                    required: tru");
            WriteLiteral(@"e,
                    minlength: 10
                },

            },
            messages: {

                Title: {
                    required: ""Please enter a title"",
                    maxlength: ""Your title must be no longer than 15 characters""
                },

                Description: {
                    required: ""Please provide a password"",
                    maxlength: ""Your password must be at least 30 characters long""
                },
                Detail: {
                    required: ""Please provide a password"",
                    maxlength: ""Your password must be at least 30 characters long""
                },


                terms: ""Please accept our terms""
            },
            errorElement: 'span',
            errorPlacement: function (error, element) {
                error.addClass('invalid-feedback');
                element.closest('.form-group').append(error);
            },
            highlight: function (element, errorClass, ");
            WriteLiteral(@"validClass) {
                $(element).addClass('is-invalid');
            },
            unhighlight: function (element, errorClass, validClass) {
                $(element).removeClass('is-invalid');
            }
        });
    });
</script>

<script type=""text/javascript"">
    $(""#AddContent"").click(function () {
        debugger;
        var model = {
            Title: $(""[name='title']"").val(),
            Description: $(""[name='description']"").val(),
            Detail: $(""[name='detail']"").val(),
            category_Id: $(""[name='category_Id']"").val(),
        };
        console.log(JSON.stringify(model));
        var content = JSON.stringify(model);
        $.ajax({
            type: 'POST',
            url: 'https://localhost:44303/api/content/create',
            contentType: 'application/json;charset=utf-8',
            dataType: 'json',
            data: content,
            success: function (gelenveri) {
                $(""AddContent"").removeAttr(""disabled"");
 ");
            WriteLiteral("               alert(\"Kayıt işlemeniz başarılı\")\r\n            },\r\n            error: function (hata) {\r\n                $(\"AddContent\").removeAttr(\"disabled\");\r\n            }\r\n        });\r\n    });\r\n\r\n</scri-->pt>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericRepositoryExampla.Api.Pages.ContentAddModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.ContentAddModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.ContentAddModel>)PageContext?.ViewData;
        public GenericRepositoryExampla.Api.Pages.ContentAddModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\DataTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b60d8b710477e470e809d1c8beb1f9f6e6e71556"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GenericRepositoryExampla.Api.Pages.Pages_DataTable), @"mvc.1.0.razor-page", @"/Pages/DataTable.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60d8b710477e470e809d1c8beb1f9f6e6e71556", @"/Pages/DataTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e69b86c825aa7481aa1ddf9fde830c2b4958ab", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DataTable : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\DataTable.cshtml"
  
    ViewData["Title"] = "Title";
    Layout = "~/Pages/Shared/_LayoutSite1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">

    <!-- Default box -->
    <div class=""card"">
        <div class=""card-header"">
            <h3 class=""card-title"">Projects</h3>

            <div class=""card-tools"">
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                    <i class=""fas fa-minus""></i>
                </button>
                <button type=""button"" class=""btn btn-tool"" data-card-widget=""remove"" title=""Remove"">
                    <i class=""fas fa-times""></i>
                </button>
            </div>
        </div>
      
            <script language=""JavaScript"">
                function yenisayfaac(url, width, height) {
                    window.open(url, '', 'toolbar=0,scrollbars=2,location=0,statusbar=1,menubar=0,resizable=0,width=' + width + ',height=' + height + ',left = 200,top = 100');
                }
            </script>
            <a href=""JavaScript:yenisayfaac('CategoryAdd1','940','760');"" type=""button"" c");
            WriteLiteral(@"lass=""btn btn-danger mb-1"" style=""width: 200px"">Add Category</a>
        </div>

        <div class=""card-body p-0"">
            <table id=""categoryDataTable"" class=""table table-striped projects"">
                <thead>
                    <tr>
                        <th style=""width: 5%"">
                            Id
                        </th>
                        <th style=""width: 28%"">
                            Title
                        </th>
                        <th style=""width: 28%"">
                            Description
                        </th>


                        <th style=""width: 20%"">
                            Edit
                        </th>
                        <th style=""width: 20%"">
                            Delete
                        </th>
                    </tr>
                </thead>
                <tbody id=""output"">
");
            WriteLiteral(@"                    <tr>
                        <td> </td>
                        <td> </td>
                        <td> </td>
                       
                    </tr>

                </tbody>
            </table>
        </div>
        <!-- /.card-body -->
   
    <!-- /.card -->

</section>
<script src=""../../plugins/sweetalert2/sweetalert2.min.js""></script>
<script src=""../../plugins/toastr/toastr.min.js""></script>
<script type=""text/javascript"">
    fetch(""https://localhost:44303/api/category/GetAllCategories"").then(
        res => {
            res.json().then(
                data => {
                    console.log(data);
                    if (data.length > 0) {



                        var temp = """";
                        data.forEach((itemData) => {
                            temp += ""<tr>"";
                            temp += ""<td>"" + itemData.category_Id + ""</td>"";
                            temp += ""<td>"" + itemData.title + ""</td>"";
           ");
            WriteLiteral(@"                 temp += ""<td>"" + itemData.description + ""</td></tr>"";

                        });
                        document.getElementById('output').innerHTML = temp;
                    }
                }
            )
        }
    )
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericRepositoryExampla.Api.Pages.DataTableModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.DataTableModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.DataTableModel>)PageContext?.ViewData;
        public GenericRepositoryExampla.Api.Pages.DataTableModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

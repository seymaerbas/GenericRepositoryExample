#pragma checksum "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\Contents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa7db41f14e656d15c57ec2744b990d5716912bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GenericRepositoryExampla.Api.Pages.Pages_Contents), @"mvc.1.0.razor-page", @"/Pages/Contents.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa7db41f14e656d15c57ec2744b990d5716912bc", @"/Pages/Contents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e69b86c825aa7481aa1ddf9fde830c2b4958ab", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\Contents.cshtml"
  

    ViewData["Title"] = "Title";
    Layout = "~/Pages/Shared/_LayoutSite1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""../../plugins/datatables-bs4/css/dataTables.bootstrap4.min.css"">
<div class=""card-body"">
    <div class=""card"">

        <script language=""JavaScript"">
            function yenisayfaac(url, width, height) {
                window.open(url, '', 'toolbar=0,scrollbars=2,location=0,statusbar=1,menubar=0,resizable=0,width=' + width + ',height=' + height + ',left = 200,top = 100');
            }
        </script>
        <a href=""JavaScript:yenisayfaac('CategoryAdd1','400','200');"" type=""button"" class=""btn btn-danger mb-1"" style=""width: 200px"">Add Category</a>
    </div>
    <div id=""example2_wrapper"" class=""dataTables_wrapper dt-bootstrap4"">
        <div class=""row""><div class=""col-sm-12 col-md-6""><div class=""dt-buttons btn-group flex-wrap"">               <button class=""btn btn-secondary buttons-copy buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>Copy</span></button> <button class=""btn btn-secondary buttons-csv buttons-html5"" tabindex=""0"" aria-cont");
            WriteLiteral(@"rols=""example1"" type=""button""><span>CSV</span></button> <button class=""btn btn-secondary buttons-excel buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>Excel</span></button> <button class=""btn btn-secondary buttons-pdf buttons-html5"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>PDF</span></button> <button class=""btn btn-secondary buttons-print"" tabindex=""0"" aria-controls=""example1"" type=""button""><span>Print</span></button> <div class=""btn-group""><button class=""btn btn-secondary buttons-collection dropdown-toggle buttons-colvis"" tabindex=""0"" aria-controls=""example1"" type=""button"" aria-haspopup=""true"" aria-expanded=""false""><span>Column visibility</span></button></div> </div></div><div class=""col-sm-12 col-md-6""><div id=""example1_filter"" class=""dataTables_filter""><label>Search:<input type=""search"" class=""form-control form-control-sm""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2062, "\"", 2076, 0);
            EndWriteAttribute();
            WriteLiteral(@" aria-controls=""example1""></label></div></div></div>
    
    <div class=""col-sm-12"">
        <table id=""example2"" class=""table table-bordered table-hover dataTable dtr-inline"" aria-describedby=""example2_info"">
            <thead>
                <tr>
                    <th class=""sorting sorting_asc"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""Rendering engine: activate to sort column descending"">ID</th>
                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"">Category ID</th>
                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Browser: activate to sort column ascending"">Title(s)</th>
                    <th class=""sorting"" tabindex=""0"" aria-controls=""example2"" rowspan=""1"" colspan=""1"" aria-label=""Platform(s): activate to sort column ascending"">Description</th>
                </tr>
   ");
            WriteLiteral(@"         </thead>
            <tbody id=""output"">
                <tr class=""odd"">
                    <td class=""dtr-control sorting_1"" tabindex=""0""></td>

                </tr>
                <tr class=""even"">
                    <td class=""dtr-control sorting_1"" tabindex=""0""> </td>

                </tr>
                <tr class=""odd"">
                    <td class=""dtr-control sorting_1"" tabindex=""0""></td>

                </tr>
                <tr class=""even"">
                    <td class=""dtr-control sorting_1"" tabindex=""0""></td>

                </tr>

            </tbody>

        </table>
    </div>
</div><div class=""row""><div class=""col-sm-12 col-md-5""><div class=""dataTables_info"" id=""example2_info"" role=""status"" aria-live=""polite""></div></div><div class=""col-sm-12 col-md-7""><div class=""dataTables_paginate paging_simple_numbers"" id=""example2_paginate""><ul class=""pagination""><li class=""paginate_button page-item previous disabled"" id=""example2_previous""><a href=""#"" aria-cont");
            WriteLiteral(@"rols=""example2"" data-dt-idx=""0"" tabindex=""0"" class=""page-link"">Previous</a></li><li class=""paginate_button page-item active""><a href=""#"" aria-controls=""example2"" data-dt-idx=""1"" tabindex=""0"" class=""page-link"">1</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""2"" tabindex=""0"" class=""page-link"">2</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""3"" tabindex=""0"" class=""page-link"">3</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""4"" tabindex=""0"" class=""page-link"">4</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""5"" tabindex=""0"" class=""page-link"">5</a></li><li class=""paginate_button page-item ""><a href=""#"" aria-controls=""example2"" data-dt-idx=""6"" tabindex=""0"" class=""page-link"">6</a></li><li class=""paginate_button page-item next"" id=""example2_next""><a href=""#"" aria-controls=""example2"" data-dt-idx=""7"" tabindex=""0"" class=""page-");
            WriteLiteral(@"link"">Next</a></li></ul></div></div></div>
    </div>
</div>

<script src=""../../plugins/jquery/jquery.min.js""></script>
<!-- Bootstrap 4 -->
<script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
<!-- DataTables  & Plugins -->
<script src=""../../plugins/datatables/jquery.dataTables.min.js""></script>
<script src=""../../plugins/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
<script src=""../../plugins/datatables-responsive/js/dataTables.responsive.min.js""></script>
<script src=""../../plugins/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
<script src=""../../plugins/datatables-buttons/js/dataTables.buttons.min.js""></script>
<script src=""../../plugins/datatables-buttons/js/buttons.bootstrap4.min.js""></script>


<!-- AdminLTE App -->
<script src=""../../dist/js/adminlte.min.js""></script>
<!-- AdminLTE for demo purposes -->

<script>
    $(function () {

        $('#example2').DataTable({
            ""paging"": true,
            ""lengthChange"": ");
            WriteLiteral(@"true,
            ""searching"": true,
            ""ordering"": true,
            ""info"": true,
            ""autoWidth"": true,
            ""responsive"": true,
        }).buttons().container().appendTo('#example2_wrapper .col-md-6:eq(0)');
    });</script>
<script type=""text/javascript"">
    fetch(""https://localhost:44303/api/content/GetAllContents"").then(
        res => {
            res.json().then(
                data => {
                    console.log(data);
                    if (data.length > 0) {



                        var temp = """";
                        data.forEach((itemData) => {
                            temp += ""<tr>"";
                            temp += ""<td>"" + itemData.content_Id + ""</td>"";
                            temp += ""<td>"" + itemData.category_Id + ""</td>"";
                            temp += ""<td>"" + itemData.title + ""</td>"";
                            temp += ""<td>"" + itemData.description + ""</td></tr>"";

                        });
              ");
            WriteLiteral("          document.getElementById(\'output\').innerHTML = temp;\r\n                    }\r\n                }\r\n            )\r\n        }\r\n    )\r\n</script>\r\n\r\n\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericRepositoryExampla.Api.Pages.ContentsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.ContentsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.ContentsModel>)PageContext?.ViewData;
        public GenericRepositoryExampla.Api.Pages.ContentsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e9b76c67df7944358e04a040c3f569b164d5579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GenericRepositoryExampla.Api.Pages.Pages_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e9b76c67df7944358e04a040c3f569b164d5579", @"/Pages/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05e69b86c825aa7481aa1ddf9fde830c2b4958ab", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\ts\source\repos\GenericRepositroyExample\GenericRepositoryExampla.Api\Pages\Profile.cshtml"
  
    ViewData["Title"] = "Title";
    Layout = "~/Pages/Shared/_LayoutSite1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-5"">

                <!-- Profile Image -->
                <div class=""card card-primary card-outline"">
                    <div class=""card-body box-profile"">
                        <div class=""text-center"">
                            <img class=""profile-user-img img-fluid img-circle"" src=""../../dist/img/user4-128x128.jpg"" alt=""User profile picture"">
                        </div>

                        <h3 class=""profile-username text-center"">Nina Mcintire</h3>

                        <p class=""text-muted text-center"">Software Engineer</p>

                        <ul class=""list-group list-group-unbordered mb-5"">
                            <div class=""card card-primary"">

                                <!-- /.card-header -->
                                <!-- form start -->
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9b76c67df7944358e04a040c3f569b164d55794741", async() => {
                WriteLiteral(@"
                                    <div class=""card-body"">
                                        <div class=""form-group"">
                                            <label for=""exampleInputEmail1"">Adres</label>
                                            <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""Adres"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""exampleInputPassword1"">Telefon Numarası</label>
                                            <input type=""password"" class=""form-control"" id=""exampleInputPassword1"" placeholder=""Telefon Numarası"">
                                        </div>
                                        <div class=""form-group"">
                                            <label for=""exampleInputFile"">Dosya Girişi</label>
                                            <div class=""input-group"">
                         ");
                WriteLiteral(@"                       <div class=""custom-file"">
                                                    <input type=""file"" class=""custom-file-input"" id=""exampleInputFile"">
                                                    <label class=""custom-file-label"" for=""exampleInputFile"">Dosya Seçin</label>
                                                </div>
                                                <div class=""input-group-append"">
                                                    <span class=""input-group-text"">Yükle</span>
                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <!-- /.card-body -->

                                    <div class=""card-footer"">
                                        <button type=""submit"" class=""btn btn-primary"">Kaydet</button>
                                    </div>
                 ");
                WriteLiteral("               ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </ul>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
                <!-- About Me Box -->
                <div class=""card card-primary"">
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
            <div class=""col-md-7"">
                <div class=""card"">
                    <div class=""card-header p-2"">
                        <ul class=""nav nav-pills"">
                            <li class=""nav-item""><a class=""nav-link active"" href=""#activity"" data-toggle=""tab"">Eklenen Dosyalar</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#timeline"" data-toggle=""tab"">Timeline</a></li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#settings"" data-toggle=""tab"">Settings</a></li>
                        </ul>
   ");
            WriteLiteral(@"                 </div><!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""tab-content"">
                            <div class=""active tab-pane"" id=""activity"">
                                <!-- Post -->
                                <div class=""post"">
                                    <div class=""user-block"">
                                        <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user1-128x128.jpg"" alt=""user image"">
                                        <span class=""username"">
                                            <a href=""#"">Jonathan Burke Jr.</a>
                                            <a href=""#"" class=""float-right btn-tool""><i class=""fas fa-times""></i></a>
                                        </span>
                                        <span class=""description"">Shared publicly - 7:30 PM today</span>
                                    </div>
                                    <!-- /.use");
            WriteLiteral(@"r-block -->
                                    <p>
                                        Lorem ipsum represents a long-held tradition for designers,
                                        typographers and the like. Some people hate it and argue for
                                        its demise, but others ignore the hate as they create awesome
                                        tools to help create filler text for everyone from bacon lovers
                                        to Charlie Sheen fans.
                                    </p>

                                    <p>
                                        <a href=""#"" class=""link-black text-sm mr-2""><i class=""fas fa-share mr-1""></i> Share</a>
                                        <a href=""#"" class=""link-black text-sm""><i class=""far fa-thumbs-up mr-1""></i> Like</a>
                                        <span class=""float-right"">
                                            <a href=""#"" class=""link-black text-sm"">
 ");
            WriteLiteral(@"                                               <i class=""far fa-comments mr-1""></i> Comments (5)
                                            </a>
                                        </span>
                                    </p>

                                    <input class=""form-control form-control-sm"" type=""text"" placeholder=""Type a comment"">
                                </div>
                                <!-- /.post -->
                                <!-- Post -->
                                <div class=""post clearfix"">
                                    <div class=""user-block"">
                                        <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user7-128x128.jpg"" alt=""User Image"">
                                        <span class=""username"">
                                            <a href=""#"">Sarah Ross</a>
                                            <a href=""#"" class=""float-right btn-tool""><i class=""fas fa-times""></i></a>
       ");
            WriteLiteral(@"                                 </span>
                                        <span class=""description"">Sent you a message - 3 days ago</span>
                                    </div>
                                    <!-- /.user-block -->
                                    <p>
                                        Lorem ipsum represents a long-held tradition for designers,
                                        typographers and the like. Some people hate it and argue for
                                        its demise, but others ignore the hate as they create awesome
                                        tools to help create filler text for everyone from bacon lovers
                                        to Charlie Sheen fans.
                                    </p>

                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9b76c67df7944358e04a040c3f569b164d557913337", async() => {
                WriteLiteral(@"
                                        <div class=""input-group input-group-sm mb-0"">
                                            <input class=""form-control form-control-sm"" placeholder=""Response"">
                                            <div class=""input-group-append"">
                                                <button type=""submit"" class=""btn btn-danger"">Send</button>
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
                                <!-- /.post -->
                                <!-- Post -->
                                <div class=""post"">
                                    <div class=""user-block"">
                                        <img class=""img-circle img-bordered-sm"" src=""../../dist/img/user6-128x128.jpg"" alt=""User Image"">
                                        <span class=""username"">
                                            <a href=""#"">Adam Jones</a>
                                            <a href=""#"" class=""float-right btn-tool""><i class=""fas fa-times""></i></a>
                                        </span>
                                        <span class=""description"">Posted 5 photos - 5 days ago</span>
                                    </div>
                                    <!-- /.user-block -->
                                    <div class=""row mb-3"">
                                        <div class=""col-sm-6"">");
            WriteLiteral(@"
                                            <img class=""img-fluid"" src=""../../dist/img/photo1.png"" alt=""Photo"">
                                        </div>
                                        <!-- /.col -->
                                        <div class=""col-sm-6"">
                                            <div class=""row"">
                                                <div class=""col-sm-6"">
                                                    <img class=""img-fluid mb-3"" src=""../../dist/img/photo2.png"" alt=""Photo"">
                                                    <img class=""img-fluid"" src=""../../dist/img/photo3.jpg"" alt=""Photo"">
                                                </div>
                                                <!-- /.col -->
                                                <div class=""col-sm-6"">
                                                    <img class=""img-fluid mb-3"" src=""../../dist/img/photo4.jpg"" alt=""Photo"">
                                          ");
            WriteLiteral(@"          <img class=""img-fluid"" src=""../../dist/img/photo1.png"" alt=""Photo"">
                                                </div>
                                                <!-- /.col -->
                                            </div>
                                            <!-- /.row -->
                                        </div>
                                        <!-- /.col -->
                                    </div>
                                    <!-- /.row -->

                                    <p>
                                        <a href=""#"" class=""link-black text-sm mr-2""><i class=""fas fa-share mr-1""></i> Share</a>
                                        <a href=""#"" class=""link-black text-sm""><i class=""far fa-thumbs-up mr-1""></i> Like</a>
                                        <span class=""float-right"">
                                            <a href=""#"" class=""link-black text-sm"">
                                                <i class=""far");
            WriteLiteral(@" fa-comments mr-1""></i> Comments (5)
                                            </a>
                                        </span>
                                    </p>

                                    <input class=""form-control form-control-sm"" type=""text"" placeholder=""Type a comment"">
                                </div>
                                <!-- /.post -->
                            </div>
                            <!-- /.tab-pane -->
                            <div class=""tab-pane"" id=""timeline"">
                                <!-- The timeline -->
                                <div class=""timeline timeline-inverse"">
                                    <!-- timeline time label -->
                                    <div class=""time-label"">
                                        <span class=""bg-danger"">
                                            10 Feb. 2014
                                        </span>
                                    </div>
       ");
            WriteLiteral(@"                             <!-- /.timeline-label -->
                                    <!-- timeline item -->
                                    <div>
                                        <i class=""fas fa-envelope bg-primary""></i>

                                        <div class=""timeline-item"">
                                            <span class=""time""><i class=""far fa-clock""></i> 12:05</span>

                                            <h3 class=""timeline-header""><a href=""#"">Support Team</a> sent you an email</h3>

                                            <div class=""timeline-body"">
                                                Etsy doostang zoodles disqus groupon greplin oooj voxy zoodles,
                                                weebly ning heekya handango imeem plugg dopplr jibjab, movity
                                                jajah plickers sifteo edmodo ifttt zimbra. Babblely odeo kaboodle
                                                quora plaxo ide");
            WriteLiteral(@"eli hulu weebly balihoo...
                                            </div>
                                            <div class=""timeline-footer"">
                                                <a href=""#"" class=""btn btn-primary btn-sm"">Read more</a>
                                                <a href=""#"" class=""btn btn-danger btn-sm"">Delete</a>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- END timeline item -->
                                    <!-- timeline item -->
                                    <div>
                                        <i class=""fas fa-user bg-info""></i>

                                        <div class=""timeline-item"">
                                            <span class=""time""><i class=""far fa-clock""></i> 5 mins ago</span>

                                            <h3 class=""timeline-header border-0"">
      ");
            WriteLiteral(@"                                          <a href=""#"">Sarah Young</a> accepted your friend request
                                            </h3>
                                        </div>
                                    </div>
                                    <!-- END timeline item -->
                                    <!-- timeline item -->
                                    <div>
                                        <i class=""fas fa-comments bg-warning""></i>

                                        <div class=""timeline-item"">
                                            <span class=""time""><i class=""far fa-clock""></i> 27 mins ago</span>

                                            <h3 class=""timeline-header""><a href=""#"">Jay White</a> commented on your post</h3>

                                            <div class=""timeline-body"">
                                                Take me to your leader!
                                                Switzerland is small a");
            WriteLiteral(@"nd neutral!
                                                We are more like Germany, ambitious and misunderstood!
                                            </div>
                                            <div class=""timeline-footer"">
                                                <a href=""#"" class=""btn btn-warning btn-flat btn-sm"">View comment</a>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- END timeline item -->
                                    <!-- timeline time label -->
                                    <div class=""time-label"">
                                        <span class=""bg-success"">
                                            3 Jan. 2014
                                        </span>
                                    </div>
                                    <!-- /.timeline-label -->
                                    <!-- timel");
            WriteLiteral(@"ine item -->
                                    <div>
                                        <i class=""fas fa-camera bg-purple""></i>

                                        <div class=""timeline-item"">
                                            <span class=""time""><i class=""far fa-clock""></i> 2 days ago</span>

                                            <h3 class=""timeline-header""><a href=""#"">Mina Lee</a> uploaded new photos</h3>

                                            <div class=""timeline-body"">
                                                <img src=""https://placehold.it/150x100"" alt=""..."">
                                                <img src=""https://placehold.it/150x100"" alt=""..."">
                                                <img src=""https://placehold.it/150x100"" alt=""..."">
                                                <img src=""https://placehold.it/150x100"" alt=""..."">
                                            </div>
                                        </div>
    ");
            WriteLiteral(@"                                </div>
                                    <!-- END timeline item -->
                                    <div>
                                        <i class=""far fa-clock bg-gray""></i>
                                    </div>
                                </div>
                            </div>
                            <!-- /.tab-pane -->

                            <div class=""tab-pane"" id=""settings"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e9b76c67df7944358e04a040c3f569b164d557925376", async() => {
                WriteLiteral(@"
                                    <div class=""form-group row"">
                                        <label for=""inputName"" class=""col-sm-2 col-form-label"">Name</label>
                                        <div class=""col-sm-10"">
                                            <input type=""email"" class=""form-control"" id=""inputName"" placeholder=""Name"">
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <label for=""inputEmail"" class=""col-sm-2 col-form-label"">Email</label>
                                        <div class=""col-sm-10"">
                                            <input type=""email"" class=""form-control"" id=""inputEmail"" placeholder=""Email"">
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <label");
                WriteLiteral(@" for=""inputName2"" class=""col-sm-2 col-form-label"">Name</label>
                                        <div class=""col-sm-10"">
                                            <input type=""text"" class=""form-control"" id=""inputName2"" placeholder=""Name"">
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <label for=""inputExperience"" class=""col-sm-2 col-form-label"">Experience</label>
                                        <div class=""col-sm-10"">
                                            <textarea class=""form-control"" id=""inputExperience"" placeholder=""Experience""></textarea>
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <label for=""inputSkills"" class=""col-sm-2 col-form-label"">Skills</label>
                         ");
                WriteLiteral(@"               <div class=""col-sm-10"">
                                            <input type=""text"" class=""form-control"" id=""inputSkills"" placeholder=""Skills"">
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <div class=""offset-sm-2 col-sm-10"">
                                            <div class=""checkbox"">
                                                <label>
                                                    <input type=""checkbox""> I agree to the <a href=""#"">terms and conditions</a>
                                                </label>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""form-group row"">
                                        <div class=""offset-sm-2 col-sm-10"">
                          ");
                WriteLiteral("                  <button type=\"submit\" class=\"btn btn-danger\">Submit</button>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
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
                            <!-- /.tab-pane -->
                        </div>
                        <!-- /.tab-content -->
                    </div><!-- /.card-body -->
                </div>
                <!-- /.card -->
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div><!-- /.container-fluid -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GenericRepositoryExampla.Api.Pages.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GenericRepositoryExampla.Api.Pages.ProfileModel>)PageContext?.ViewData;
        public GenericRepositoryExampla.Api.Pages.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

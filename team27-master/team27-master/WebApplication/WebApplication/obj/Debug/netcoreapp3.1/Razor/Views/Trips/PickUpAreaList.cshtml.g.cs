#pragma checksum "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "542db390984918d1ff1011726ebdcc31f2bafc93"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trips_PickUpAreaList), @"mvc.1.0.view", @"/Views/Trips/PickUpAreaList.cshtml")]
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
#line 1 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\_ViewImports.cshtml"
using WebApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"542db390984918d1ff1011726ebdcc31f2bafc93", @"/Views/Trips/PickUpAreaList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Trips_PickUpAreaList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication.Models.PickUpAreaModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/TaxiClubStyles/TaxiClubStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mylogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logos.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
  
    ViewData["Title"] = "Trips";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<script>
    function SelectDriverType() {
        var selec = document.getElementById(""DriverTypeId"");
        var dis = selec.options[selec.selectedIndex].text;
        document.getElementById(""mytext"").value = dis;
    }

    function SelectGender() {
        document.getElementsByName('radio1')
            .forEach(radio => {
                if (radio.checked) {
                    document.getElementById(""inGender"").value = radio.value;
                }
            });
    }</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "542db390984918d1ff1011726ebdcc31f2bafc938387", async() => {
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
<!-- Main content -->
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-3"">

                <!-- Profile Image -->
                <div class=""card card-primary card-outline"">
                    <div class=""card-body box-profile"">

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "542db390984918d1ff1011726ebdcc31f2bafc939847", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                        <h3 class=""profile-username text-center"">TAXI-CLUB</h3>
                        <p class=""text-muted text-center"">Admin</p>
                        <ul class=""list-group list-group-unbordered mb-3"">
                            <li class=""list-group-item"">
                                <b>TaxiClub Email</b> </br> <p>TaxiClub@gmail.com</p>
                            </li>
                            <li class=""list-group-item"">
                                <b>TaxiClub Phone-Number</b> </br><p>(011)-053-4535</p>
                            </li>
                            <li class=""list-group-item"">
                                <b>TaxiClub Fax </b> </br> <p>(011)-053-4535</p>
                            </li>
                        </ul>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "542db390984918d1ff1011726ebdcc31f2bafc9311877", async() => {
                WriteLiteral("\r\n                            <input type=\"submit\" style=\"width:180px\" value=\"UPDATE\" class=\"btn btn-primary\" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
                <!-- About Me Box -->
                <div class=""card card-primary"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">PASSENGER</h3>
                    </div>
                    <!-- /.card-header -->
                    <div class=""card-body"">
                        <strong><i class=""fas fa-book mr-1""></i> detail submitted</strong>

                        <p class=""text-muted"">
                            Documents recieved
                        </p>
                        <hr>
                        <strong><i class=""fas fa-map-marker-alt mr-1""></i> Location</strong>
                        <p class=""text-muted"">Johanesburg</p>
                        <hr>
                    </div>
                    <!-- /.card-body -->
                </div>
                <!-- /.card -->
            </di");
            WriteLiteral(@"v>
            <!-- /.col -->
            <div class=""col-md-9"">
                <div class=""card"">
                    <div class=""card-header p-2"">
                        <ul class=""nav nav-pills"">
                            <li class=""nav-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "542db390984918d1ff1011726ebdcc31f2bafc9314790", async() => {
                WriteLiteral("Activity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"nav-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "542db390984918d1ff1011726ebdcc31f2bafc9316087", async() => {
                WriteLiteral("List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                            <li class=""nav-item""><a class=""nav-link"" href=""#update"" data-toggle=""tab"">Reports</a></li>
                        </ul>
                    </div><!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""tab-content"">
                            <div class=""active tab-pane"" id=""update"">

                                <!-- Post -->
                                <div class=""card card-primary"">
                                    <div class=""card-header"">
                                        <h3 class=""card-title"">TRIPS</h3>
                                    </div>
                                    <!-- /.card-header -->
                                    <div class=""card-body"" style=""background-color:white"">
                                        <div class=""row"">
                                            <div>
                                                <div class=""row"">
                        ");
            WriteLiteral(@"                            <div class=""col-12"">
                                                        <div class=""post"">
                                                            <div>
                                                                <div class=""card-body p-0"">
                                                                    <table class=""table table-striped projects"">
                                                                        <thead>
                                                                            <tr>
                                                                                <th style=""width: 1%"">
                                                                                    #
                                                                                </th>
                                                                                <th style=""width: 8%"">
                                                                               ");
            WriteLiteral(@"     Area
                                                                                </th>
                                                                                <th style=""width: 20%"">
                                                                                    Arrival Time
                                                                                </th>
                                                                                <th style=""width: 25%"" class=""text-center"">
                                                                                    Departure Time
                                                                                </th>

                                                                            </tr>
                                                                        </thead>
");
#nullable restore
#line 127 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                         foreach (var item in Model)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                            <tbody>
                                                                                <tr>
                                                                                    <td>
                                                                                        <ul class=""list-inline"">
                                                                                            <a>
                                                                                                ");
#nullable restore
#line 134 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                                           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                            </a>
                                                                                        </ul>
                                                                                    </td>
                                                                                    <td>
                                                                                        <a>
                                                                                            ");
#nullable restore
#line 140 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                                       Write(item.PickUpArea);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                        </a>
                                                                                    </td>
                                                                                    <td>
                                                                                        <a>
                                                                                            ");
#nullable restore
#line 145 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                                       Write(item.TimeArrival);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                        </a>
                                                                                    </td>
                                                                                    <td>
                                                                                        <a>
                                                                                            ");
#nullable restore
#line 150 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                                       Write(item.TimeDepature);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                        </a>
                                                                                    </td>
                                                                                    <td class=""project-state"">
                                                                                        <span class=""badge badge-success"">Success</span>
                                                                                    </td>
                                                                                    <td class=""project-actions text-right"">
                                                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "542db390984918d1ff1011726ebdcc31f2bafc9324814", async() => {
                WriteLiteral(@"
                                                                                            <i class=""fas fa-trash"">
                                                                                            </i>
                                                                                            Remove
                                                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 157 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                                                                 WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                                    </td>
                                                                                </tr>
                                                                            </tbody>
");
#nullable restore
#line 165 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\PickUpAreaList.cshtml"
                                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                    </table>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- /.card-body -->
                                </div>
                                <!-- Post -->
                                <!-- /.post -->
                            </div>

                            <!-- /.tab-pane -->
                        </div>
                        <!-- /.tab-content -->
                    </div><!-- /.card-body -->
                </div>
                <!-- /.nav-tabs-custom -->
     ");
            WriteLiteral("       </div>\r\n            <!-- /.col -->\r\n        </div>\r\n        <!-- /.row -->\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication.Models.PickUpAreaModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

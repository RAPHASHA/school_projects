<<<<<<< HEAD
#pragma checksum "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0330c50c114efbf34f0b57a70d9346100a5330e2"
=======
#pragma checksum "C:\Users\user\Documents\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d906e0638528f6de166c29380e71ec7f9e97cb"
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_List), @"mvc.1.0.view", @"/Views/Vehicles/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d906e0638528f6de166c29380e71ec7f9e97cb", @"/Views/Vehicles/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication.Models.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/TaxiClubStyles/TaxiClubStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mylogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px !important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/logos.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Driver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("carlogo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/car2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
  
    ViewData["Title"] = "Vehicles";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 8 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0330c50c114efbf34f0b57a70d9346100a5330e29328", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c3d906e0638528f6de166c29380e71ec7f9e97cb9033", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0330c50c114efbf34f0b57a70d9346100a5330e210788", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3d906e0638528f6de166c29380e71ec7f9e97cb10493", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0330c50c114efbf34f0b57a70d9346100a5330e212819", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d906e0638528f6de166c29380e71ec7f9e97cb12524", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0330c50c114efbf34f0b57a70d9346100a5330e215732", async() => {
                WriteLiteral("Activity");
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d906e0638528f6de166c29380e71ec7f9e97cb15467", async() => {
                WriteLiteral("Add");
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
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
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0330c50c114efbf34f0b57a70d9346100a5330e217029", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            <li class=\"nav-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0330c50c114efbf34f0b57a70d9346100a5330e218321", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3d906e0638528f6de166c29380e71ec7f9e97cb16759", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
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
                            
                        </ul>
                    </div><!-- /.card-header -->
                    <div class=""card-body"">
                        <div class=""tab-content"">
                            <div class=""active tab-pane"" id=""update"">
                                <!-- Post -->
                                <!-- Post -->
                                <div class=""card card-primary"">
                                    <div class=""card-header"">
                                        <h3 class=""card-title"">VEHICLES</h3>
                                    </div>
                                    <!-- /.card-header -->
                                    <div class=""card-body"" style=""background-color:white"">
                                        <div class=""row"">
                                            <div>
                                                <div class=""row"">
                                                    <div class=""co");
            WriteLiteral(@"l-12"">
                                                        <div class=""post"">
                                                            <div>
                                                                <div class=""card-body p-0"">
                                                                    <table class=""table table-striped projects"">
                                                                        <thead>
                                                                            <tr>
                                                                                <th style=""width: 1%"">
                                                                                    #
                                                                                </th>
                                                                                <th style=""width: 20%"">
                                                                                    Name
                              ");
            WriteLiteral(@"                                                  </th>
                                                                                <th style=""width: 30%"">
                                                                                    Description
                                                                                </th>
                                                                                <th>
                                                                                    Capacity
                                                                                </th>
                                                                                <th style=""width: 8%"" class=""text-center"">
                                                                                    Status
                                                                                </th>
                                                                                <th style=""width: 20%"">
   ");
            WriteLiteral("                                                                             </th>\r\n                                                                            </tr>\r\n                                                                        </thead>\r\n");
#nullable restore
#line 132 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
                                                                         foreach (var item in Model)
                                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                                            <tbody>
                                                                                <tr>
                                                                                    <td>
                                                                                        #");
#nullable restore
#line 137 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
                                                                                    Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                    </td>
                                                                                    <td>
                                                                                        <a>
                                                                                            ");
#nullable restore
#line 141 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
                                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                        </a>
                                                                                        <br />

                                                                                        <small>
                                                                                            ");
#nullable restore
#line 146 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
                                                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                                                        </small>
                                                                                    </td>
                                                                                    <td>
                                                                                        <ul >
                                                                                           
                                                                                                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0330c50c114efbf34f0b57a70d9346100a5330e226081", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c3d906e0638528f6de166c29380e71ec7f9e97cb24428", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                                                           
                                                                              
                                                                                        </ul>
                                                                                    </td>
                                                                                    <td class=""project_progress"">
                                                                                        <div class=""progress progress-sm"">
                                                                                            <div class=""progress-bar bg-green"" role=""progressbar"" aria-volumenow=""57"" aria-volumemin=""0"" aria-volumemax=""100"" style=""width: 57%"">
                                                                                            </div>
                                                                                        </div>
 ");
            WriteLiteral(@"                                                                                       <small>
                                                                                            57% Complete
                                                                                        </small>
                                                                                    </td>
                                                                                    <td class=""project-state"">
                                                                                        <span class=""badge badge-success"">Success</span>
                                                                                    </td>
                                                                                    <td class=""project-actions text-right"">

                                                                                    

                                                                             ");
            WriteLiteral("       </td>\r\n                                                                                </tr>\r\n                                                                            </tbody>\r\n");
#nullable restore
#line 176 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Vehicles\List.cshtml"
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
            WriteLiteral("           </div>\r\n            <!-- /.col -->\r\n        </div>\r\n        <!-- /.row -->\r\n    </div><!-- /.container-fluid -->\r\n</section>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication.Models.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591

<<<<<<< HEAD
#pragma checksum "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12ee85ae2229420fc3af2c19be3b3cbd65409ee9"
=======
#pragma checksum "C:\Users\user\Documents\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5400cb38cf8c944f95ab907bfb25a5a5872aca8"
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trips_Details), @"mvc.1.0.view", @"/Views/Trips/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5400cb38cf8c944f95ab907bfb25a5a5872aca8", @"/Views/Trips/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa0ef8da47a84ffb33e8bc853509aa4fa5703a26", @"/Views/_ViewImports.cshtml")]
    public class Views_Trips_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.Trip>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/TaxiClubStyles/TaxiClubStyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Driver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditTrip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
  
    ViewData["Title"] = "Trips";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12ee85ae2229420fc3af2c19be3b3cbd65409ee98259", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5400cb38cf8c944f95ab907bfb25a5a5872aca87193", async() => {
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
                <!-- Profile Image -->
                <div class=""card card-primary card-outline"">
                    <div class=""card-body box-profile"">
                        <h3 class=""profile-username text-center""> AREA #");
#nullable restore
#line 35 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                   Write(Model.PickUpAreaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"text-muted text-center\">");
#nullable restore
#line 36 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                     Write(Model.PickUpArea);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <ul class=""list-group list-group-unbordered mb-3"">
                            <li class=""list-group-item"">
                                <b>Linked with</b> <a class=""float-right"">5 Trips</a>
                            </li>
                            <li class=""list-group-item"">
                                <b>Routes</b> <a class=""float-right"">5</a>
                            </li>
                        </ul>
                    </div>
                    <!-- /.card-body -->
                </div>


                <!-- Profile Image -->
                <div class=""card card-primary card-outline"">
                    <div class=""card-body box-profile"">
                        <h3 class=""profile-username text-center""> AREA #");
#nullable restore
#line 53 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                   Write(Model.DropOffAreaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p class=\"text-muted text-center\">");
#nullable restore
#line 54 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                     Write(Model.DropOffArea);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <ul class=""list-group list-group-unbordered mb-3"">
                            <li class=""list-group-item"">
                                <b>Linked with</b> <a class=""float-right"">5 Trips</a>
                            </li>
                            <li class=""list-group-item"">
                                <b>Routes</b> <a class=""float-right"">5</a>
                            </li>
                        </ul>
                    </div>
                    <!-- /.card-body -->
                </div>
            </div>
            <!-- /.col -->
            <div class=""col-md-9"">
                <div class=""card"">
                    <div class=""card-header p-2"">
                        <ul class=""nav nav-pills"">
                            <li class=""nav-item"">");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ee85ae2229420fc3af2c19be3b3cbd65409ee912748", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5400cb38cf8c944f95ab907bfb25a5a5872aca811686", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
                WriteLiteral("Activity");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                                   WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                             <li class=\"nav-item\">");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ee85ae2229420fc3af2c19be3b3cbd65409ee915108", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5400cb38cf8c944f95ab907bfb25a5a5872aca814047", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
                WriteLiteral("Driver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                           WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
                                <div class=""card card-primary"">
                                    <div class=""card-header"">
                                        <h3 class=""card-title"">TRIP ");
#nullable restore
#line 83 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                               Write(Model.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                    </div>
                                    <!-- /.card-header -->
                                    <div class=""card-body"" style=""background-color:white"">
                                        <div class=""row"">
                                            <div>
                                                <div class=""row"" style=""position:relative; left:30px; top:20px;"">
                                                    <div class=""col-12 col-sm-6"">
                                                        <div class=""info-box bg-light"">
                                                            <div class=""info-box-content"">
<<<<<<< HEAD
                                                                <span class=""info-box-text text-center text-muted"">Added by</span>
                                                                <span class=""info-box-number text-center text-muted mb-0"">Admin 1</span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-12 col-sm-4"">
                                                        <div class=""info-box bg-light"">
                                    ");
            WriteLiteral(@"                        <div class=""info-box-content"">
                                                                <span class=""info-box-text text-center text-muted"">Last modified</span>
                                                                <span class=""info-box-number text-center text-muted mb-0"">05/04/2020<span>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                                </br>
                                                <div class=""row"">
                                                    <div class=""col-12"">
                                                        <div class=""post"">
                                                            <div class=""user-block"">
                                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "12ee85ae2229420fc3af2c19be3b3cbd65409ee921464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                                <span class=\"username\">\r\n                                                                    <a href=\"#\">");
#nullable restore
#line 122 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 122 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                       Write(Model.Surname);
=======
                                                                <span class=""info-box-number text-center text-muted mb-0"">Pick Up Town</span>
                                                                <span class=""info-box-text text-center text-muted"">");
#nullable restore
#line 94 "C:\Users\user\Documents\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                                              Write(Model.PickUpArea);
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-12 col-sm-6"">
                                                        <div class=""info-box bg-light"">
                                                            <div class=""info-box-content"">
                                                                <span class=""info-box-number text-center text-muted mb-0"">Drop Off Town</span>
                                                                <span class=""info-box-text text-center text-muted"">");
#nullable restore
<<<<<<< HEAD
#line 130 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                         Write(Model.PickUpArea);
=======
#line 103 "C:\Users\user\Documents\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                                              Write(Model.DropOffArea);
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
<<<<<<< HEAD
                                                                </div>
                                                                <div class=""col-3"">
                                                                    <h5 class=""headline"">DropOff-Town </h5>
                                                                    <span class=""description"">");
#nullable restore
#line 134 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                         Write(Model.DropOffArea);
=======
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992

                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-12 col-sm-6"">
                                                        <div class=""info-box bg-light"">
                                                            <div class=""info-box-content"">
                                                                <span class=""info-box-number text-center text-muted mb-0"">Arrival Time</span>
                                                                <span class=""info-box-text text-center text-muted"">");
#nullable restore
<<<<<<< HEAD
#line 138 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                         Write(Model.ArrivalTime);
=======
#line 112 "C:\Users\user\Documents\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                                              Write(Model.ArrivalTime);
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                                
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <div class=""col-12 col-sm-6"">
                                                        <div class=""info-box bg-light"">
                                                            <div class=""info-box-content"">
                                                                <span class=""info-box-number text-center text-muted mb-0"">Leave Time</span>
                                                                <span class=""info-box-text text-center text-muted"">");
#nullable restore
<<<<<<< HEAD
#line 142 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                         Write(Model.DepartureTime);
=======
#line 121 "C:\Users\user\Documents\team27\WebApplication\WebApplication\Views\Trips\Details.cshtml"
                                                                                                              Write(Model.DepartureTime);
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                                              </div>
                                                        </div>
                                                    </div>

                                                </div>
                                                </br>
                                                <div class=""row"">
                                                    <div class=""col-20"">
                                                        <div class=""post"">
                                                          
                                                           
                                                            ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ee85ae2229420fc3af2c19be3b3cbd65409ee926916", async() => {
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12ee85ae2229420fc3af2c19be3b3cbd65409ee927239", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5400cb38cf8c944f95ab907bfb25a5a5872aca822523", async() => {
                WriteLiteral("\r\n                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5400cb38cf8c944f95ab907bfb25a5a5872aca822846", async() => {
>>>>>>> 544765d59257fd01a3f8e646a3e6981a632af992
                    WriteLiteral("Suspend Trip");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                                                                                             \r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
            </div>
            <!-- /.col -->
        </div>
        <!-- /.row -->
    </div><!-- /.container-fluid -->
</section>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.Trip> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8770619c54042a49eabfe49a049abbfbd207dbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Controllers_GetMyAreas), @"mvc.1.0.view", @"/Controllers/GetMyAreas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8770619c54042a49eabfe49a049abbfbd207dbb", @"/Controllers/GetMyAreas.cshtml")]
    public class Controllers_GetMyAreas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication.Models.MultipleData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
  
    var pickupareas = Model.PickUpAreas;
    var dropoffareas = Model.DropOffAreas;


    foreach (var item in pickupareas)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
   Write(item.PickUpArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 16 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
   Write(item.TimeArrival);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 18 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
   Write(item.TimeDepature);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 20 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
    }


    foreach (var item in dropoffareas)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
   Write(item.DropOffArea);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 27 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
   Write(item.TimeArrival);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 29 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
   Write(item.TimeDepature);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 31 "C:\Users\rapha\Desktop\team27\WebApplication\WebApplication\Controllers\GetMyAreas.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication.Models.MultipleData> Html { get; private set; }
    }
}
#pragma warning restore 1591

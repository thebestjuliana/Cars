#pragma checksum "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f1e948d1a52c6f60d39d5837cddd25a200e01c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Results), @"mvc.1.0.view", @"/Views/Home/Results.cshtml")]
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
#line 1 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\_ViewImports.cshtml"
using CarWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\_ViewImports.cshtml"
using CarWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f1e948d1a52c6f60d39d5837cddd25a200e01c", @"/Views/Home/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d95373fc8f42931631c6433bcd3c35a5152bbe1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
 foreach (Car car in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Car #");
#nullable restore
#line 5 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
        Write(car.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p>Make: ");
#nullable restore
#line 6 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
        Write(car.make);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Model: ");
#nullable restore
#line 7 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
         Write(car.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Color: ");
#nullable restore
#line 8 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
         Write(car.color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Year: ");
#nullable restore
#line 9 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
        Write(car.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "C:\Users\sheeh\source\repos\CarCapstone\CarWebApp\Views\Home\Results.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Medicines\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11ea601ab619a7977ee051425abe8a0b8b6214c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Medicines_Details), @"mvc.1.0.view", @"/Views/Medicines/Details.cshtml")]
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
#line 1 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\_ViewImports.cshtml"
using Hospital.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11ea601ab619a7977ee051425abe8a0b8b6214c5", @"/Views/Medicines/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076991dabefa97748691772bdf45b487097a01bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Medicines_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Medicines>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"thumbnail bg-light\">\r\n    <div class=\"caption-full\">\r\n        <h3>Название продукта</h3>\r\n        <h3><a href=\"#\"> ");
#nullable restore
#line 8 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Medicines\Details.cshtml"
                    Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> </h3>\r\n        <h4 class=\"pull-right\">Цена: ");
#nullable restore
#line 9 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Medicines\Details.cshtml"
                                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>Производитель: ");
#nullable restore
#line 10 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Medicines\Details.cshtml"
                      Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <p class=\"font-italic\">Описание: ");
#nullable restore
#line 11 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Medicines\Details.cshtml"
                                    Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Medicines> Html { get; private set; }
    }
}
#pragma warning restore 1591

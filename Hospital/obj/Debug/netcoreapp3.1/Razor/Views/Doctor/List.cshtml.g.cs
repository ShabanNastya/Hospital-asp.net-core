#pragma checksum "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e07a80ad58f51c06b80de6481b7d9160f5a8fd7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_List), @"mvc.1.0.view", @"/Views/Doctor/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e07a80ad58f51c06b80de6481b7d9160f5a8fd7f", @"/Views/Doctor/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"076991dabefa97748691772bdf45b487097a01bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorListViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e07a80ad58f51c06b80de6481b7d9160f5a8fd7f3242", async() => {
                WriteLiteral("\r\n<h2>");
#nullable restore
#line 4 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n<div class=\"card-deck\">\r\n");
#nullable restore
#line 6 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"
     foreach (var doctor in Model.Doctors)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card\" style=\"width: 25rem;\">\r\n                <img class=\"card-img-top\"");
                BeginWriteAttribute("src", " src=\"", 239, "\"", 270, 1);
#nullable restore
#line 9 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"
WriteAttributeValue("", 245, doctor.ImageThumbnailUrl, 245, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"doctor for the hospital\"/>\r\n                <div class=\"card-body\">\r\n                    <h3 class=\"card-title\">");
#nullable restore
#line 11 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"
                                      Write(doctor.Surname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                    <h2 class=\"card-text\">");
#nullable restore
#line 12 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"
                                     Write(doctor.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 13 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"
                                    Write(doctor.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 16 "C:\Users\Настя\RiderProjects\Hospital\Hospital\Views\Doctor\List.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

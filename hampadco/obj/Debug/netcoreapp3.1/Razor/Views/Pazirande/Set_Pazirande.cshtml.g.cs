#pragma checksum "d:\pazirande\pazirande\hampadco\Views\Pazirande\Set_Pazirande.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97b2962f51ce7130adcdd6d2a631cf64df01bb00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pazirande_Set_Pazirande), @"mvc.1.0.view", @"/Views/Pazirande/Set_Pazirande.cshtml")]
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
#line 1 "d:\pazirande\pazirande\hampadco\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\pazirande\pazirande\hampadco\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97b2962f51ce7130adcdd6d2a631cf64df01bb00", @"/Views/Pazirande/Set_Pazirande.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab99064084068b19349a35efc6c15a1d282f4711", @"/Views/_ViewImports.cshtml")]
    public class Views_Pazirande_Set_Pazirande : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "d:\pazirande\pazirande\hampadco\Views\Pazirande\Set_Pazirande.cshtml"
  
    ViewData["Title"] = "ثبت پذیرنده";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <h1>محتوا</h1>
                <nav class=""breadcrumb-container d-none d-sm-block d-lg-inline-block"" aria-label=""breadcrumb"">
                    <ol class=""breadcrumb pt-0"">
                        <li class=""breadcrumb-item"">
                            <a href=""#"">صفحه اصلی</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page""> تکمیل اطلاعات  </li>
                    </ol>
                </nav>
                <div class=""separator mb-5""></div>
            </div>
        </div>
");
#nullable restore
#line 21 "d:\pazirande\pazirande\hampadco\Views\Pazirande\Set_Pazirande.cshtml"
         if(ViewBag.msg != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"container-fluid\">\r\n                    <div class=\"card mb-4\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"mb-4 text-danger\"> ");
#nullable restore
#line 27 "d:\pazirande\pazirande\hampadco\Views\Pazirande\Set_Pazirande.cshtml"
                                                     Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                            <p class=\"d-none\">");
#nullable restore
#line 28 "d:\pazirande\pazirande\hampadco\Views\Pazirande\Set_Pazirande.cshtml"
                                         Write(ViewBag.ex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div> \r\n                </div>   \r\n            </div>  \r\n");
#nullable restore
#line 33 "d:\pazirande\pazirande\hampadco\Views\Pazirande\Set_Pazirande.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

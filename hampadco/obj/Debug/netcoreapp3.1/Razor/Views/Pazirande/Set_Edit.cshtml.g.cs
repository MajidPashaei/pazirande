#pragma checksum "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c97b89f99cf11d1e8a4aab72b53e3ff0b82850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pazirande_Set_Edit), @"mvc.1.0.view", @"/Views/Pazirande/Set_Edit.cshtml")]
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
#line 1 "e:\Hampadco-master\hampadco\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\Hampadco-master\hampadco\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c97b89f99cf11d1e8a4aab72b53e3ff0b82850", @"/Views/Pazirande/Set_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c7bfff406093198dff2bc9c98ebe6752e4157", @"/Views/_ViewImports.cshtml")]
    public class Views_Pazirande_Set_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
  
    ViewData["Title"] = "Set_Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                
                <nav class=""breadcrumb-container d-none d-sm-block d-lg-inline-block"" aria-label=""breadcrumb"">
                    <ol class=""breadcrumb pt-0"">
                        <li class=""breadcrumb-item"">
                            <a href=""#"">صفحه اصلی</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page""> ویرایش اطلاعات  </li>
                    </ol>
                </nav>
                <div class=""separator mb-5""></div>
            </div>
        </div>
");
#nullable restore
#line 21 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
         if(ViewBag.msg != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"container-fluid\">\r\n                    <div class=\"card mb-4\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"mb-4 text-danger\"> ");
#nullable restore
#line 27 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
                                                     Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n");
#nullable restore
#line 28 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
                             if(ViewBag.ex != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"d-none\">");
#nullable restore
#line 30 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
                                             Write(ViewBag.ex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div> \r\n                </div>   \r\n            </div>  \r\n");
#nullable restore
#line 36 "e:\Hampadco-master\hampadco\Views\Pazirande\Set_Edit.cshtml"
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

#pragma checksum "e:\Hampadco-master\hampadco\Views\Account\SetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad2ff51ea7e6b7b94f5af615cac3c9f1cbe58a61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SetUser), @"mvc.1.0.view", @"/Views/Account/SetUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2ff51ea7e6b7b94f5af615cac3c9f1cbe58a61", @"/Views/Account/SetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c7bfff406093198dff2bc9c98ebe6752e4157", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "e:\Hampadco-master\hampadco\Views\Account\SetUser.cshtml"
  
    ViewData["Title"] = "ثبت کاربر جدید";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">

                <h1>محتوا</h1>
                <nav class=""breadcrumb-container d-none d-sm-block d-lg-inline-block"" aria-label=""breadcrumb"">
                    <ol class=""breadcrumb pt-0"">
                        <li class=""breadcrumb-item"">
                            <a href=""#"">صفحه اصلی</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">ثبت کاربر</li>
                    </ol>
                </nav>
                <div class=""separator mb-5""></div>


            </div>
        </div>
        <div class=""row"">
            <div class=""container-fluid"">
                <div class=""card mb-4"">
                    <div class=""card-body"">
                       
");
#nullable restore
#line 28 "e:\Hampadco-master\hampadco\Views\Account\SetUser.cshtml"
                                 if (ViewBag.msg!=  null)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"alert alert-dark rounded mb-0\" role=\"alert\">\r\n                                   ");
#nullable restore
#line 31 "e:\Hampadco-master\hampadco\Views\Account\SetUser.cshtml"
                              Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </div>\r\n");
#nullable restore
#line 33 "e:\Hampadco-master\hampadco\Views\Account\SetUser.cshtml"
                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>");
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

#pragma checksum "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\Account\SetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8f3778aa672821ac1377e295c065e118ed33e48"
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
#line 1 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8f3778aa672821ac1377e295c065e118ed33e48", @"/Views/Account/SetUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab99064084068b19349a35efc6c15a1d282f4711", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\Account\SetUser.cshtml"
  
    ViewData["Title"] = "ثبت کاربر جدید";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">

                
                <nav class=""breadcrumb-container d-none d-sm-block d-lg-inline-block"" aria-label=""breadcrumb"">
                    <ol class=""breadcrumb pt-0"">
                        <li class=""breadcrumb-item"">
                            <a href=""#"">صفحه اصلی</a>
                        </li>
                        <li class=""breadcrumb-item active"" aria-current=""page"">ثبت پذیرنده</li>
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
#line 28 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\Account\SetUser.cshtml"
                                 if (ViewBag.msg!=  null)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"alert alert-dark rounded mb-0\" role=\"alert\">\r\n                                   ");
#nullable restore
#line 31 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\Account\SetUser.cshtml"
                              Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </div>\r\n");
#nullable restore
#line 33 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Views\Account\SetUser.cshtml"
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

#pragma checksum "d:\pazirande\pazirande\hampadco\Views\Home\pazirande.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74aae3962e58ff4c90fc4d457ebfc8a5ae267900"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_pazirande), @"mvc.1.0.view", @"/Views/Home/pazirande.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74aae3962e58ff4c90fc4d457ebfc8a5ae267900", @"/Views/Home/pazirande.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab99064084068b19349a35efc6c15a1d282f4711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_pazirande : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "d:\pazirande\pazirande\hampadco\Views\Home\pazirande.cshtml"
  
    ViewData["Title"] = "بخش کاربران";

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
                        <li class=""breadcrumb-item active"" aria-current=""page"">پذیرنده</li>
                    </ol>
                </nav>
                <div class=""separator mb-5""></div>


            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <a href=""/Pazirande/New"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                              ");
            WriteLiteral(@"  <div>
                                    <p class=""lead text-white"">ثبت پذیرنده جدید</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-folder-add-- text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-4"">
                <a href=""/Pazirande/all"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">پذیرنده های ثبت شده</p>
                                </div>
                            </div>

                        ");
            WriteLiteral(@"    <div>
                                <div>
                                    <i class=""pr-2 iconsminds-folder-cloud text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-4"">
                <a href=""/Pazirande/Edit"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">ویرایش پذیرنده</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-folder-edit text-white""></i>
                                </div>
                  ");
            WriteLiteral(@"          </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
                <a href=""/Pazirande/wait"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-sand-watch-2 text-white""></i>
                                <div>
                                    <p class=""lead text-white"">5 پذیرنده</p>
                                    <p class=""text-small text-white"">درانتظار تایید است</p>
                                </div>
                            </div>

                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=");
            WriteLiteral(@"""white""
                                    data-trail-color=""rgba(255,255,255,0.2)"" aria-valuenow=""5"" aria-valuemax=""20""
                                    data-show-percent=""false"">
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-4"">
                <a href=""/Pazirande/Ok"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-big-data text-white""></i>
                                <div>
                                    <p class=""lead text-white"">4 پذیرنده</p>
                                    <p class=""text-small text-white"">تایید شده است</p>
                                </div>
                            </div>
               ");
            WriteLiteral(@"             <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)"" aria-valuenow=""5"" aria-valuemax=""20""
                                    data-show-percent=""false"">
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-4"">
                <a href=""/Pazirande/No"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-unlike text-white""></i>
                                <div>
                                    <p class=""lead text-white"">8 پذیر");
            WriteLiteral(@"نده</p>
                                    <p class=""text-small text-white"">عدم تایی شده است</p>
                                </div>
                            </div>
                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)"" aria-valuenow=""10"" aria-valuemax=""20""
                                    data-show-percent=""false"">
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>

    </div>
</main>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

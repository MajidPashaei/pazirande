<<<<<<< HEAD
#pragma checksum "d:\pazirande\pazirande\hampadco\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85fd52a6cccaa44be79705257b2f2ac0bd222b0"
=======
#pragma checksum "e:\Hampadco-master\hampadco\Views\Home\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85fd52a6cccaa44be79705257b2f2ac0bd222b0"
>>>>>>> 2472f185abb495aa744226c79e10bc28eb0c9bb4
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Users), @"mvc.1.0.view", @"/Views/Home/Users.cshtml")]
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
<<<<<<< HEAD
#line 1 "d:\pazirande\pazirande\hampadco\Views\_ViewImports.cshtml"
=======
#line 1 "e:\Hampadco-master\hampadco\Views\_ViewImports.cshtml"
>>>>>>> 2472f185abb495aa744226c79e10bc28eb0c9bb4
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "d:\pazirande\pazirande\hampadco\Views\_ViewImports.cshtml"
=======
#line 2 "e:\Hampadco-master\hampadco\Views\_ViewImports.cshtml"
>>>>>>> 2472f185abb495aa744226c79e10bc28eb0c9bb4
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f85fd52a6cccaa44be79705257b2f2ac0bd222b0", @"/Views/Home/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c7bfff406093198dff2bc9c98ebe6752e4157", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
<<<<<<< HEAD
#line 1 "d:\pazirande\pazirande\hampadco\Views\Home\Users.cshtml"
=======
#line 1 "e:\Hampadco-master\hampadco\Views\Home\Users.cshtml"
>>>>>>> 2472f185abb495aa744226c79e10bc28eb0c9bb4
  
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
                        <li class=""breadcrumb-item active"" aria-current=""page"">کاربران</li>
                    </ol>
                </nav>
                <div class=""separator mb-5""></div>


            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-3"">
                <a href=""/Account/NewAccount"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                               ");
            WriteLiteral(@" <div>
                                    <p class=""lead text-white"">ثبت کاربر جدید</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-add-user text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3"">
                <a href=""/Account/SearchToUpload"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">آپلود مدارک کاربر</p>
                                </div>
                            </div>

                        ");
            WriteLiteral(@"    <div>
                                <div>
                                    <i class=""iconsminds-male-2 text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3"">
                <a href=""/Account/Account"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">کاربران ثبت شده</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""pr-2 iconsminds-mens text-white""></i>
                                </div>
                            <");
            WriteLiteral(@"/div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3"">
                <a href=""/Account/EditAccount"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">ویرایش کاربر</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-male text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>


    </div>
</main>");
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

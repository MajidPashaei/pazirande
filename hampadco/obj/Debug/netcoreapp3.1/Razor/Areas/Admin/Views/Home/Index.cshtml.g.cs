#pragma checksum "e:\Hampadco-master\hampadco\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9104c0e8341a249f3564c78e2ad244b041d1bf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
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
#line 1 "e:\Hampadco-master\hampadco\Areas\Admin\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "e:\Hampadco-master\hampadco\Areas\Admin\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9104c0e8341a249f3564c78e2ad244b041d1bf0", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c7bfff406093198dff2bc9c98ebe6752e4157", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "e:\Hampadco-master\hampadco\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "کارتابل مدیریت";

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
                            <li class=""breadcrumb-item active"" aria-current=""page"">داده ها</li>
                        </ol>
                    </nav>
                    <div class=""separator mb-5""></div>


                </div>
                <div class=""col-lg-12 col-xl-12"">

                    <div class=""icon-cards-row"">
                        <div class=""glide dashboard-numbers"">
                            <div class=""glide__track"" data-glide-el=""track"">
                                <ul class=""glide__slides"">
  ");
            WriteLiteral(@"                                  <li class=""glide__slide"">
                                        <a href=""/Admin/home/NewUser"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-conference""></i>
                                                <p class=""card-text mb-0"">ثبت نماینده جدید</p>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""glide__slide"">
                                        <a href=""/admin/home/AllUser"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-male-female""></i>
                                                <p class=""card-text mb-0"">نمایندگان ثبت شده</p>
                                            </div>
       ");
            WriteLiteral(@"                                 </a>
                                    </li>
                                    <li class=""glide__slide"">
                                        <a href=""/admin/home/EditUser"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-id-card mr-2 text-grey align-text-bottom d-inline-block""></i>
                                                <p class=""card-text mb-0"">ویرایش نمایندگان</p>
                                            </div>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>

                </div>

            </div>




  
        
        <div class=""row"">
            <div class=""col-lg-3"">
                <a href=""/Pazirande/New"">
                    <div class=""");
            WriteLiteral(@"card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">پذیرند های ثبتی  جدید</p>
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
            <div class=""col-lg-3"">
                <a href=""/Pazirande/all"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                      ");
            WriteLiteral(@"          <div>
                                    <p class=""lead text-white"">پذیرنده های تایید شده </p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""pr-2 iconsminds-folder-cloud text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3"">
                <a href=""/Pazirande/Edit"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">پذیرنده های رد شده</p>
                                </div>
                            </div>

     ");
            WriteLiteral(@"                       <div>
                                <div>
                                    <i class=""iconsminds-folder-edit text-white""></i>
                                </div>
                            </div>
                        </div>
                    </div>
                </a>
            </div>
            <div class=""col-lg-3"">
                <a href=""/Pazirande/Edit"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">کل ثبت شده ها</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-folder-edit text-white""></i>
                                </div>
      ");
            WriteLiteral(@"                      </div>
                        </div>
                    </div>
                </a>
            </div>
        </div>
        <div class=""row"">
            
                <div class=""col-lg-12 col-xl-12"">

                    <div class=""icon-cards-row"">
                        <div class=""glide dashboard-numbers"">
                            <div class=""glide__track"" data-glide-el=""track"">
                                <ul class=""glide__slides"">
                                    <li class=""glide__slide col-lg-6"">
                                        <a href=""/admin/home/Accounts"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-add-user""></i>
                                                <p class=""card-text mb-0"">کاربران ثبت شده</p>
                                            </div>
                                        </a>
              ");
            WriteLiteral(@"                      </li>
                                    <li class=""glide__slide col-lg-6"">
                                        <a href=""/admin/home/EditAccount"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-mens""></i>
                                                <p class=""card-text mb-0"">ویرایش کاربران</p>
                                            </div>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>

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

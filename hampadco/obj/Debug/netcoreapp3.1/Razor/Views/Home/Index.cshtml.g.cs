#pragma checksum "E:\Hampadco-master\hampadco\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f238c3b0a60423d18d8b7cf0ad8b32c667c15a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\Hampadco-master\hampadco\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Hampadco-master\hampadco\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f238c3b0a60423d18d8b7cf0ad8b32c667c15a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c7bfff406093198dff2bc9c98ebe6752e4157", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", new global::Microsoft.AspNetCore.Html.HtmlString("&nbsp;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Hampadco-master\hampadco\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "کارتابل شخصی";

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
                            <li class=""breadcrumb-item"">
                                <a href=""#""></a>
                            </li>
                            <li class=""breadcrumb-item active"" aria-current=""page"">داده ها</li>
                        </ol>
                    </nav>
                    <div class=""separator mb-5""></div>


                </div>
                <div class=""col-lg-12 col-xl-6"">

                    <div class=""icon-cards-row"">
                        <div class=""glide dashboard-numbers"">
                        ");
            WriteLiteral(@"    <div class=""glide__track"" data-glide-el=""track"">
                                <ul class=""glide__slides"">
                                    <li class=""glide__slide"">
                                        <a href=""/Account/NewAccount"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-add-user""></i>
                                                <p class=""card-text mb-0"">کاربر جدید</p>
                                                <p class=""lead text-center"">16</p>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""glide__slide"">
                                        <a href=""/Account/Account"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-");
            WriteLiteral(@"mens""></i>
                                                <p class=""card-text mb-0"">کاربران ثبت شده</p>
                                                <p class=""lead text-center"">32</p>
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""glide__slide"">
                                        <a href=""/Account/EditAccount"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-male mr-2 text-grey align-text-bottom d-inline-block""></i>
                                                <p class=""card-text mb-0"">ویراش کاربر</p>
                                                <p class=""lead text-center"">2</p>
                                            </div>
                                        </a>
                                    </li>
                                <");
            WriteLiteral(@"/ul>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-md-12 mb-4"">
                            <div class=""card"">
                                <div class=""position-absolute card-top-buttons"">
                                    <button class=""btn btn-header-light icon-button"" type=""button"">
                                        <i class=""simple-icon-refresh""></i>
                                    </button>
                                </div>

                                <div class=""card-body"">
                                    <h5 class=""card-title"">ارتباط با پشتیبانی</h5>
                                    <div class=""dashboard-quick-post"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f238c3b0a60423d18d8b7cf0ad8b32c667c15a7877", async() => {
                WriteLiteral(@"
                                            <div class=""form-group row"">
                                                <label class=""col-sm-3 col-form-label"">عنوان</label>
                                                <div class=""col-sm-9"">
                                                    <input type=""email"" class=""form-control""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 4291, "\"", 4305, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-sm-3 col-form-label"">محتوا</label>
                                                <div class=""col-sm-9"">
                                                    <textarea class=""form-control"" rows=""3""></textarea>
                                                </div>
                                            </div>
                                            <div class=""form-group row"">
                                                <label class=""col-sm-3 col-form-label"">مجموعه</label>
                                                <div class=""col-sm-9"">
                                                    <label class=""w-100"">
                                                        <select class=""form-control select2-single"" data-width=""100%"">
                      ");
                WriteLiteral("                                      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f238c3b0a60423d18d8b7cf0ad8b32c667c15a9766", async() => {
                    WriteLiteral("&nbsp;");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f238c3b0a60423d18d8b7cf0ad8b32c667c15a10925", async() => {
                    WriteLiteral("فنی");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f238c3b0a60423d18d8b7cf0ad8b32c667c15a11995", async() => {
                    WriteLiteral("مدیریت");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f238c3b0a60423d18d8b7cf0ad8b32c667c15a13068", async() => {
                    WriteLiteral("بازرگانی");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                                        </select>
                                                    </label>
                                                </div>
                                            </div>

                                            <div class=""form-group row mb-0"">
                                                <div class=""col-sm-12"">
                                                    <button type=""submit""
                                                        class=""btn btn-primary float-right"">ارسال</button>
                                                </div>
                                            </div>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""col-xl-6 col-lg-12 mb-4"">
                    <div class=""card h-100"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">آخرین کاربران ثبت شده</h5>
                            <table class=""data-table data-table-standard responsive nowrap""
                                data-order=""[[ 1, &quot;desc&quot; ]]"">
                                <thead>
                                    <tr>
                                        <th>نام</th>
                                        <th>نام خانوادگی</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>
                              ");
            WriteLiteral(@"              <p class=""list-item-heading"">کیک عروسی با گل ماکارون</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">1452</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">کیک پنیری با کلوچه های شکلاتی</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">1420</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">چیزکیک خانگی با توت تازه</p>
                                        </td>
                  ");
            WriteLiteral(@"                      <td>
                                            <p class=""text-muted"">1360</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">چیزکیک با توت تازه</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">1310</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">قرص چای با پرتقال تازه</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">1245</p>
                                        </td>
");
            WriteLiteral(@"                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">کیک پنیری با کلوچه های شکلاتی</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">1100</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">چیزکیک خانگی با توت تازه</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">1003</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
       ");
            WriteLiteral(@"                                     <p class=""list-item-heading"">چیزکیک خانگی با توت تازه</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">952</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">چیزکیک با توت تازه</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">924</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">قرص چای با پرتقال تازه</p>
                                        </td>
         ");
            WriteLiteral(@"                               <td>
                                            <p class=""text-muted"">842</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">کیک پنیری با کلوچه های شکلاتی</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">810</p>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class=""list-item-heading"">چیزکیک خانگی با توت تازه</p>
                                        </td>
                                        <td>
                                            <p class=""text-muted"">605</p>
                           ");
            WriteLiteral(@"             </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>



                </div>
            </div>




  
        
        <div class=""row"">
            <div class=""col-lg-4"">
                <a href=""/Pazirande/New"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">ثبت پذیرنده جدید</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-folder-add-- text-white""></i>
                                </div>
                            </div>
                        </div>
 ");
            WriteLiteral(@"                   </div>
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

                            <div>
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
      ");
            WriteLiteral(@"                  <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <div>
                                    <p class=""lead text-white"">ویرایش پذیرنده</p>
                                </div>
                            </div>

                            <div>
                                <div>
                                    <i class=""iconsminds-folder-edit text-white""></i>
                                </div>
                            </div>
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
                              ");
            WriteLiteral(@"  <i class=""iconsminds-sand-watch-2 text-white""></i>
                                <div>
                                    <p class=""lead text-white"">5 پذیرنده</p>
                                    <p class=""text-small text-white"">درانتظار تایید است</p>
                                </div>
                            </div>

                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)"" aria-valuenow=""5"" aria-valuemax=""20""
                                    data-show-percent=""false"">
                                </div>
                            </div>
                        </div>
                    </div></a>
                </div>
                <div class=""col-lg-4"">
                    <a href=""/Pazirande/Ok"">
                    <div class=""card mb-4 progress-banner""");
            WriteLiteral(@">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-big-data text-white""></i>
                                <div>
                                    <p class=""lead text-white"">4 پذیرنده</p>
                                    <p class=""text-small text-white"">تایید شده است</p>
                                </div>
                            </div>
                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)"" aria-valuenow=""5"" aria-valuemax=""20""
                                    data-show-percent=""false"">
                                </div>
                            </div>
                        </div>
                    </div>
      ");
            WriteLiteral(@"              </a>
                </div>
                <div class=""col-lg-4"">
                    <a href=""/Pazirande/No"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-unlike text-white""></i>
                                <div>
                                    <p class=""lead text-white"">8 پذیرنده</p>
                                    <p class=""text-small text-white"">عدم تایی شده است</p>
                                </div>
                            </div>
                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)"" aria-valuenow=""10"" aria-valuemax=""20""
               ");
            WriteLiteral(@"                     data-show-percent=""false"">
                                </div>
                            </div>
                        </div>
                    </div>
                    </a>
                </div>
            </div>




            <div class=""row"">
                <div class=""col-md-12 col-lg-12 mb-4"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">اخرین گزارش پذیرنده ها</h5>

                            <div class=""scroll dashboard-list-with-user"">
                                <div class=""d-flex flex-row mb-3 pb-3 border-bottom"">
                                    <a href=""#"">
                                        <img alt=""Profile Picture"" src=""img/profiles/l-1.jpg""
                                            class=""img-thumbnail border-0 rounded-circle list-thumbnail align-self-center xsmall"" />
                                    </a>
                                    <div cla");
            WriteLiteral(@"ss=""pl-3"">
                                        <a href=""#"">
                                            <p class=""font-weight-medium mb-0"">مطلبی که گذاشتی خیلی مفید بود مرسی</p>
                                            <p class=""text-muted mb-0 text-small"">مطهره تقوی | کیک چای با تکه های پرتغال | 17 آذر 1399 - 04:45</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""d-flex flex-row mb-3 pb-3 border-bottom"">
                                    <a href=""#"">
                                        <img alt=""Profile Picture"" src=""img/profiles/l-7.jpg""
                                            class=""img-thumbnail border-0 rounded-circle list-thumbnail align-self-center xsmall"" />
                                    </a>
                                    <div class=""pl-3"">
                                        <a href=""#"">
                                            <p class=""fon");
            WriteLiteral(@"t-weight-medium mb-0"">از خوندن این مقاله ات خیلی لذت بردم. لطفا همینطور ادامه بده</p>
                                            <p class=""text-muted mb-0 text-small"">فاطمه محمدزاده | چیزکیک با کوکی های شکلاتی | 15 آبان 1399 - 01:18</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""d-flex flex-row mb-3 pb-3 border-bottom"">
                                    <a href=""#"">
                                        <img alt=""Profile Picture"" src=""img/profiles/l-6.jpg""
                                            class=""img-thumbnail border-0 rounded-circle list-thumbnail align-self-center xsmall"" />
                                    </a>
                                    <div class=""pl-3"">
                                        <a href=""#"">
                                            <p class=""font-weight-medium mb-0"">ببین خیلی خسته شدیم از بس مطالب تکراری گذاشتی! یکم خلاق باش</p>
     ");
            WriteLiteral(@"                                       <p class=""text-muted mb-0 text-small"">مهتاب شعبانی | کیک های خونگی | 26 مهر 1399 - 11:14</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""d-flex flex-row mb-3 pb-3 border-bottom"">
                                    <a href=""#"">
                                        <img alt=""Profile Picture"" src=""img/profiles/l-3.jpg""
                                            class=""img-thumbnail border-0 rounded-circle list-thumbnail align-self-center xsmall"" />
                                    </a>
                                    <div class=""pl-3"">
                                        <a href=""#"">
                                            <p class=""font-weight-medium mb-0"">منم اینو امتحان کردم و بچه هام خیلی دوست داشتن!</p>
                                            <p class=""text-muted mb-0 text-small"">نرگس مهاجری | کیک چای با تکه های پرتغال |");
            WriteLiteral(@" 17 شهریور 1399 - 09:20</p>
                                        </a>
                                    </div>
                                </div>
                                <div class=""d-flex flex-row mb-3 pb-3 border-bottom"">
                                    <a href=""#"">
                                        <img alt=""Profile Picture"" src=""img/profiles/l-5.jpg""
                                            class=""img-thumbnail border-0 rounded-circle list-thumbnail align-self-center xsmall"" />
                                    </a>
                                    <div class=""pl-3"">
                                        <a href=""#"">
                                            <p class=""font-weight-medium mb-0"">خواندن این مقاله بسیار لذت بخش بود. لطفا آنها را ادامه دهید.</p>
                                            <p class=""text-muted mb-0 text-small"">مریم رضایی | چیزکیک با توت تازه | 16 شهریور 1399 - 16:45</p>
                                        </a>
                          ");
            WriteLiteral(@"          </div>
                                </div>
                                <div class=""d-flex flex-row mb-3 pb-3 border-bottom"">
                                    <a href=""#"">
                                        <img alt=""Profile Picture"" src=""img/profiles/l-4.jpg""
                                            class=""img-thumbnail border-0 rounded-circle list-thumbnail align-self-center xsmall"" />
                                    </a>
                                    <div class=""pl-3"">
                                        <a href=""#"">
                                            <p class=""font-weight-medium mb-0"">جالب نبود اصلا! مزش عجیبه</p>
                                            <p class=""text-muted mb-0 text-small"">بنیامین امینی | 27 مهر 1399 - 15:00</p>
                                        </a>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
      ");
            WriteLiteral("          </div>\n            </div>\n\n\n\n\n\n        </div>\n    </main>");
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

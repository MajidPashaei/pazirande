#pragma checksum "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7659d4a72c4471eb03f7c533f1a927d7980a87"
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
#line 1 "d:\nikatak\pazirande git\pazirande\hampadco\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "d:\nikatak\pazirande git\pazirande\hampadco\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc7659d4a72c4471eb03f7c533f1a927d7980a87", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab99064084068b19349a35efc6c15a1d282f4711", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModelLayer.Portal.VM_Support>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rows", new global::Microsoft.AspNetCore.Html.HtmlString("3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("label", new global::Microsoft.AspNetCore.Html.HtmlString("&nbsp;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2-single"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-width", new global::Microsoft.AspNetCore.Html.HtmlString("100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/SetSupport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "کارتابل شخصی";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
            WriteLiteral(@"                            <div class=""glide__track"" data-glide-el=""track"">
                                <ul class=""glide__slides"">
                                    <li class=""glide__slide"">
                                        <a href=""/Account/NewAccount"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-add-user""></i>
                                                <p class=""card-text mb-0"">کاربر جدید</p>

                                            </div>
                                        </a>
                                    </li>
                                    <li class=""glide__slide"">
                                        <a href=""/Account/Account"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-mens""></i>
                                ");
            WriteLiteral(@"                <p class=""card-text mb-0"">کاربران ثبت شده</p>
                                            
                                            </div>
                                        </a>
                                    </li>
                                    <li class=""glide__slide"">
                                        <a href=""/Account/SearchToUpload"" class=""card"">
                                            <div class=""card-body text-center"">
                                                <i class=""iconsminds-male mr-2 text-grey align-text-bottom d-inline-block""></i>
                                                <p class=""card-text mb-0"">آپلود مدارک کاربر</p>
                                        
                                            </div>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div");
            WriteLiteral(@">

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8711013", async() => {
                WriteLiteral("\r\n                                <div class=\"form-group row\">\r\n                                    <label class=\"col-sm-3 col-form-label\">عنوان</label>\r\n                                    <div class=\"col-sm-9\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cc7659d4a72c4471eb03f7c533f1a927d7980a8711536", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 81 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                                <div class=""form-group row"">
                                    <label class=""col-sm-3 col-form-label"">محتوا</label>
                                    <div class=""col-sm-9"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8713741", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 87 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                                <div class=""form-group row"">
                                    <label class=""col-sm-3 col-form-label"">مجموعه</label>
                                    <div class=""col-sm-9"">
                                        <label class=""w-100"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8715829", async() => {
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8716146", async() => {
                        WriteLiteral("&nbsp;");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8717356", async() => {
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
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8718472", async() => {
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
                    WriteLiteral("\r\n                                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc7659d4a72c4471eb03f7c533f1a927d7980a8719591", async() => {
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
                    WriteLiteral("\r\n                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 94 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.To);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </label>
                                    </div>
                                </div>

                                <div class=""form-group row mb-0"">
                                    <div class=""col-sm-12"">
                                        <button type=""submit"" class=""btn btn-primary float-right"">ارسال</button>
                                    </div>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
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
                                        <th>شماره تماس</th>

                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 132 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                         if (ViewBag.All != null)
                            {
                               
                                foreach (var item in ViewBag.All)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <p class=\"list-item-heading\">");
#nullable restore
#line 139 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                                                    Write(item.Name_fa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td>\r\n                                            <p class=\"text-muted\">");
#nullable restore
#line 142 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                                             Write(item.Family_fa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                         <td>\r\n                                            <p class=\"text-muted\">");
#nullable restore
#line 145 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                                             Write(item.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 148 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                              
                                </tbody>
                            </table>
                        </div>
                    </div>



                </div>
            </div>




  
        
        <div class=""row"">
            <div class=""col-lg-6"">
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
                        </di");
            WriteLiteral(@"v>
                    </div>
                </a>
            </div>
            <div class=""col-lg-6"">
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
");
            WriteLiteral("        </div>\r\n\r\n\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 229 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                 if (ViewBag.A != null)
                            {
                               

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4"">
                    <a href=""/Pazirande/wait"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-sand-watch-2 text-white""></i>
                          
                               
                                <div>
                                    <p class=""lead text-white"">");
#nullable restore
#line 241 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                                          Write(ViewBag.A);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" پذیرنده</p>
                                    <p class=""text-small text-white"">درانتظار تایید است</p>
                                </div>
                                
                                
                            </div>

                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)""");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 11947, "\"", 11974, 2);
#nullable restore
#line 251 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
WriteAttributeValue("", 11963, ViewBag.A, 11963, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 11973, "", 11974, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuemax", " aria-valuemax=\"", 11975, "\"", 12004, 1);
#nullable restore
#line 251 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
WriteAttributeValue("", 11991, ViewBag.koli, 11991, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-show-percent=\"false\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div></a>\r\n                </div>\r\n");
#nullable restore
#line 258 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 259 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                 if (ViewBag.B != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4"">
                    <a href=""/Pazirande/Ok"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-big-data text-white""></i>
                            
                              
                                <div>
                                    <p class=""lead text-white"">");
#nullable restore
#line 270 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                                          Write(ViewBag.B);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" پذیرنده</p>
                                    <p class=""text-small text-white"">تایید شده است</p>
                                </div>
                           
                            </div>
                            <div>
                                <div  role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)""");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 13356, "\"", 13383, 2);
#nullable restore
#line 278 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
WriteAttributeValue("", 13372, ViewBag.B, 13372, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 13382, "", 13383, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuemax", " aria-valuemax=\"", 13384, "\"", 13413, 1);
#nullable restore
#line 278 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
WriteAttributeValue("", 13400, ViewBag.koli, 13400, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-show-percent=\"false\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 286 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 287 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                 if (ViewBag.C != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4"">
                    <a href=""/Pazirande/No"">
                    <div class=""card mb-4 progress-banner"">
                        <div class=""card-body justify-content-between d-flex flex-row align-items-center"">
                            <div>
                                <i class=""iconsminds-unlike text-white""></i>
                            
                                <div>
                                    <p class=""lead text-white"">");
#nullable restore
#line 297 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                                                          Write(ViewBag.C);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" پذیرنده</p>
                                    <p class=""text-small text-white"">عدم تایی شده است</p>
                                </div>
                            
                            </div>
                            <div>
                                <div role=""progressbar""
                                    class=""progress-bar-circle progress-bar-banner position-relative"" data-color=""white""
                                    data-trail-color=""rgba(255,255,255,0.2)""");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 14756, "\"", 14782, 1);
#nullable restore
#line 305 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
WriteAttributeValue("", 14772, ViewBag.C, 14772, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuemax", " aria-valuemax=\"", 14783, "\"", 14812, 1);
#nullable restore
#line 305 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
WriteAttributeValue("", 14799, ViewBag.koli, 14799, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                    data-show-percent=\"false\">\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    </a>\r\n                </div>\r\n");
#nullable restore
#line 313 "d:\nikatak\pazirande git\pazirande\hampadco\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        </div>\r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModelLayer.Portal.VM_Support> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f87057f8e00881a402600e712e7779993932ba74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_AllPaZirandeh), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/AllPaZirandeh.cshtml")]
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
#line 1 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f87057f8e00881a402600e712e7779993932ba74", @"/Areas/Admin/Views/Home/AllPaZirandeh.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab99064084068b19349a35efc6c15a1d282f4711", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_AllPaZirandeh : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
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
                        <li class=""breadcrumb-item active"" aria-current=""page"">ترمینال های ثبت شده </li>
                    </ol>
                </nav>
                <div class=""separator mb-5""></div>


            </div>
        </div>
        <div class=""row"">
            <div class=""container-fluid"">
                <div class=""card mb-4"">
                    <div class=""card-body"">
                    <div class=""mb-2"">
                        <a class=""btn pt-0 pl-0 d-inline-block d-md-none"" data-toggle=""collapse"" href=""#displayOptions""
                            ro");
            WriteLiteral(@"le=""button"" aria-expanded=""true"" aria-controls=""displayOptions"">
                            نمایش گزینه ها
                            <i class=""simple-icon-arrow-down align-middle""></i>
                        </a>
                        <div class=""collapse dont-collapse-sm"" id=""displayOptions"">
                            <div class=""d-block d-md-inline-block"">
                                <div class=""search-sm d-inline-block float-md-left mr-1 mb-1 align-top"">
                                    <input class=""form-control"" type=""text"" id=""searchArticles"" onkeyup=""searchArticles()"" placeholder=""Search Table"">
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""separator""></div>
                       
            <div class=""row"">
                <div class=""col-12 mb-4 data-table-rows data-tables-hide-filter"">
                    <table id=""articles"" class=""container-fluid r");
            WriteLiteral(@"esponsive  nowrap"">
                        <thead>
                            <tr>
                                <th>ردیف</th>
                                <th>نام</th>
                                <th>نام خانوادگی</th>
                                <th>کد ملی</th>
                                <th>نوع مشتری</th>
");
            WriteLiteral("                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 55 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
                             if (ViewBag.R != null)
                            {
                                int i=1;
                                foreach (var item in ViewBag.R)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <p class=\"list-item-heading\">");
#nullable restore
#line 62 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
                                                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td>\r\n                                            <p class=\"text-muted\">");
#nullable restore
#line 65 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td>\r\n                                            <p class=\"text-muted\">");
#nullable restore
#line 68 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
                                                             Write(item.Family);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n                                        <td>\r\n                                            <p class=\"text-muted\">");
#nullable restore
#line 71 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
                                                             Write(item.Code_Meli);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                                        </td>\r\n                                        <td>\r\n                                            <p class=\"text-muted\">");
#nullable restore
#line 74 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
                                                             Write(item.Type_Moshtari);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </td>\r\n");
            WriteLiteral("                                    </tr>\r\n");
#nullable restore
#line 80 "c:\Users\nikatak-4\Desktop\pazirande\hampadco\Areas\Admin\Views\Home\AllPaZirandeh.cshtml"
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
            </div>
        </div>
    </div>
</main>

<script>
function searchArticles() {
    search('searchArticles', 'articles');
}
    
function search(searchInput, searchTable) {
    // Declare variables
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById(searchInput);
    filter = input.value.toUpperCase();
    table = document.getElementById(searchTable);
    tr = table.getElementsByTagName(""tr"");
    
    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
        td = tr[i].getElementsByTagName(""td"")[0];
        if (td) {
            txtValue = td.textContent || td.innerText;
            if (txtValue.toUpperCase().indexOf(filter) > -1) {
                tr[i].style.display = """";
           ");
            WriteLiteral(" } else {\r\n                tr[i].style.display = \"none\";\r\n            }\r\n        }\r\n    }\r\n}\r\n</script>");
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

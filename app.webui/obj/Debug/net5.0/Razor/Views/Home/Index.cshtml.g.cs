#pragma checksum "C:\app\app.webui\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c34626e2eef631290cb0067bafb9324fb87941e"
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
#line 1 "C:\app\app.webui\Views\_ViewImports.cshtml"
using app.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\app\app.webui\Views\_ViewImports.cshtml"
using app.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\app\app.webui\Views\_ViewImports.cshtml"
using app.webui.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\app\app.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\app\app.webui\Views\_ViewImports.cshtml"
using app.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c34626e2eef631290cb0067bafb9324fb87941e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd22a74efb2519bc3ce777bdaf0683be681d1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\app\app.webui\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\app\app.webui\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\app\app.webui\Views\Home\Index.cshtml"
Write(await Html.PartialAsync("_headerTwo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row ms-5 mt-5\">\n    <div class=\"col-md-12\">\n       <div class=\"row\">\n");
#nullable restore
#line 8 "C:\app\app.webui\Views\Home\Index.cshtml"
            foreach (var item in Model.Products)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <div class=\"col-md-3\">\n                   ");
#nullable restore
#line 11 "C:\app\app.webui\Views\Home\Index.cshtml"
              Write(await Html.PartialAsync("_products", item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n               </div>\n");
#nullable restore
#line 13 "C:\app\app.webui\Views\Home\Index.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("       </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

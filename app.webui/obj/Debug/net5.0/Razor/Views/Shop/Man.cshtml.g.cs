#pragma checksum "C:\app\app.webui\Views\Shop\Man.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c0d40727dbd93e917ae7b57068474c160aee166"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Man), @"mvc.1.0.view", @"/Views/Shop/Man.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c0d40727dbd93e917ae7b57068474c160aee166", @"/Views/Shop/Man.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd22a74efb2519bc3ce777bdaf0683be681d1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Man : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "C:\app\app.webui\Views\Shop\Man.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 5 "C:\app\app.webui\Views\Shop\Man.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\app\app.webui\Views\Shop\Man.cshtml"
Write(await Html.PartialAsync("_headerTwo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row ms-5 mt-3\">\n    <div class=\"col-md-2 p-3 mt-4 column border\">\n        <h5");
            BeginWriteAttribute("class", " class=\"", 222, "\"", 230, 0);
            EndWriteAttribute();
            WriteLiteral(">İlgili Kategoriler</h5>\n        \n        <hr>\n        <h5>Fırsat Ürünleri</h5>\n        <div class=\"form-check\">\n            <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 403, "\"", 411, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 412, "\"", 417, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 20px;\" height=\"50px;\">\n            <label class=\"form-check-label ms-2 k\"");
            BeginWriteAttribute("for", " for=\"", 506, "\"", 512, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                Fırsat Ürünleri\n            </label>\n        </div>\n        <div class=\"form-check\">\n            <input class=\"form-check-input\" type=\"checkbox\"");
            BeginWriteAttribute("value", " value=\"", 675, "\"", 683, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 684, "\"", 689, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""width: 20px;"" height=""50px;"">
            <label class=""form-check-label ms-2 k"" for=""flexCheckCheckedDisabled"">
                Büyük Fırsat Ürünleri
            </label>
        </div>
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 977, "\"", 985, 0);
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 986, "\"", 991, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 20px;\" height=\"50px;\">\n            <label class=\"form-check-label ms-2 k\"");
            BeginWriteAttribute("for", " for=\"", 1080, "\"", 1086, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                Çılgın Fırsat Ürünleri\n            </label>\n        </div>\n        <hr>\n        <h5 class=\"mb-3\">Kategoriler</h5>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c0d40727dbd93e917ae7b57068474c160aee1667019", async() => {
                WriteLiteral("\n            <input id=\"formin\" type=\"text\" class=\"form-control\" style=\"width: 240px;\" placeholder=\"Marka ara\">\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <div class=\"mt-2\">\n            ");
#nullable restore
#line 37 "C:\app\app.webui\Views\Shop\Man.cshtml"
       Write(await Component.InvokeAsync("Categories"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"col-md-10\">\n        <div class=\"row\">\n            <div class=\"col-md-6\">\n                <span class=\"c\">\"Erkek Ayakkabı\" araması için toplam ");
#nullable restore
#line 43 "C:\app\app.webui\Views\Shop\Man.cshtml"
                                                                Write(Model.TotalCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" sonuc listeleniyor</span>
            </div>
            <div class=""col-md-6"">
                <div class=""dropdown d-flex justify-content-end"">
                    <a style=""color: black;"" class=""nav-link dropdown-toggle"" href=""#"" role=""button"" id=""dropdownMenuLink"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                       Önerilenler
                    </a>

                    <ul class=""dropdown-menu border"" aria-labelledby=""dropdownMenuLink"">
                        <li><a class=""dropdown-item c"" href=""/shop/decending"">En Yüksek Fiyat</a></li>
                        <li><a class=""dropdown-item c"" href=""/shop/Acending"">En Düşük Fiyat</a></li>
                        
                    </ul>
                </div>                       
            </div>  
            <div class=""row"">
");
#nullable restore
#line 59 "C:\app\app.webui\Views\Shop\Man.cshtml"
                         foreach (var item in Model.Products)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-3 mb-4 \">\n                                ");
#nullable restore
#line 62 "C:\app\app.webui\Views\Shop\Man.cshtml"
                           Write(await Html.PartialAsync("_products",item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </div>\n");
#nullable restore
#line 64 "C:\app\app.webui\Views\Shop\Man.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div> \n        </div>\n    </div>\n</div>\n\n");
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

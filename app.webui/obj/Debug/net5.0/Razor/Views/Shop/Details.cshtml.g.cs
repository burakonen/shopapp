#pragma checksum "C:\app\app.webui\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571a1638fc32a8585097efc569bc0f66a195a2a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571a1638fc32a8585097efc569bc0f66a195a2a0", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd22a74efb2519bc3ce777bdaf0683be681d1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:650px; width:100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/shop/comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("border p-4 formStyle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\app\app.webui\Views\Shop\Details.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\app\app.webui\Views\Shop\Details.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\app\app.webui\Views\Shop\Details.cshtml"
Write(await Html.PartialAsync("_headerTwo"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row mb-5 d-flex justify-content-center\">\r\n                <div class=\"col-md-5 border detailsShadow\" style=\"height:650px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "571a1638fc32a8585097efc569bc0f66a195a2a06229", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 310, "~/img/", 310, 6, true);
#nullable restore
#line 8 "C:\app\app.webui\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 316, Model.Product.Image, 316, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-6 border detailsShadow\">\r\n");
            WriteLiteral("                        <span style=\"font-size: 20px;\" class=\"card-text ms-1\"><a");
            BeginWriteAttribute("href", " href=\"", 704, "\"", 711, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: gray;\">");
#nullable restore
#line 12 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                                                                                         Write(Model.Product.MansCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ></a></span> \r\n                        <span style=\"font-size: 20px;\" class=\"card-text ms-1\"><a");
            BeginWriteAttribute("href", " href=\"", 862, "\"", 869, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color: gray;\">");
#nullable restore
#line 13 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                                                                                         Write(Model.Product.MansBrands.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > </a></span> \r\n                        <p><a");
            BeginWriteAttribute("href", " href=\"", 968, "\"", 975, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"color:gray;\">");
#nullable restore
#line 14 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                                     Write(Model.totalCommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Soru & Cevap</a></p>\r\n                        <h2 class=\"card-title mt-4 mb-2\">");
#nullable restore
#line 15 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                                    Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <hr>\r\n                        <h3 class=\"card-title\">");
#nullable restore
#line 17 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                          Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" TL</h3>
                        <hr>
                        <div class=""d-grid gap-2"">
                            <button class=""btn btn-warning"" type=""submit"">Sepete Ekle</button>
                        </div>
                        <p class=""text-left"">Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sapiente incidunt mollitia vero commodi, harum, repellendus similique ex corrupti consequuntur quos unde maxime sed magni nam. Suscipit ab nihil qui harum.
                        A reprehenderit omnis deserunt inventore earum. Tenetur itaque voluptas alias modi perspiciatis numquam consequuntur officia neque illum fugiat consectetur molestiae incidunt iste, cupiditate perferendis, ab molestias dolor saepe minus? Quisquam?
                        Sed magnam quia reprehenderit ad voluptatem odit ut quae amet similique, enim accusantium libero dolore commodi nostrum iure aliquid dolor unde ipsa. Molestias excepturi facere saepe quod, cupiditate ipsum blanditiis.
                        Nam d");
            WriteLiteral(@"olorum pariatur libero est. Doloribus nemo, optio aut commodi eveniet maiores illum placeat a asperiores quae mollitia blanditiis ea dolorum aspernatur. Harum tenetur eius quo quasi ipsam, repudiandae quas.
                        A delectus nulla, animi at officiis ipsam, exercitationem et assumenda blanditiis neque doloremque ducimus velit fuga? Quis, incidunt, reprehenderit nemo aliquam omnis quasi ullam illo at quod facere obcaecati porro!</p>
                </div>    
</div>


<div class=""row mt-3 mb-5 d-flex justify-content-center"">
    <div class=""col-md-11"">
        <h2 class=""mb-4"">Ürün Değerlendirmesi</h2>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571a1638fc32a8585097efc569bc0f66a195a2a011869", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"ProductId\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3034, "\"", 3059, 1);
#nullable restore
#line 35 "C:\app\app.webui\Views\Shop\Details.cshtml"
WriteAttributeValue("", 3042, Model.Product.Id, 3042, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n            <input type=\"hidden\" name=\"Date\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3128, "\"", 3149, 1);
#nullable restore
#line 36 "C:\app\app.webui\Views\Shop\Details.cshtml"
WriteAttributeValue("", 3136, DateTime.Now, 3136, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
            <div class=""mb-4"">
                <input type=""text"" class=""form-control mb-2"" placeholder=""Adınız"" name=""Name"">
            </div>
             <div class=""mb-4"">
                <input type=""email"" class=""form-control mb-2"" placeholder=""Email Adresiniz"" name=""Email"">
            </div>
            <div class=""mb-3"">
                <textarea name=""Post""");
                BeginWriteAttribute("id", " id=\"", 3530, "\"", 3535, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Yorumunuz\" class=\"form-control\" cols=\"30\" rows=\"10\"></textarea>\r\n            </div>\r\n            <button class=\"btn btn-warning mt-3\" type=\"submit\">Gönder</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row d-flex justify-content-center\">\r\n    <div class=\"col-md-11\">\r\n        <div class=\"d-flex justify-content-center mt-2 mb-2\">\r\n            <h2 class=\"text-muted\">");
#nullable restore
#line 55 "C:\app\app.webui\Views\Shop\Details.cshtml"
                              Write(Model.totalCommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Yorum</h2>\r\n        </div>\r\n");
#nullable restore
#line 57 "C:\app\app.webui\Views\Shop\Details.cshtml"
         foreach (var item in Model.Comments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"card mb-2\">\r\n               <div class=\"card-body\">\r\n                    <p class=\"card-text\">");
#nullable restore
#line 61 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                    Write(item.Post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n               </div>\r\n               <div class=\"card-footer border-0\" style=\"background-color: white;\">\r\n                  <div>\r\n                     <span class=\"text-muted\">");
#nullable restore
#line 65 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> |\r\n                     <span class=\"text-muted\">");
#nullable restore
#line 66 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                         Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                     <div class=\"float-end like\">\r\n                       <a");
            BeginWriteAttribute("href", " href=\"", 4516, "\"", 4542, 2);
            WriteAttributeValue("", 4523, "/shop/like/", 4523, 11, true);
#nullable restore
#line 68 "C:\app\app.webui\Views\Shop\Details.cshtml"
WriteAttributeValue("", 4534, item.Id, 4534, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"like\" style=\"text-decoration:none;\"><i class=\"fas fa-thumbs-up me-2\"></i>Yorumu Beğen (");
#nullable restore
#line 68 "C:\app\app.webui\Views\Shop\Details.cshtml"
                                                                                                                                              Write(item.Like);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n                   </div>\r\n                  </div>\r\n               </div>\r\n           </div>\r\n");
#nullable restore
#line 73 "C:\app\app.webui\Views\Shop\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

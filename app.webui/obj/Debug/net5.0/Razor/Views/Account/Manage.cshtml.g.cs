#pragma checksum "C:\app\app.webui\Views\Account\Manage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a60ddfbf0fe4440ce8b3949b3d2430062c4d05e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Manage), @"mvc.1.0.view", @"/Views/Account/Manage.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a60ddfbf0fe4440ce8b3949b3d2430062c4d05e", @"/Views/Account/Manage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd22a74efb2519bc3ce777bdaf0683be681d1a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Manage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModelManage>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\app\app.webui\Views\Account\Manage.cshtml"
Write(await Html.PartialAsync("_header"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\app\app.webui\Views\Account\Manage.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\app\app.webui\Views\Account\Manage.cshtml"
Write(await Html.PartialAsync("_headerTwo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-4"">
           <div class=""card"">
               <div class=""card-header"">
                   <h2 style=""font-size:17px;"">Kullancı Bilgileri</h2>
               </div>
               <div class=""card-body p-3"">
                   <ul class=""list-group list-group-flush"">
                       <li class=""list-group-item""><h5");
            BeginWriteAttribute("class", " class=\"", 555, "\"", 563, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-size: 14px;\">Kullancı Adı: ");
#nullable restore
#line 16 "C:\app\app.webui\Views\Account\Manage.cshtml"
                                                                                                  Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n                       <li class=\"list-group-item\"><h5 style=\"font-size: 14px;\">Adı: ");
#nullable restore
#line 17 "C:\app\app.webui\Views\Account\Manage.cshtml"
                                                                                Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n                       <li class=\"list-group-item\"><h5 style=\"font-size: 14px;\">Soyadı: ");
#nullable restore
#line 18 "C:\app\app.webui\Views\Account\Manage.cshtml"
                                                                                   Write(Model.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n                       <li class=\"list-group-item\"><h5 style=\"font-size: 14px;\">E-Posta: ");
#nullable restore
#line 19 "C:\app\app.webui\Views\Account\Manage.cshtml"
                                                                                    Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n                       <li class=\"list-group-item\"><h5 style=\"font-size: 14px;\">E-Posta Onaylandı mı?: \r\n");
#nullable restore
#line 21 "C:\app\app.webui\Views\Account\Manage.cshtml"
                            if(@Model.IsEmailConfirm)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-check-circle\"></i>\r\n");
#nullable restore
#line 24 "C:\app\app.webui\Views\Account\Manage.cshtml"
                           }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <i class=\"fas fa-times-circle\"></i>\r\n");
#nullable restore
#line 26 "C:\app\app.webui\Views\Account\Manage.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral("                       </h5></li>\r\n                       <li class=\"list-group-item\"><h5 style=\"font-size: 14px;\">Cep Telefonu: ");
#nullable restore
#line 28 "C:\app\app.webui\Views\Account\Manage.cshtml"
                                                                                         Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></li>\r\n                   </ul>\r\n               </div>\r\n           </div>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1606, "\"", 1613, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btnUser mt-2\">Bilgileri Düzenle</a>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModelManage> Html { get; private set; }
    }
}
#pragma warning restore 1591

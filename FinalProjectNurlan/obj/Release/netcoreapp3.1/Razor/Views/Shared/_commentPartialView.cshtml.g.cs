#pragma checksum "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c2bf94a0b23dce3867386dce0f6fcf1adce4d01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__commentPartialView), @"mvc.1.0.view", @"/Views/Shared/_commentPartialView.cshtml")]
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
#line 1 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\_ViewImports.cshtml"
using FinalProjectNurlan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\_ViewImports.cshtml"
using FinalProjectNurlan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\_ViewImports.cshtml"
using FinalProjectNurlan.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2bf94a0b23dce3867386dce0f6fcf1adce4d01", @"/Views/Shared/_commentPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17ee9c7b284202d872561ba3ab9135afecafa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__commentPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
 foreach (var item in Model.Comments.OrderByDescending(p=>p.CreatedTime))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"review\">\r\n        <div class=\"row no-gutters\">\r\n            <div class=\"col-auto\">\r\n                <h4><a href=\"#\">");
#nullable restore
#line 7 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
                           Write(item.AppUser.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n\r\n                <div class=\"rating\">\r\n");
#nullable restore
#line 10 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
                     for (int i = 0; i < item.Star; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i style=\"color:#c94\" class=\"fa-solid fa-star\"></i>\r\n");
#nullable restore
#line 13 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
                     for (int i = 0; i < (5 - item.Star); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i class=\"fa-solid fa-star\"></i>\r\n");
#nullable restore
#line 18 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
                        
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <span class=\"review-date\">");
#nullable restore
#line 22 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
                                     Write(item.CreatedTime.ToString("MM dd yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div class=\"col\">\r\n                <h4>");
#nullable restore
#line 25 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n                <div class=\"review-content\">\r\n                    <p>");
#nullable restore
#line 28 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"
                  Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_commentPartialView.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
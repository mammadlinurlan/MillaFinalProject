#pragma checksum "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2996f69d987b1065603c480972a7746461ea532a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__blogCommentPartial), @"mvc.1.0.view", @"/Views/Shared/_blogCommentPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2996f69d987b1065603c480972a7746461ea532a", @"/Views/Shared/_blogCommentPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17ee9c7b284202d872561ba3ab9135afecafa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__blogCommentPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml"
 foreach (var item in Model.Blog.Comments.Where(c=>c.IsAccepted == true))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>\r\n\r\n        <div class=\"comment\">\r\n\r\n\r\n            <div class=\"comment-body\">\r\n\r\n                <div class=\"comment-user\">\r\n                    <h4><p>");
#nullable restore
#line 12 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml"
                      Write(item.AppUser.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 12 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml"
                                               Write(item.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></h4>\r\n                    <span class=\"comment-date\">");
#nullable restore
#line 13 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml"
                                          Write(item.CreatedTime.ToString("dd MMMM yyyy , HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n\r\n                <div class=\"comment-content\">\r\n                    <p>");
#nullable restore
#line 17 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml"
                  Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </li>\r\n");
#nullable restore
#line 23 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Shared\_blogCommentPartial.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

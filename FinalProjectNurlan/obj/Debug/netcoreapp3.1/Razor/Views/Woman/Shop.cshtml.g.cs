#pragma checksum "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6c048b4720d6fd5dc7cabfd6c83d6ea4785a97c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Woman_Shop), @"mvc.1.0.view", @"/Views/Woman/Shop.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6c048b4720d6fd5dc7cabfd6c83d6ea4785a97c", @"/Views/Woman/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17ee9c7b284202d872561ba3ab9135afecafa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Woman_Shop : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "woman", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "popularity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "rating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "date", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('~/assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">List<span>Shop</span></h1>
        </div><!-- End .container -->
    </div><!-- End .page-header -->
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav mb-2"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c048b4720d6fd5dc7cabfd6c83d6ea4785a97c5805", async() => {
                WriteLiteral("Women");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n\r\n                <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 13 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                                                  Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->

    <div class=""page-content"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <div class=""toolbox"">
                        <div class=""toolbox-left"">
                            <div class=""toolbox-info"">
                                Showing <span>9 of 56</span> Products
                            </div><!-- End .toolbox-info -->
                        </div><!-- End .toolbox-left -->

                        <div class=""toolbox-right"">
                            <div class=""toolbox-sort"">
                                <label for=""sortby"">Sort by:</label>
                                <div class=""select-custom"">
                                    <select name=""sortby"" id=""sortby"" class=""form-control"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c048b4720d6fd5dc7cabfd6c83d6ea4785a97c8537", async() => {
                WriteLiteral("Most Popular");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c048b4720d6fd5dc7cabfd6c83d6ea4785a97c9825", async() => {
                WriteLiteral("Most Rated");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c048b4720d6fd5dc7cabfd6c83d6ea4785a97c11028", async() => {
                WriteLiteral("Date");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </select>
                                </div>
                            </div><!-- End .toolbox-sort -->
                            <div class=""toolbox-layout"">
                                <a href=""category-list.html"" class=""btn-layout"">
                                    <svg width=""16"" height=""10"">
                                        <rect x=""0"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""0"" width=""10"" height=""4"" />
                                        <rect x=""0"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""6"" width=""10"" height=""4"" />
                                    </svg>
                                </a>

                                <a href=""category-2cols.html"" class=""btn-layout"">
                                    <svg width=""10"" height=""10"">
                                        <rect x=""0"" y=""0"" width=""4"" height=""4"" />
                 ");
            WriteLiteral(@"                       <rect x=""6"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""0"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""6"" width=""4"" height=""4"" />
                                    </svg>
                                </a>

                                <a href=""category.html"" class=""btn-layout active"">
                                    <svg width=""16"" height=""10"">
                                        <rect x=""0"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""12"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""0"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""12"" y=""6"" width=""4"" height=""4"" />
                                    </svg>
              ");
            WriteLiteral(@"                  </a>

                                <a href=""category-4cols.html"" class=""btn-layout"">
                                    <svg width=""22"" height=""10"">
                                        <rect x=""0"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""12"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""18"" y=""0"" width=""4"" height=""4"" />
                                        <rect x=""0"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""6"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""12"" y=""6"" width=""4"" height=""4"" />
                                        <rect x=""18"" y=""6"" width=""4"" height=""4"" />
                                    </svg>
                                </a>
                            </div>
                        </div><!-- End .toolbox-right -->
    ");
            WriteLiteral("                </div><!-- End .toolbox -->\r\n\r\n                    <div class=\"products mb-3\">\r\n                        <div class=\"row\">\r\n\r\n                            ");
#nullable restore
#line 89 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                       Write(await Html.PartialAsync("_productPartialView", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n                    <nav aria-label=\"Page navigation\">\r\n                        <ul class=\"pagination justify-content-center\">\r\n");
            WriteLiteral(@"


                            <a href=""#"" id=""loadMore"" style=""max-width: 18%; background-color: #c96; color: white;"" class=""btn-product"">
                                Load more
                            </a>



                        </ul>
                    </nav>
                </div><!-- End .col-lg-9 -->

                <aside class=""col-lg-3 order-lg-first"">
                    <div class=""sidebar sidebar-shop"">
                        <div class=""widget widget-clean"">
                            <label>Filters:</label>
                            <a href=""#"" class=""sidebar-filter-clear"">Clean All</a>
                        </div><!-- End .widget widget-clean -->

                        <div class=""widget widget-collapsible"">
                            <h3 class=""widget-title"">
                                <a data-toggle=""collapse"" href=""#widget-1"" role=""button"" aria-expanded=""true"" aria-controls=""widget-1"">
                                    Category
           ");
            WriteLiteral(@"                     </a>
                            </h3><!-- End .widget-title -->

                            <div class=""collapse show"" id=""widget-1"">
                                <div class=""widget-body"">
                                    <div class=""filter-items filter-items-count"">
");
#nullable restore
#line 234 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                         foreach (var item in Model.Category.SubCategories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"filter-item\">\r\n                                                <div class=\"custom-control custom-checkbox\">\r\n                                                    <input");
            BeginWriteAttribute("value", " value=\"", 13397, "\"", 13413, 1);
#nullable restore
#line 238 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 13405, item.Id, 13405, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" class=\"custom-control-input categoryCheck\"");
            BeginWriteAttribute("id", " id=\"", 13473, "\"", 13486, 1);
#nullable restore
#line 238 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 13478, item.Id, 13478, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <label class=\"custom-control-label\" >");
#nullable restore
#line 239 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                                                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 242 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        <!-- End .filter-item -->
                                    </div><!-- End .filter-items -->
                                </div><!-- End .widget-body -->
                            </div><!-- End .collapse -->
                        </div><!-- End .widget -->





                        <div class=""widget widget-collapsible"">
                            <h3 class=""widget-title"">
                                <a data-toggle=""collapse"" href=""#widget-2"" role=""button"" aria-expanded=""true"" aria-controls=""widget-2"">
                                    Size
                                </a>
                            </h3><!-- End .widget-title -->

                            <div class=""collapse show"" id=""widget-2"">
                                <div class=""widget-body"">
                                    <div class=""filter-items"">
");
#nullable restore
#line 264 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                         for (int i = 0; i < 6; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"filter-item\">\r\n                                                <div class=\"custom-control custom-checkbox\">\r\n\r\n                                                    <input");
            BeginWriteAttribute("value", " value=\"", 15006, "\"", 15034, 1);
#nullable restore
#line 269 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 15014, ViewBag.Sizes[i].Id, 15014, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 15080, "\"", 15107, 1);
#nullable restore
#line 269 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 15085, ViewBag.Sizes[i].Name, 15085, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <label class=\"custom-control-label\" >");
#nullable restore
#line 270 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                                                                    Write(ViewBag.Sizes[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 274 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div><!-- End .filter-items -->
                                </div><!-- End .widget-body -->
                            </div><!-- End .collapse -->
                        </div><!-- End .widget -->

                        <div class=""widget widget-collapsible"">
                            <h3 class=""widget-title"">
                                <a data-toggle=""collapse"" href=""#widget-3"" role=""button"" aria-expanded=""true"" aria-controls=""widget-3"">
                                    Colour
                                </a>
                            </h3><!-- End .widget-title -->

                            <div class=""collapse show"" id=""widget-3"">
                                <div class=""widget-body"">
                                    <div class=""filter-colors"">
");
#nullable restore
#line 291 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                         foreach (var item in ViewBag.Colors)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"colorClick\" href=\"#\"");
            BeginWriteAttribute("style", " style=\"", 16427, "\"", 16458, 3);
            WriteAttributeValue("", 16435, "background:", 16435, 11, true);
#nullable restore
#line 293 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue(" ", 16446, item.Name, 16447, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 16457, ";", 16457, 1, true);
            EndWriteAttribute();
            WriteLiteral("><span class=\"sr-only\">");
#nullable restore
#line 293 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                                                                                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n                                    <input");
            BeginWriteAttribute("value", " value=\"", 16547, "\"", 16563, 1);
#nullable restore
#line 294 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 16555, item.Id, 16555, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" hidden />\r\n");
#nullable restore
#line 295 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div><!-- End .filter-colors -->
                                </div><!-- End .widget-body -->
                            </div><!-- End .collapse -->
                        </div><!-- End .widget -->

                        <div class=""widget widget-collapsible"">
                            <h3 class=""widget-title"">
                                <a data-toggle=""collapse"" href=""#widget-4"" role=""button"" aria-expanded=""true"" aria-controls=""widget-4"">
                                    Brand
                                </a>
                            </h3><!-- End .widget-title -->

                            <div class=""collapse show"" id=""widget-4"">
                                <div class=""widget-body"">
                                    <div class=""filter-items"">

");
#nullable restore
#line 313 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                         foreach (Brand item in Model.Brands)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""filter-item"">
                                                <div class=""custom-control custom-checkbox"">
                                                    <input type=""checkbox"" class=""custom-control-input filtercheck""");
            BeginWriteAttribute("value", " value=\"", 17868, "\"", 17884, 1);
#nullable restore
#line 317 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 17876, item.Id, 17876, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 17885, "\"", 17898, 1);
#nullable restore
#line 317 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
WriteAttributeValue("", 17890, item.Id, 17890, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <label class=\"custom-control-label\" >");
#nullable restore
#line 318 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                                                                    Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.Name.ToLower()));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 321 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Woman\Shop.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                                    </div><!-- End .filter-items -->
                                </div><!-- End .widget-body -->
                            </div><!-- End .collapse -->
                        </div><!-- End .widget -->

                        <div class=""widget widget-collapsible"">
                            <h3 class=""widget-title"">
                                <a data-toggle=""collapse"" href=""#widget-5"" role=""button"" aria-expanded=""true"" aria-controls=""widget-5"">
                                    Price
                                </a>
                            </h3><!-- End .widget-title -->

                            <div class=""collapse show"" id=""widget-5"">
                                <div class=""widget-body"">
                                    <div class=""filter-price"">
                                        <div class=""filter-price-text"">
                                            Price Range:
                                           ");
            WriteLiteral(@" <span id=""filter-price-range"">$0 - $750</span>
                                        </div><!-- End .filter-price-text -->

                                        <div id=""price-slider"" class=""noUi-target noUi-ltr noUi-horizontal""><div class=""noUi-base""><div class=""noUi-connects""><div class=""noUi-connect"" style=""transform: translate(0%, 0px) scale(0.75, 1);""></div></div><div class=""noUi-origin"" style=""transform: translate(-100%, 0px); z-index: 5;""><div class=""noUi-handle noUi-handle-lower"" data-handle=""0"" tabindex=""0"" role=""slider"" aria-orientation=""horizontal"" aria-valuemin=""0.0"" aria-valuemax=""550.0"" aria-valuenow=""0.0"" aria-valuetext=""$0""><div class=""noUi-touch-area""></div><div class=""noUi-tooltip"">$0</div></div></div><div class=""noUi-origin"" style=""transform: translate(-25%, 0px); z-index: 4;""><div class=""noUi-handle noUi-handle-upper"" data-handle=""1"" tabindex=""0"" role=""slider"" aria-orientation=""horizontal"" aria-valuemin=""200.0"" aria-valuemax=""1000.0"" aria-valuenow=""750.0"" aria-valuetext=""$750""><di");
            WriteLiteral(@"v class=""noUi-touch-area""></div><div class=""noUi-tooltip"">$750</div></div></div></div></div><!-- End #price-slider -->
                                    </div><!-- End .filter-price -->
                                </div><!-- End .widget-body -->
                            </div><!-- End .collapse -->
                        </div>
                    </div><!-- End .sidebar sidebar-shop -->
                </aside><!-- End .col-lg-3 -->
            </div><!-- End .row -->
        </div><!-- End .container -->
    </div><!-- End .page-content -->
</main><!-- End .main -->

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {

            $("".productClass"").slice(0, 6).show()
            if ($("".productClass:hidden"").length == 0) {
                $(""#loadMore"").fadeOut()
            }
            $(""#loadMore"").click(function (e) {

                e.preventDefault();
                $("".productClass:hidden"").slice(0, 6).show()
                if ($("".productClass:hidden"").length == 0) {
                    $(""#loadMore"").fadeOut()
                }
            })



            $("".colorClick"").click(function (e) {
                e.preventDefault();
                $(this).toggleClass(""selected"")
                //console.log(""clicked"");
            })



            $("".product-notMain"").click(function (e) {
                console.log(""sa"")
                e.preventDefault();
                var parent = $(this).closest("".product-body"").prev().children("".until"").children("".product-main"")
                var newHref = $(this).attr(""href"")
   ");
                WriteLiteral(@"            $(parent).closest("".until"").removeAttr(""href"").attr(""href"", newHref)
                var closestNav = $(this).closest("".product-nav"");
                $(closestNav.children("".product-notMain"")).not(this).removeClass(""active"");

                $(this).addClass(""active"")
                var notmain = $(this).children("".nmSrc"").attr(""src"")
                $(parent).attr(""src"", notmain)

            })

            $("".sizeClick"").click(function (e) {
                e.preventDefault();
                $(this).closest("".product-size"").children("".sizeClick"").not(this).removeClass(""active"")
                $(this).addClass(""active"")
            })


            //$("".categoryCheck"").click(function (e) {
            //    //e.preventDefault();
            //    //$(this).prop('salam')
            //    $(this).attr('checked')
            //    //console.log(""s/*"")*/

            //})

            //$("".filtercheck"").click(function (e) {
            //    //e.preventDefault();
");
                WriteLiteral("            //    //$(this).prop(\'salam\')\r\n            //    $(this).attr(\'checked\')\r\n            //    //console.log(\"s\")\r\n\r\n            //})\r\n\r\n            //$(\".filtercheck\").click(function)\r\n        })\r\n    </script>\r\n");
            }
            );
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

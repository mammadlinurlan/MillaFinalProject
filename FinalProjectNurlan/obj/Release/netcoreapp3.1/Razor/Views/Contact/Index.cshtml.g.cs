#pragma checksum "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9777dcce7cf5a1dc83e7883234d39c2706942216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9777dcce7cf5a1dc83e7883234d39c2706942216", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17ee9c7b284202d872561ba3ab9135afecafa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main class=""main"">
    <nav aria-label=""breadcrumb"" class=""breadcrumb-nav border-0 mb-0"">
        <div class=""container"">
            <ol class=""breadcrumb"">
                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                <li class=""breadcrumb-item""><a href=""#"">Pages</a></li>
                <li class=""breadcrumb-item active"" aria-current=""page"">Contact us</li>
            </ol>
        </div><!-- End .container -->
    </nav><!-- End .breadcrumb-nav -->
    <div class=""container"">
        <div class=""page-header page-header-big text-center"" style=""background-image: url('assets/images/contact-header-bg.jpg')"">
            <h1 class=""page-title text-white"">Contact us<span class=""text-white"">keep in touch with us</span></h1>
        </div><!-- End .page-header -->
    </div><!-- End .container -->

    <div class=""page-content pb-0"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 mb-2 mb-lg-0"">
            ");
            WriteLiteral(@"        <h2 class=""title mb-1"">Contact Information</h2><!-- End .title mb-2 -->
                    <p class=""mb-3"">Vestibulum volutpat, lacus a ultrices sagittis, mi neque euismod dui, eu pulvinar nunc sapien ornare nisl. Phasellus pede arcu, dapibus eu, fermentum et, dapibus sed, urna.</p>
                    <div class=""row"">
                        <div class=""col-sm-7"">
                            <div class=""contact-info"">
                                <h3>The Office</h3>

                                <ul class=""contact-list"">
                                    <li>
                                        <i class=""icon-map-marker""></i>
                                        70 Washington Square South New York, NY 10012, United States
                                    </li>
                                    <li>
                                        <i class=""icon-phone""></i>
                                        <a href=""tel:#"">+92 423 567</a>
                             ");
            WriteLiteral(@"       </li>
                                    <li>
                                        <i class=""icon-envelope""></i>
                                        <a href=""mailto:#"">info@Molla.com</a>
                                    </li>
                                </ul><!-- End .contact-list -->
                            </div><!-- End .contact-info -->
                        </div><!-- End .col-sm-7 -->

                        <div class=""col-sm-5"">
                            <div class=""contact-info"">
                                <h3>The Office</h3>

                                <ul class=""contact-list"">
                                    <li>
                                        <i class=""icon-clock-o""></i>
                                        <span class=""text-dark"">Monday-Saturday</span> <br>11am-7pm ET
                                    </li>
                                    <li>
                                        <i class=""icon-calendar""></i>
  ");
            WriteLiteral(@"                                      <span class=""text-dark"">Sunday</span> <br>11am-6pm ET
                                    </li>
                                </ul><!-- End .contact-list -->
                            </div><!-- End .contact-info -->
                        </div><!-- End .col-sm-5 -->
                    </div><!-- End .row -->
                </div><!-- End .col-lg-6 -->
                <div class=""col-lg-6"">
                    <h2 class=""title mb-1"">Got Any Questions?</h2><!-- End .title mb-2 -->
                    <p class=""mb-2"">Use the form below to get in touch with the sales team</p>

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9777dcce7cf5a1dc83e7883234d39c27069422168350", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <label for=""cname"" class=""sr-only"">Name</label>
                                <input type=""text"" class=""form-control"" id=""cname"" placeholder=""Name *"" required>
                            </div><!-- End .col-sm-6 -->

                            <div class=""col-sm-6"">
                                <label for=""cemail"" class=""sr-only"">Email</label>
                                <input type=""email"" class=""form-control"" id=""cemail"" placeholder=""Email *"" required>
                            </div><!-- End .col-sm-6 -->
                        </div><!-- End .row -->

                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <label for=""cphone"" class=""sr-only"">Phone</label>
                                <input type=""tel"" class=""form-control"" id=""cphone"" placeholder=""Phone"">
                          ");
                WriteLiteral(@"  </div><!-- End .col-sm-6 -->

                            <div class=""col-sm-6"">
                                <label for=""csubject"" class=""sr-only"">Subject</label>
                                <input type=""text"" class=""form-control"" id=""csubject"" placeholder=""Subject"">
                            </div><!-- End .col-sm-6 -->
                        </div><!-- End .row -->

                        <label for=""cmessage"" class=""sr-only"">Message</label>
                        <textarea class=""form-control"" cols=""30"" rows=""4"" id=""cmessage"" required placeholder=""Message *""></textarea>

                        <button type=""submit"" class=""btn btn-outline-primary-2 btn-minwidth-sm"">
                            <span>SUBMIT</span>
                            <i class=""icon-long-arrow-right""></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<!-- End .contact-form -->
                </div><!-- End .col-lg-6 -->
            </div><!-- End .row -->

            <hr class=""mt-4 mb-5"">

            <div class=""stores mb-4 mb-lg-5"">
                <h2 class=""title text-center mb-3"">Our Stores</h2><!-- End .title text-center mb-2 -->

                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""store"">
                            <div class=""row"">
                                <div class=""col-sm-5 col-xl-6"">
                                    <figure class=""store-media mb-2 mb-lg-0"">
                                        <img src=""assets/images/stores/img-1.jpg"" alt=""image"">
                                    </figure><!-- End .store-media -->
                                </div><!-- End .col-xl-6 -->
                                <div class=""col-sm-7 col-xl-6"">
                                    <div class=""store-content"">
                                        <h3 c");
            WriteLiteral(@"lass=""store-title"">Wall Street Plaza</h3><!-- End .store-title -->
                                        <address>88 Pine St, New York, NY 10005, USA</address>
                                        <div><a href=""tel:#"">+1 987-876-6543</a></div>

                                        <h4 class=""store-subtitle"">Store Hours:</h4><!-- End .store-subtitle -->
                                        <div>Monday - Saturday 11am to 7pm</div>
                                        <div>Sunday 11am to 6pm</div>

                                        <a href=""#"" class=""btn btn-link"" target=""_blank""><span>View Map</span><i class=""icon-long-arrow-right""></i></a>
                                    </div><!-- End .store-content -->
                                </div><!-- End .col-xl-6 -->
                            </div><!-- End .row -->
                        </div><!-- End .store -->
                    </div><!-- End .col-lg-6 -->

                    <div class=""col-lg-6"">
               ");
            WriteLiteral(@"         <div class=""store"">
                            <div class=""row"">
                                <div class=""col-sm-5 col-xl-6"">
                                    <figure class=""store-media mb-2 mb-lg-0"">
                                        <img src=""assets/images/stores/img-2.jpg"" alt=""image"">
                                    </figure><!-- End .store-media -->
                                </div><!-- End .col-xl-6 -->

                                <div class=""col-sm-7 col-xl-6"">
                                    <div class=""store-content"">
                                        <h3 class=""store-title"">One New York Plaza</h3><!-- End .store-title -->
                                        <address>88 Pine St, New York, NY 10005, USA</address>
                                        <div><a href=""tel:#"">+1 987-876-6543</a></div>

                                        <h4 class=""store-subtitle"">Store Hours:</h4><!-- End .store-subtitle -->
                           ");
            WriteLiteral(@"             <div>Monday - Friday 9am to 8pm</div>
                                        <div>Saturday - 9am to 2pm</div>
                                        <div>Sunday - Closed</div>

                                        <a href=""#"" class=""btn btn-link"" target=""_blank""><span>View Map</span><i class=""icon-long-arrow-right""></i></a>
                                    </div><!-- End .store-content -->
                                </div><!-- End .col-xl-6 -->
                            </div><!-- End .row -->
                        </div><!-- End .store -->
                    </div><!-- End .col-lg-6 -->
                </div><!-- End .row -->
            </div><!-- End .stores -->
        </div><!-- End .container -->
        <div id=""map"">
            <div class=""mapouter""><div class=""gmap_canvas""><iframe width=""1263"" height=""500"" id=""gmap_canvas"" src=""https://maps.google.com/maps?q=baku%20azerbaijan&t=&z=13&ie=UTF8&iwloc=&output=embed"" frameborder=""0"" scrolling=""no"" marginheight");
            WriteLiteral(@"=""0"" marginwidth=""0""></iframe><a href=""https://123movies-to.org"">123movies</a><br>
            <style>
                .mapouter {
                    position: relative;
                    text-align: right;
                    height: 500px;
                    width: 1263px;
                }
            </style><a href=""https://www.embedgooglemap.net"">add google maps to html</a>
            <style>
                .gmap_canvas {
                    overflow: hidden;
                    background: none !important;
                    height: 500px;
                    width: 1263px;
                }
            </style></div></div>
        </div><!-- End #map -->
    </div><!-- End .page-content -->
</main><!-- End .main -->
");
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
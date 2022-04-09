#pragma checksum "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4240c60b88c29020ef9806eef95c697463aed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Cart), @"mvc.1.0.view", @"/Views/Order/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4240c60b88c29020ef9806eef95c697463aed3", @"/Views/Order/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f17ee9c7b284202d872561ba3ab9135afecafa5", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CheckoutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary-2 btn-order btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"
  
    double? totalprice = 0;
    foreach (var item in Model.BasketItems)
    {
        {
            totalprice += (item.ProductSizeColor.Product.Discount == null ? item.Count * item.ProductSizeColor.Product.Price : item.Count * (item.ProductSizeColor.Product.Price - (item.ProductSizeColor.Product.Price * item.ProductSizeColor.Product.Discount / 100)));

        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<main class=""main"">
    <div class=""page-header text-center"" style=""background-image: url('assets/images/page-header-bg.jpg')"">
        <div class=""container"">
            <h1 class=""page-title"">Shopping Cart<span>Shop</span></h1>
        </div>
    </div>



    <div class=""page-content"">

");
#nullable restore
#line 26 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"
         if (Model.BasketItems.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div style=""display: flex;height:150px;flex-direction:column; justify-content:space-around; align-items: center; margin-top: 9rem"">
                <i style=""transform:scale(3.0)"" class=""fa-solid fa-basket-shopping""></i>
                <h3 style=""margin:0 !important"">Your basket is empty!</h3>
            </div>
");
#nullable restore
#line 32 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""cart"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-9"">
                            <table class=""table table-cart table-mobile"">
                                <thead>
                                    <tr>
                                        <th>Product</th>
                                        <th>Color</th>
                                        <th>Size</th>
                                        <th>Price</th>

                                        <th>Quantity</th>
                                        <th>Total</th>
                                        <th></th>
                                    </tr>
                                </thead>

                                <tbody class=""forPartial"">

                                    ");
#nullable restore
#line 55 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"
                               Write(await Html.PartialAsync("_cartPartialView", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                </tbody>\r\n                            </table>\r\n\r\n                            <div class=\"cart-bottom\">\r\n                                <div class=\"cart-discount\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4240c60b88c29020ef9806eef95c697463aed38127", async() => {
                WriteLiteral(@"
                                        <div class=""input-group"">
                                            <input type=""text"" class=""form-control"" required placeholder=""coupon code"">
                                            <div class=""input-group-append"">
                                                <button class=""btn btn-outline-primary-2"" type=""submit""><i class=""icon-long-arrow-right""></i></button>
                                            </div>
                                        </div>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                        <aside class=""col-lg-3"">
                            <div class=""summary summary-cart"">
                                <h3 class=""summary-title"">Cart Total</h3>

                                <table class=""table table-summary"">
                                    <tbody>
                                        <tr class=""summary-subtotal"">
                                            <td>Subtotal:</td>
                                            <td class=""totalPriceAppend"">
                                                $");
#nullable restore
#line 85 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"
                                            Write(String.Format("{0:0.00}", totalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                            </td>
                                        </tr>



                                        <tr class=""summary-total"">
                                            <td>Total:</td>
                                            <td class=""totalPriceAppend"">
                                                $");
#nullable restore
#line 95 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"
                                            Write(String.Format("{0:0.00}", totalprice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n                                    </tbody>\r\n                                </table>\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da4240c60b88c29020ef9806eef95c697463aed311922", async() => {
                WriteLiteral("PROCEED TO CHECKOUT");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </aside>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 108 "C:\Users\MACBOOK\source\repos\FinalProjectNurlan\FinalProjectNurlan\Views\Order\Cart.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</main>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \r\n");
                WriteLiteral(@"<script>

    //window.location.reload();
    $(document).ready(function () {
        var base = window.location.origin;

        console.log(""cart ready"")


        var partialurl = `${base}/Basket/CartPartial`
        var urlforpartial = `${base}/Basket/GetPartial`
        var urlforcount = `${base}/Basket/ForTotalCount`






        fetch(partialurl).then(res => res.text()).then(data => {
            console.log(data)

            fetch(partialurl).then(res => res.text()).then(data => {
                $("".forPartial"").empty();
                $("".forPartial"").append(data);



                $("".quantityClick"").attr(""readonly"")

                var minus = `<i class=""icon-minus""></i>`
                var plus = `<i class=""icon-plus""></i>`

                $(""input[type='number']"").inputSpinner();
                $(""input[type='number']"").next().addClass(""input-spinner"")
                $("".btn-outline-secondary"").removeClass(""btn-outline-secondary"")
                $("".");
                WriteLiteral(@"btn-outline-secondary"").removeClass(""btn-outline-secondary"")

                var urlforprice = `${base}/Basket/GetTotalPrice`


                fetch(urlforprice).then(res => res.text()).then(data => {

                    $("".cart-total-price"").empty();
                    var monet = parseFloat(data).toFixed(2)
                    $("".cart-total-price"").append(`$${monet}`);


                    $("".totalPriceAppend"").empty()

                    $("".totalPriceAppend"").append(`$${monet}`)

                    $("".quantityClick"").attr(""readonly"")

                })

                fetch(urlforpartial).then(res => res.text()).then(data => {

                    $("".dropdown-cart-products"").empty();
                    $("".dropdown-cart-products"").append(data);
                    $("".quantityClick"").attr(""readonly"")

                })

                fetch(urlforcount).then(res => res.text()).then(data => {

                    $("".cart-count"").empty();
                    ");
                WriteLiteral(@"$("".cart-count"").append(data);
                    $("".quantityClick"").attr(""readonly"")

                })

                $("".input-group-prepend"").next().attr(""readonly"", ""true"")
            })

           

        })

      




        //window.location.reload()
        //console.log('reloaded')

        $(document).on(""change"", "".quantityClick"", function () {

            var sizeId = $(this).next().next().val();
            var colorId = $(this).next().next().next().val();
            var productId = $(this).next().next().next().next().val();


            var value = $(this).val();


            var uruuul = window.location.origin;
            var url = uruuul + '/Basket/CartCounter' + '?sizeId=' + sizeId + '&colorId=' + colorId + '&productId=' + productId + '&quantity=' + value


            var urlforcount = `${uruuul}/Basket/ForTotalCount`

            var urlforprice = `${uruuul}/Basket/GetTotalPrice`
            var urlforpartial = `${uruuul}/Basket/GetParti");
                WriteLiteral(@"al`



            fetch(url).then(res => res.text()).then(data => {

                //console.log(data)

                $("".forPartial"").empty();
                $("".forPartial"").append(data);


                


                var minus = `<i class=""icon-minus""></i>`
                var plus = `<i class=""icon-plus""></i>`

                $(""input[type='number']"").inputSpinner();
                $(""input[type='number']"").next().addClass(""input-spinner"")
                $("".btn-outline-secondary"").removeClass(""btn-outline-secondary"")
                $("".btn-outline-secondary"").removeClass(""btn-outline-secondary"")
              
                


                var price = $("".total-col"").children().last().text()

                var updatedPrice = parseFloat(price).toFixed(2);
                $("".total-col"").children().last().empty()
                $("".total-col"").children().last().append(updatedPrice)

                fetch(urlforcount).then(res => res.text()).then(data");
                WriteLiteral(@" => {

                    $("".cart-count"").empty();
                    $("".cart-count"").append(data);

                })
                fetch(urlforprice).then(res => res.text()).then(data => {

                    $("".cart-total-price"").empty();
                    var monet = parseFloat(data).toFixed(2)
                    $("".cart-total-price"").append(`$${monet}`);
                    

                    $("".totalPriceAppend"").empty()

                    $("".totalPriceAppend"").append(`$${monet}`)


                })

                fetch(urlforpartial).then(res => res.text()).then(data => {

                    $("".dropdown-cart-products"").empty();
                    $("".dropdown-cart-products"").append(data);

                })
                //console.log(updatedPrice)
                $("".input-group-prepend"").next().attr(""readonly"",""true"")

            })


        })


        $(document).on(""click"", "".cart-remove-btn"", function (e) {

            e.preve");
                WriteLiteral(@"ntDefault();
            var linkk = $(this).parent().attr(""href"");
            var base = window.location.origin
            //var prodid = $("".hiddenProdId"").val();
            console.log(`${base}${linkk}`)
            var comp = `${base}${linkk}`

            $("".quantityClick"").attr(""readonly"")


            var urlstrt = window.location.origin;
            var urlforcount = `${urlstrt}/Basket/ForTotalCount`
            var urlforpartial = `${urlstrt}/Basket/GetPartial`
            var urlforprice = `${urlstrt}/Basket/GetTotalPrice`


            fetch(comp).then(res => res.text()).then(data => {
                console.log(data)
                $("".quantityClick"").attr(""readonly"")


                fetch(urlforcount).then(res => res.text()).then(data => {

                    $("".cart-count"").empty();
                    $("".cart-count"").append(data);
                    $("".quantityClick"").attr(""readonly"")

                })
                fetch(urlforpartial).then(res => ");
                WriteLiteral(@"res.text()).then(data => {

                    $("".quantityClick"").attr(""readonly"")
                    $("".dropdown-cart-products"").empty();
                    $("".dropdown-cart-products"").append(data);

                })
                fetch(urlforprice).then(res => res.text()).then(data => {
                    $("".quantityClick"").attr(""readonly"")

                    $("".cart-total-price"").empty();
                    var monet = parseFloat(data).toFixed(2)
                    $("".cart-total-price"").append(`$${monet}`);

                })


                var base = window.location.origin;


                var partialurl = `${base}/Basket/CartPartial`
                var urlforpartial = `${base}/Basket/GetPartial`
                $("".quantityClick"").attr(""readonly"")


                fetch(partialurl).then(res => res.text()).then(data => {

                    $("".forPartial"").empty();
                    $("".forPartial"").append(data);

                    var minus = ");
                WriteLiteral(@"`<i class=""icon-minus""></i>`
                    var plus = `<i class=""icon-plus""></i>`

                    $(""input[type='number']"").inputSpinner();
                    $(""input[type='number']"").next().addClass(""input-spinner"")
                    $("".btn-outline-secondary"").removeClass(""btn-outline-secondary"")
                    $("".btn-outline-secondary"").removeClass(""btn-outline-secondary"")

                    var urlforprice = `${base}/Basket/GetTotalPrice`
                    $("".quantityClick"").attr(""readonly"")


                    fetch(urlforprice).then(res => res.text()).then(data => {

                        $("".cart-total-price"").empty();
                        var monet = parseFloat(data).toFixed(2)
                        $("".cart-total-price"").append(`$${monet}`);


                        $("".totalPriceAppend"").empty()

                        $("".totalPriceAppend"").append(`$${monet}`)

                        $("".quantityClick"").attr(""readonly"")

               ");
                WriteLiteral(@"     })

                    fetch(urlforpartial).then(res => res.text()).then(data => {

                        $("".dropdown-cart-products"").empty();
                        $("".dropdown-cart-products"").append(data);
                        $("".quantityClick"").attr(""readonly"")


                    })
                    $("".input-group-prepend"").next().attr(""readonly"", ""true"")




                })



            })
        })

    

    })
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CheckoutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

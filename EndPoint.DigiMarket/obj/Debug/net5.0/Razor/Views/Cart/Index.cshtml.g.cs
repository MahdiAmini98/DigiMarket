#pragma checksum "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49df5678205e9a02724b65340ba72085cd9d2f5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\_ViewImports.cshtml"
using EndPoint.DigiMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\_ViewImports.cshtml"
using EndPoint.DigiMarket.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49df5678205e9a02724b65340ba72085cd9d2f5d", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a192d2f4a8956a1df86b88ab2664c8dcec106dbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigiMarket.Application.Services.Carts.CartDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("c-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/pay"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout-button d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    int sumTotal=0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"cart-home\">\r\n    <div class=\"post-item-cart d-block order-2\">\r\n        <div class=\"content-page\">\r\n            <div class=\"cart-form\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49df5678205e9a02724b65340ba72085cd9d2f5d5763", async() => {
                WriteLiteral(@"
                    <table class=""table-cart cart table table-borderless"">
                        <thead>
                            <tr>
                                <th scope=""col"" class=""product-cart-name"">نام محصول</th>
                                <th scope=""col"" class=""product-cart-price"">قیمت</th>
                                <th scope=""col"" class=""product-cart-quantity"">تعداد مورد نیاز</th>
                                <th scope=""col"" class=""product-cart-Total"">مجموع</th>
                            </tr>
                        </thead>
                        <tbody>

");
#nullable restore
#line 26 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                             foreach (var item in Model.CartItem)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <tr>
                                    <th scope=""row"" class=""product-cart-name"">
                                        <div class=""product-thumbnail-img"">
                                            <a href=""#"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "49df5678205e9a02724b65340ba72085cd9d2f5d7278", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1390, "~/", 1390, 2, true);
#nullable restore
#line 32 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1392, item.Image, 1392, 11, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </a>\r\n                                            <div class=\"product-remove\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49df5678205e9a02724b65340ba72085cd9d2f5d9019", async() => {
                    WriteLiteral("\r\n                                                    <i class=\"mdi mdi-close\"></i>\r\n                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1588, "~/Cart/RemoveToCart?productId=", 1588, 30, true);
#nullable restore
#line 35 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1618, item.Id, 1618, 8, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""product-title"">
                                            <a href=""#"">
                                                ");
#nullable restore
#line 42 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            </a>
                                            <div class=""variation"">
                                               
                                                <div class=""variant-guarantee"">
                                                    <i class=""mdi mdi-check""></i>
                                                    گارانتی ۱۸ ماهه
                                                </div>
                                                <div class=""seller"">
                                                    <i class=""mdi mdi-storefront""></i>
                                                    فروشنده :
                                                    <span>کالا مارکت</span>
                                                </div>
                                            </div>
                                        </div>
                                    </th>
                                    <td class=""product-cart-price"">
                WriteLiteral("\n                                        <span class=\"amount\">\r\n                                            ");
#nullable restore
#line 60 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                                       Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                            <span>تومان</span>
                                        </span>
                                    </td>
                                    <td class=""product-cart-quantity"">
                                        <div class=""required-number before"">
                                            <div class=""quantity"">
                                                <input type=""number"" min=""1"" max=""100"" step=""1""");
                BeginWriteAttribute("value", " value=\"", 3703, "\"", 3722, 1);
#nullable restore
#line 67 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3711, item.Count, 3711, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3723, "\"", 3742, 2);
                WriteAttributeValue("", 3728, "count-", 3728, 6, true);
#nullable restore
#line 67 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3734, item.Id, 3734, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("><div class=\"quantity-nav\"><div class=\"quantity-button quantity-up\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3810, "\"", 3849, 3);
                WriteAttributeValue("", 3820, "AddToCountProduct(\'", 3820, 19, true);
#nullable restore
#line 67 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3839, item.Id, 3839, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3847, "\')", 3847, 2, true);
                EndWriteAttribute();
                WriteLiteral(">+</div><div class=\"quantity-button quantity-down\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3900, "\"", 3939, 3);
                WriteAttributeValue("", 3910, "LowToCountProduct(\'", 3910, 19, true);
#nullable restore
#line 67 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3929, item.Id, 3929, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3937, "\')", 3937, 2, true);
                EndWriteAttribute();
                WriteLiteral(@">-</div></div>
                                            </div>
                                        </div>
                                    </td>
                                    <td class=""product-cart-Total"">
                                        <span class=""amount"">
");
#nullable restore
#line 73 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                                            
                                              int total = item.Price * item.Count;

                                              sumTotal += total;
                                          

#line default
#line hidden
#nullable disable
                WriteLiteral("                                          \r\n                                          ");
#nullable restore
#line 79 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                                     Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                          <span>تومان</span>\r\n                                        </span>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 84 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""cart-collaterals"">
                    <div class=""totals d-block"">
                        <h3 class=""Total-cart-total"">مجموع کل سبد خرید</h3>
                        <div class=""checkout-summary"">
                            <ul class=""checkout-summary-summary"">
                                <li class=""cart-subtotal"">
                                    <span class=""amount"">قیمت کل</span>
                                    <span> ");
#nullable restore
#line 96 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Cart\Index.cshtml"
                                      Write(sumTotal.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" تومان</span>
                                </li>
                                <li class=""shipping-totals"">
                                    <span class=""amount"">حمل و نقل</span>
                                    <div class=""shipping-totals-item"">
                                        <div class=""shipping-totals-outline"">
                                            <label for=""#"" class=""outline-radio"">
                                                <input type=""radio"" name=""payment_method"" id=""payment-option-online"" checked=""checked"">
                                                <span class=""outline-radio-check""></span>
                                            </label>
                                            <label for=""#"" class=""shipping-totals-title-row"">
                                                <div class=""shipping-totals-title"">حمل و نقل رایگان</div>
                                            </label>
                                        </div>
             ");
            WriteLiteral(@"                           <div class=""shipping-totals-outline"">
                                            <label for=""#"" class=""outline-radio"">
                                                <input type=""radio"" name=""payment_method"" id=""payment-option-online"">
                                                <span class=""outline-radio-check""></span>
                                            </label>
                                            <label for=""#"" class=""shipping-totals-title-row"">
                                                <div class=""shipping-totals-title"">حمل و نقل معمولی: 20,000 تومان</div>
                                            </label>
                                        </div>
                                        <span class=""shipping-destination"">حمل و نقل به خراسان شمالی</span>
                                    </div>
                                </li>
                                <li class=""order-total"">
                                    <span c");
            WriteLiteral(@"lass=""amount""> مجموع</span>
                                    <span> 6,032,000 تومان</span>
                                </li>
                                <li class=""discount-code"">
                                    <div class="" align-items-center"">
                                        <div class=""col-md-7 pr mt-5"">
                                            <div class=""coupon"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49df5678205e9a02724b65340ba72085cd9d2f5d21712", async() => {
                WriteLiteral(@"
                                                    <input type=""text"" name=""input-coupon"" class=""input-coupon-code"" placeholder=""كد تخفیف:"">
                                                    <button class=""btn btn-coupon"" type=""submit"">اعمال</button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <div class=""col-md-2 pl mt-5"">
                                            <div class=""proceed-to-checkout"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49df5678205e9a02724b65340ba72085cd9d2f5d23644", async() => {
                WriteLiteral("تسویه حساب");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script>
        function AddToCountProduct(cartItemId) {

            window.location.replace('/Cart/AddToCountProduct?cartItemId=' + cartItemId);

        }

        function LowToCountProduct(cartItemId) {

            window.location.replace('/Cart/LowToCountProduct?cartItemId=' + cartItemId);

        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DigiMarket.Application.Services.Carts.CartDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
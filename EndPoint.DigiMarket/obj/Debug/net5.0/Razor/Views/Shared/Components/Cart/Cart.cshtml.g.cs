#pragma checksum "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38f6f7bb530ff9fe6e69c5d72b17615341475714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Cart_Cart), @"mvc.1.0.view", @"/Views/Shared/Components/Cart/Cart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f6f7bb530ff9fe6e69c5d72b17615341475714", @"/Views/Shared/Components/Cart/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a192d2f4a8956a1df86b88ab2664c8dcec106dbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Cart_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DigiMarket.Application.Services.Carts.CartDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mini-cart-item-close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("view-card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/pay"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""divider-space-card d-block"">
    <div class=""header-cart-basket"">
        <a href=""#"" class=""cart-basket-box"">
            <span class=""icon-cart"">
                <i class=""mdi mdi-shopping""></i>
            </span>
            <span class=""title-cart"">?????? ????????</span>
            <span class=""price-cart"">
              ");
#nullable restore
#line 14 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
         Write(Model.SumPrice.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span>??????????</span>\r\n            </span>\r\n            <span class=\"count-cart\">");
#nullable restore
#line 17 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
                                Write(Model.ProductCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </a>\r\n        <div class=\"widget-shopping-cart\">\r\n            <div class=\"widget-shopping-cart-content\">\r\n                <ul class=\"product-list-widget\">\r\n                    \r\n");
#nullable restore
#line 23 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
                     foreach (var item in Model.CartItem)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"mini-cart-item\">\r\n                            <div class=\"mini-cart-item-content\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f6f7bb530ff9fe6e69c5d72b176153414757147018", async() => {
                WriteLiteral("\r\n                                    <i class=\"mdi mdi-close\"></i>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1007, "~/Cart/RemoveToCart?productId=", 1007, 30, true);
#nullable restore
#line 27 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
AddHtmlAttributeValue("", 1037, item.Id, 1037, 8, false);

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
            WriteLiteral("\r\n                                <a href=\"#\" class=\"mini-cart-item-image d-block\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "38f6f7bb530ff9fe6e69c5d72b176153414757148913", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1312, "~/", 1312, 2, true);
#nullable restore
#line 31 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
AddHtmlAttributeValue("", 1314, item.Image, 1314, 11, false);

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
            WriteLiteral("\r\n                                </a>\r\n                                <span class=\"product-name-card\">");
#nullable restore
#line 33 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
                                                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <div class=""variation"">
                                    <span class=""variation-n"">?????????????? : </span>
                                    <p class=""mb-0"">???????? ???????????? </p>
                                </div>
                                <div class=""quantity"">
                                    <span class=""quantity-Price-amount"">
                                       ");
#nullable restore
#line 40 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
                                  Write(item.Price.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        <span>??????????</span>\r\n                                    </span>\r\n                                </div>\r\n                            </div>\r\n                        </li>\r\n");
#nullable restore
#line 46 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n                <div class=\"mini-card-total\">\r\n                    <strong>???????? ???? : </strong>\r\n                    <span class=\"price-total\">\r\n                       ");
#nullable restore
#line 53 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\Cart\Cart.cshtml"
                  Write(Model.SumPrice.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <span>??????????</span>\r\n                    </span>\r\n                </div>\r\n                <div class=\"mini-card-button\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f6f7bb530ff9fe6e69c5d72b1761534147571412759", async() => {
                WriteLiteral("???????????? ?????? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "38f6f7bb530ff9fe6e69c5d72b1761534147571413947", async() => {
                WriteLiteral("?????????? ????????");
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
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

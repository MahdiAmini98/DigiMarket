#pragma checksum "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb802ab7e921c8b5d274e2cf56204b8cf0bb058e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_GetMenu_GetMenu), @"mvc.1.0.view", @"/Views/Shared/Components/GetMenu/GetMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb802ab7e921c8b5d274e2cf56204b8cf0bb058e", @"/Views/Shared/Components/GetMenu/GetMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a192d2f4a8956a1df86b88ab2664c8dcec106dbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_GetMenu_GetMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem.MenuItemDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mega-menu-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <li id=\"nav-menu-item\" class=\"menu-item nav-overlay\">\r\n        <a href=\"#\" class=\"current-link-menu\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
       Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
         if (item.ChildCategory.Count() > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"sub-menu is-mega-menu-small\">\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
                 foreach (var itemChild in item.ChildCategory)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"menu-mega-item menu-item-type-mega-menu item-small\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb802ab7e921c8b5d274e2cf56204b8cf0bb058e5541", async() => {
                WriteLiteral("\r\n                            ");
#nullable restore
#line 25 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
                       Write(itemChild.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 629, "~/product/index?CatId=", 629, 22, true);
#nullable restore
#line 24 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
AddHtmlAttributeValue("", 651, itemChild.CategoryId, 651, 21, false);

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
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 28 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 30 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n");
#nullable restore
#line 33 "C:\Users\Pacific\Documents\Programming\Asp.NetCore\DigiMarket\EndPoint.DigiMarket\Views\Shared\Components\GetMenu\GetMenu.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DigiMarket.Application.Services.Common.Site.Queries.GetMenuItem.MenuItemDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc898b5a5130717b2d5dbfe3dd65b682507e8e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\_ViewImports.cshtml"
using WebShopMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\_ViewImports.cshtml"
using WebShop.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc898b5a5130717b2d5dbfe3dd65b682507e8e1", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667fe8b3eea29b955d8a704b99d69c3ea38463c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShop.Model.ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Hero Section Begin -->
<section class=""hero hero-normal"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3"">
                <div class=""hero__categories"">
                    <div class=""hero__categories__all"">
                        <i class=""fa fa-bars""></i>
                        <span>Categories</span>
                    </div>
                    <ul>
");
#nullable restore
#line 16 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                         foreach (var item in Model.listCategory)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 626, "\"", 667, 3);
            WriteAttributeValue("", 636, "ClickCategory(", 636, 14, true);
#nullable restore
#line 18 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 650, item.CategoryId, 650, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 666, ")", 666, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 19 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n                <div class=\"hero__search\">\r\n                    <div class=\"hero__search__form\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cc898b5a5130717b2d5dbfe3dd65b682507e8e16267", async() => {
                WriteLiteral("\r\n                            <input id=\"search\" type=\"text\" placeholder=\"What do you need?\">\r\n                            <button type=\"button\" onclick=\"Search()\" class=\"site-btn\">SEARCH</button>\r\n                        ");
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
            WriteLiteral(@"
                    </div>
                    <div class=""hero__search__phone"">
                        <div class=""hero__search__phone__icon"">
                            <i class=""fa fa-phone""></i>
                        </div>
                        <div class=""hero__search__phone__text"">
                            <h5>+65 11.188.888</h5>
                            <span>support 24/7 time</span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Hero Section End -->

<section class=""product spad"" style=""padding-top:0px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-3 col-md-5"">
                <div class=""sidebar"">
                    <div class=""sidebar__item"">
                        <h4>Categories</h4>
                        <ul>
");
#nullable restore
#line 55 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                             foreach (var item in Model.listCategory)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li><a href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2251, "\"", 2292, 3);
            WriteAttributeValue("", 2261, "ClickCategory(", 2261, 14, true);
#nullable restore
#line 57 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
WriteAttributeValue("", 2275, item.CategoryId, 2275, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2291, ")", 2291, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 58 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""sidebar__item"">
                        <h4>Price</h4>
                        <div class=""price-range-wrap"">
                            <div class=""price-range ui-slider ui-corner-all ui-slider-horizontal ui-widget ui-widget-content""
                                 data-min=""0"" data-max=""5000"">
                                <div class=""ui-slider-range ui-corner-all ui-widget-header""></div>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                                <span tabindex=""0"" class=""ui-slider-handle ui-corner-all ui-state-default""></span>
                            </div>
                            <div class=""range-slider"">
                                <div class=""price-input"">
                                    <input type=""text"" id=""minamount"">
                                    <input type=""text"" id=""maxamount"">
  ");
            WriteLiteral("                              </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 78 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
                     if (Model.IsAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"sidebar__item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9cc898b5a5130717b2d5dbfe3dd65b682507e8e111687", async() => {
                WriteLiteral("Create new product");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 81 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"col-lg-9 col-md-7\">\r\n                <div class=\"filter__item\" id=\"partialView\">\r\n                    \r\n                    ");
#nullable restore
#line 88 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
               Write(Html.Partial("_Product", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                </div>\r\n                \r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<script>\r\n    function ClickCategory(id) {\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \'");
#nullable restore
#line 105 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
             Write(Url.Action("GetProductsByCategory", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { categoryId: id },
            success: function (partialView) {
                $(""#partialView"").html(partialView);
            },
            error: function () { alert('Error');}
            });
    }
    function Search() {
        var searchString = $(""#search"").val();
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 117 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
             Write(Url.Action("Search", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { searchBy: searchString },
            success: function (partialView) {
                $(""#partialView"").html(partialView);
            },
            error: function() { alert('Error');}
        });
    }
    function PriceRange(min,max) {
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 128 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
             Write(Url.Action("PriceRange", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { min: min, max: max },
            success: function (partialView) {
                $(""#partialView"").html(partialView);
            },
            error: function () { alert('Error'); }
        });
    }
    function ProductDetail(productId) {
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 139 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
             Write(Url.Action("ProductDetail", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { productId: productId },
            success: function () {
            },
            error: function () { alert('Error'); }
        });
    }
    function ProductToSession(productId) {
        var sessionQuantity = $(""#sessionQuantity"").val();
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 150 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
             Write(Url.Action("ProductToSession", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: { productId: productId, sessionQuantity: sessionQuantity},
            success: function () {
                var value = parseInt($(""#card"").html()) + 1;
                console.log(value.toString());
                $(""#card"").html(value.toString());
            },
            error: function () { alert('Error'); }
        });
    }
    function SortBy() {
        var sortBy=$(""#sortBy"").val();
        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 164 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Products\Index.cshtml"
             Write(Url.Action("SortBy", "Products"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n            data: { sortBy: sortBy },\r\n            //success: function () {\r\n            //    alert(\'Svaka cast\'); \r\n            //},\r\n            //error: function () { alert(\'Error\'); }\r\n        });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShop.Model.ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

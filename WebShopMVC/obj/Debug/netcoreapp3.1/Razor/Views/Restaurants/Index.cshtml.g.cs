#pragma checksum "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa6e5b90fbf3f2e9dbb9a05c39c6f4b87919664c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
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
#line 2 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
using WebShop.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa6e5b90fbf3f2e9dbb9a05c39c6f4b87919664c", @"/Views/Restaurants/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"667fe8b3eea29b955d8a704b99d69c3ea38463c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebShop.Model.RestaurantsModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
  
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
                        <span>Restaurants</span>
                    </div>
                    <ul>
");
#nullable restore
#line 17 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
                         foreach (RestaurantsModel item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\">");
#nullable restore
#line 19 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 20 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-9\">\r\n                <div class=\"hero__search\">\r\n                    <div class=\"hero__search__form\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa6e5b90fbf3f2e9dbb9a05c39c6f4b87919664c5340", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"What do yo u need?\">\r\n                            <button type=\"submit\" class=\"site-btn\">SEARCH</button>\r\n                        ");
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
<!-- Blog Section Begin -->
<section class=""blog spad"">
    <div class=""container"">
        <div class=""row"">
");
#nullable restore
#line 51 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
             foreach (RestaurantsModel item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 col-sm-6"">
                    <div class=""blog__item"">
                        <div class=""blog__item__pic"">
                            <img src=""https://upload.wikimedia.org/wikipedia/commons/thumb/a/ac/No_image_available.svg/1200px-No_image_available.svg.png""");
            BeginWriteAttribute("alt", " alt=\"", 2249, "\"", 2255, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </div>
                        <div class=""blog__item__text"">
                            <ul>
                                <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                                <li><i class=""fa fa-comment-o""></i> 5</li>
                            </ul>
                            <h5><a href=""#"">");
#nullable restore
#line 63 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                            <p>\r\n                                ");
#nullable restore
#line 65 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a href=\"#\" class=\"blog__btn\">READ MORE <span class=\"arrow_right\"></span></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 71 "C:\Users\Pufnica\Desktop\WebShop-ConsoleApp\WebShopMVC\Views\Restaurants\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebShop.Model.RestaurantsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7e70ba59fad0938acfb0af83d179376aee760b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductListPartial), @"mvc.1.0.view", @"/Views/Shared/_ProductListPartial.cshtml")]
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
#line 2 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.DAL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\_ViewImports.cshtml"
using Allup.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7e70ba59fad0938acfb0af83d179376aee760b6", @"/Views/Shared/_ProductListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e2087c87bc06c964055f4ecce1ba00b6332172", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productModalBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#productQuickModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DetailModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-items\">\r\n    <div class=\"row product-active\">\r\n");
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
         for (int i = 0; i < (int)Math.Ceiling((decimal)Model.Count() / 2); i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-2\">\r\n");
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                 foreach (Product product in Model.Skip(i * 2).Take(2))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"single-product mt-30\">\r\n                        <div class=\"product-image\">\r\n                            <a href=\"single-product.html\">\r\n                                <img class=\"first-image\"");
            BeginWriteAttribute("src", " src=\"", 546, "\"", 592, 2);
            WriteAttributeValue("", 552, "assets/images/product/", 552, 22, true);
#nullable restore
#line 14 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
WriteAttributeValue("", 574, product.MainImage, 574, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product\">\r\n                                <img class=\"second-image\"");
            BeginWriteAttribute("src", " src=\"", 667, "\"", 714, 2);
            WriteAttributeValue("", 673, "assets/images/product/", 673, 22, true);
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
WriteAttributeValue("", 695, product.HoverImage, 695, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""product"">
                            </a>
                            <ul class=""product-meta"">
                                <li><a href=""#""><i class=""icon ion-bag""></i></a></li>
                                <li><a href=""#""><i class=""icon ion-android-favorite-outline""></i></a></li>
                                <li><a href=""#""><i class=""icon ion-android-options""></i></a></li>
                                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7e70ba59fad0938acfb0af83d179376aee760b67703", async() => {
                WriteLiteral("<i class=\"icon ion-android-open\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                                                                                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                            </ul>\r\n");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                             if (product.DiscountPrice > 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"discount-product\"> - ");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                                              Write((((product.Price*100)/ product.DiscountPrice)-100).ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""product-content"">
                            <ul class=""product-rating"">
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                                <li><i class=""fas fa-star""></i></li>
                            </ul>
                            <h4 class=""product-title""><a href=""single-product.html"">");
#nullable restore
#line 36 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                                                               Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                            <div class=\"product-price\">\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                 if (product.DiscountPrice > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"regular-price\">€");
#nullable restore
#line 40 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span class=\"price-sale\">€ ");
#nullable restore
#line 41 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                                          Write(product.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <span class=\"regular-price\">€");
#nullable restore
#line 45 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 46 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div> <!-- single product -->\r\n");
#nullable restore
#line 51 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 54 "C:\Users\Lenovo\source\repos\Allup\Allup\Views\Shared\_ProductListPartial.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div> <!-- row -->\r\n</div> <!-- product items -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef3156c6a1c92b4bbcdbad5d4806bfe2af1f161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_InactiveProducts), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/InactiveProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/InactiveProducts.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_InactiveProducts))]
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
#line 1 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\_ViewImports.cshtml"
using ArtGalleryECommerce.Models;

#line default
#line hidden
#line 2 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\_ViewImports.cshtml"
using ArtGalleryECommerce.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ef3156c6a1c92b4bbcdbad5d4806bfe2af1f161", @"/Areas/Admin/Views/Product/InactiveProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c0219a74f243984f83661aa7647ee1c1eabde7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_InactiveProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtGalleryECommerce.Models.ViewModels.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
  
    ViewData["Title"] = "InactiveProducts";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 37, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"container-fluid\">\r\n");
            EndContext();
            BeginContext(283, 96, true);
            WriteLiteral("    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
            EndContext();
            BeginContext(380, 38, false);
#line 14 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(418, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(446, 47, false);
#line 15 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(493, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(521, 41, false);
#line 16 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(562, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(590, 47, false);
#line 17 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductSize));

#line default
#line hidden
            EndContext();
            BeginContext(637, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(665, 47, false);
#line 18 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductType));

#line default
#line hidden
            EndContext();
            BeginContext(712, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(740, 42, false);
#line 19 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(782, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(810, 48, false);
#line 20 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductState));

#line default
#line hidden
            EndContext();
            BeginContext(858, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(886, 41, false);
#line 21 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
               Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(927, 9, true);
            WriteLiteral("</th>\r\n\r\n");
            EndContext();
            BeginContext(1090, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
             foreach (var item in Model.ViewModelActiveProducts)
            {

#line default
#line hidden
            BeginContext(1225, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1272, 7, false);
#line 31 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1279, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1311, 16, false);
#line 32 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1327, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1359, 10, false);
#line 33 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1369, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1401, 16, false);
#line 34 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.ProductSize);

#line default
#line hidden
            EndContext();
            BeginContext(1417, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1449, 16, false);
#line 35 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1497, 11, false);
#line 36 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(1508, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1540, 17, false);
#line 37 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                   Write(item.ProductState);

#line default
#line hidden
            EndContext();
            BeginContext(1557, 35, true);
            WriteLiteral("</td>\r\n                    <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1592, "\"", 1609, 1);
#line 38 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
WriteAttributeValue("", 1598, item.Image, 1598, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1610, 29, true);
            WriteLiteral(" width=\"100px\" height=\"100px\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1639, "\"", 1662, 1);
#line 38 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
WriteAttributeValue("", 1645, item.ProductName, 1645, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1663, 12, true);
            WriteLiteral(" /></td>\r\n\r\n");
            EndContext();
            BeginContext(1775, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(1825, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abecd1d8f0fd4cbbb1ae1d3e02153918", async() => {
                BeginContext(1870, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1878, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1906, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948ef4295c5e44c2b8719c404bb6076f", async() => {
                BeginContext(1954, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                                                  WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(1965, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1993, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03df06baedd46c788d356fbf6ee3bc6", async() => {
                BeginContext(2040, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 45 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(2050, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Product\InactiveProducts.cshtml"
            }

#line default
#line hidden
            BeginContext(2117, 42, true);
            WriteLiteral("\r\n\r\n        </tbody>\r\n    </table>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtGalleryECommerce.Models.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

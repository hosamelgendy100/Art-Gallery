#pragma checksum "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67d8a87d24078e0dea5feeca3cb1bd8d2ddcc9ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_UserCart_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/UserCart/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/UserCart/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_UserCart_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d8a87d24078e0dea5feeca3cb1bd8d2ddcc9ef", @"/Areas/Admin/Views/UserCart/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c0219a74f243984f83661aa7647ee1c1eabde7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_UserCart_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtGalleryECommerce.Models.ViewModels.UserCartViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(166, 154, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div class=\"container-fluid\">\r\n   \r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
            EndContext();
            BeginContext(321, 38, false);
#line 14 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(359, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(387, 47, false);
#line 15 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(434, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(462, 41, false);
#line 16 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(503, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(531, 47, false);
#line 17 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductSize));

#line default
#line hidden
            EndContext();
            BeginContext(578, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(606, 47, false);
#line 18 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductType));

#line default
#line hidden
            EndContext();
            BeginContext(653, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(681, 42, false);
#line 19 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Artist));

#line default
#line hidden
            EndContext();
            BeginContext(723, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(751, 48, false);
#line 20 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.ProductState));

#line default
#line hidden
            EndContext();
            BeginContext(799, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(827, 41, false);
#line 21 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(868, 9, true);
            WriteLiteral("</th>\r\n\r\n");
            EndContext();
            BeginContext(1031, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
             foreach (var item in Model.ViewModelUserCarts)
            {

#line default
#line hidden
            BeginContext(1161, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1208, 7, false);
#line 31 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.ID);

#line default
#line hidden
            EndContext();
            BeginContext(1215, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1247, 16, false);
#line 32 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1295, 10, false);
#line 33 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1305, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1337, 16, false);
#line 34 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.ProductSize);

#line default
#line hidden
            EndContext();
            BeginContext(1353, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1385, 16, false);
#line 35 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.ProductType);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1433, 11, false);
#line 36 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.Artist);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1476, 17, false);
#line 37 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
                   Write(item.ProductState);

#line default
#line hidden
            EndContext();
            BeginContext(1493, 35, true);
            WriteLiteral("</td>\r\n                    <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1528, "\"", 1545, 1);
#line 38 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
WriteAttributeValue("", 1534, item.Image, 1534, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1546, 29, true);
            WriteLiteral(" width=\"100px\" height=\"100px\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 1575, "\"", 1598, 1);
#line 38 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
WriteAttributeValue("", 1581, item.ProductName, 1581, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1599, 12, true);
            WriteLiteral(" /></td>\r\n\r\n");
            EndContext();
            BeginContext(2019, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 48 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\UserCart\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(2057, 42, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtGalleryECommerce.Models.ViewModels.UserCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
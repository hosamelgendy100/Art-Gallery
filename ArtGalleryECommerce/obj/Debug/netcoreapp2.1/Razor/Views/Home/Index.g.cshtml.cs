#pragma checksum "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a47691a44fc4049fdb7e0a43343e5d1539d25ce4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\_ViewImports.cshtml"
using ArtGalleryECommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a47691a44fc4049fdb7e0a43343e5d1539d25ce4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad8b67bebeeab46657edd661839e54afb277593a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtGalleryECommerce.Models.ViewModels.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
            EndContext();
            BeginContext(189, 23, false);
#line 11 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Home\Index.cshtml"
Write(Html.Partial("_header"));

#line default
#line hidden
            EndContext();
            BeginContext(212, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(224, 72, true);
            WriteLiteral("<!-- / container -->\r\n\r\n<section id=\"gallery\" class=\"p-0 line-effect\">\r\n");
            EndContext();
            BeginContext(329, 33, true);
            WriteLiteral("    <!-- gallery filter -->\r\n    ");
            EndContext();
            BeginContext(363, 38, false);
#line 17 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("TypeBar"));

#line default
#line hidden
            EndContext();
            BeginContext(401, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(832, 31, true);
            WriteLiteral("    <!-- / gallery filter -->\r\n");
            EndContext();
            BeginContext(877, 26, true);
            WriteLiteral("<!-- / container -->\r\n    ");
            EndContext();
            BeginContext(904, 32, false);
#line 27 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Home\Index.cshtml"
Write(Html.Partial("_products", Model));

#line default
#line hidden
            EndContext();
            BeginContext(936, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(16631, 95, true);
            WriteLiteral("<!-- / container -->\r\n</section>\r\n<!-- / gallery -->\r\n\r\n<div class=\"spacer-2x\">&nbsp;</div>\r\n\r\n");
            EndContext();
            BeginContext(20424, 20, true);
            WriteLiteral("<!-- / clients -->\r\n");
            EndContext();
            BeginContext(22898, 45, true);
            WriteLiteral("\r\n\r\n\r\n<!-- modals -->\r\n<!-- login-modal -->\r\n");
            EndContext();
            BeginContext(27399, 53, true);
            WriteLiteral("\r\n<!-- / register-modal -->\r\n<!-- product-modal -->\r\n");
            EndContext();
            BeginContext(33620, 68, true);
            WriteLiteral("<!-- / modal -->\r\n<!-- / product-modal -->\r\n<!-- product-modal -->\r\n");
            EndContext();
            BeginContext(39641, 68, true);
            WriteLiteral("<!-- / modal -->\r\n<!-- / product-modal -->\r\n<!-- product-modal -->\r\n");
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

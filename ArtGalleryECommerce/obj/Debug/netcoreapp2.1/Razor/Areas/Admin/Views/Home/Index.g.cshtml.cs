#pragma checksum "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5e10e637ded088df76cd1bdc531a2d8dcfabfcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Home/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5e10e637ded088df76cd1bdc531a2d8dcfabfcc", @"/Areas/Admin/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c0219a74f243984f83661aa7647ee1c1eabde7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtGalleryECommerce.Models.ViewModels.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(165, 477, true);
            WriteLiteral(@"


<div class=""container-fluid"">
    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
        <a href=""#"" class=""d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm""><i class=""fas fa-download fa-sm text-white-50""></i> Generate Report</a>
    </div>
    <!-- Content Row -->
    <div class=""row"">
        <!-- Earnings (Monthly) Card Example -->
        ");
            EndContext();
            BeginContext(643, 45, false);
#line 19 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("OrderDashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(688, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1594, 50, true);
            WriteLiteral("        <!-- Earnings (Monthly) Card Example -->\r\n");
            EndContext();
            BeginContext(2426, 50, true);
            WriteLiteral("        <!-- Earnings (Monthly) Card Example -->\r\n");
            EndContext();
            BeginContext(3849, 56, true);
            WriteLiteral("        <!-- Pending Requests Card Example -->\r\n        ");
            EndContext();
            BeginContext(3906, 47, false);
#line 77 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("ProductDashboard"));

#line default
#line hidden
            EndContext();
            BeginContext(3953, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4727, 48, true);
            WriteLiteral("        <!-- Pending Requests Card Example -->\r\n");
            EndContext();
            BeginContext(5547, 18, true);
            WriteLiteral("    </div>\r\n</div>");
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
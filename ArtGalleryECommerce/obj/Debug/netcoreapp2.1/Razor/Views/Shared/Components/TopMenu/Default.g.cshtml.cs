#pragma checksum "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Shared\Components\TopMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51a9711ccbf49059094c00a5ff000ed365be42b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TopMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TopMenu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_TopMenu_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51a9711ccbf49059094c00a5ff000ed365be42b6", @"/Views/Shared/Components/TopMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad8b67bebeeab46657edd661839e54afb277593a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TopMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserArea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-userId", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 686, true);
            WriteLiteral(@"

<div id=""preloader"" style=""display: none;"">
    <div class=""preloader"">
        <span></span>
        <span></span>
    </div>
</div>

<div class=""top-menu top-menu-primary"">
    <div class=""container"">
        <p>
            <span class=""social margin-fix left"">
                <a class=""no-margin"" href=""#""><i class=""fab fa-facebook-f""></i></a>
                <a href=""#""><i class=""fab fa-twitter""></i></a>
                <a href=""#""><i class=""fab fa-google-plus-g""></i></a>
                <a href=""#""><i class=""fab fa-instagram""></i></a>
                <a href=""#""><i class=""fab fa-pinterest""></i></a>
            </span>
            <span class=""right"">
");
            EndContext();
#line 21 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Shared\Components\TopMenu\Default.cshtml"
                 if (String.IsNullOrEmpty(User.Identity.Name))
                {

#line default
#line hidden
            BeginContext(769, 280, true);
            WriteLiteral(@"                    <a href=""#x"" data-toggle=""modal"" data-target="".login-modal""><i class=""fas fa-user mr-1""></i> <span>Login</span></a>
                    <a href=""#x"" data-toggle=""modal"" data-target="".register-modal""><i class=""fas fa-lock mr-1""></i> <span>Register</span></a>
");
            EndContext();
#line 25 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Shared\Components\TopMenu\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(1068, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 26 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Shared\Components\TopMenu\Default.cshtml"
                 if (!String.IsNullOrEmpty(User.Identity.Name))
                {


#line default
#line hidden
            BeginContext(1154, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1174, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40be0f211106425ca2e639b09911cfd2", async() => {
                BeginContext(1244, 39, true);
                WriteLiteral("<i class=\"fas fa-user mr-1\"></i> <span>");
                EndContext();
                BeginContext(1284, 32, false);
#line 29 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Shared\Components\TopMenu\Default.cshtml"
                                                                                                                            Write(User.Identity.Name.Split(';')[0]);

#line default
#line hidden
                EndContext();
                BeginContext(1316, 7, true);
                WriteLiteral("</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1327, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1349, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "071422b54c684189b8129fa5097d29b8", async() => {
                BeginContext(1397, 52, true);
                WriteLiteral("<i class=\"fas fa-lock mr-1\"></i> <span>Logout</span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1453, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Views\Shared\Components\TopMenu\Default.cshtml"
                   
                }

#line default
#line hidden
            BeginContext(2105, 94, true);
            WriteLiteral("\r\n            </span>\r\n        </p>\r\n    </div><!-- / container -->\r\n</div><!-- / top-menu -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

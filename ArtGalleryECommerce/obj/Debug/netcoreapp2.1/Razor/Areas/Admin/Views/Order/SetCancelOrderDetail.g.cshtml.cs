#pragma checksum "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38edd747950701673f216d5a03d45181960b01ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Order_SetCancelOrderDetail), @"mvc.1.0.view", @"/Areas/Admin/Views/Order/SetCancelOrderDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Order/SetCancelOrderDetail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Order_SetCancelOrderDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38edd747950701673f216d5a03d45181960b01ad", @"/Areas/Admin/Views/Order/SetCancelOrderDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c0219a74f243984f83661aa7647ee1c1eabde7", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Order_SetCancelOrderDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ArtGalleryECommerce.Models.ViewModels.OrderProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetCancelOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetCancelOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
  
    ViewData["Title"] = "SetCancelOrderDetail";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(185, 167, true);
            WriteLiteral("\r\n\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>OrderProductViewModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(353, 47, false);
#line 16 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(400, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(444, 43, false);
#line 19 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(531, 41, false);
#line 22 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(572, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(616, 37, false);
#line 25 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(653, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(697, 41, false);
#line 28 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(738, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(782, 37, false);
#line 31 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(819, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(863, 42, false);
#line 34 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(905, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(949, 38, false);
#line 37 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(987, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1031, 42, false);
#line 40 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.CartID));

#line default
#line hidden
            EndContext();
            BeginContext(1073, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1117, 38, false);
#line 43 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.CartID));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1199, 44, false);
#line 46 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1287, 40, false);
#line 49 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ShipName));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1371, 47, false);
#line 52 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipSurname));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1462, 43, false);
#line 55 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ShipSurname));

#line default
#line hidden
            EndContext();
            BeginContext(1505, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1549, 45, false);
#line 58 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1594, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1638, 41, false);
#line 61 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ShipPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1679, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1723, 45, false);
#line 64 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipEMail));

#line default
#line hidden
            EndContext();
            BeginContext(1768, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1812, 41, false);
#line 67 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ShipEMail));

#line default
#line hidden
            EndContext();
            BeginContext(1853, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1897, 47, false);
#line 70 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(1944, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1988, 43, false);
#line 73 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ShipAddress));

#line default
#line hidden
            EndContext();
            BeginContext(2031, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2075, 46, false);
#line 76 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2165, 42, false);
#line 79 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2207, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2251, 45, false);
#line 82 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2296, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2340, 41, false);
#line 85 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(2381, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2425, 43, false);
#line 88 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2468, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2512, 39, false);
#line 91 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.Message));

#line default
#line hidden
            EndContext();
            BeginContext(2551, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2595, 46, false);
#line 94 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderState));

#line default
#line hidden
            EndContext();
            BeginContext(2641, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2685, 42, false);
#line 97 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.OrderState));

#line default
#line hidden
            EndContext();
            BeginContext(2727, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2771, 43, false);
#line 100 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(2814, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2858, 39, false);
#line 103 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(2897, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2941, 45, false);
#line 106 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(2986, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3030, 41, false);
#line 109 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.ProductID));

#line default
#line hidden
            EndContext();
            BeginContext(3071, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(3115, 48, false);
#line 112 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(3163, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(3207, 44, false);
#line 115 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
       Write(Html.DisplayFor(model => model.CreationDate));

#line default
#line hidden
            EndContext();
            BeginContext(3251, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3289, 284, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b90095c4f8054abaac44dcacb7fe5262", async() => {
                BeginContext(3329, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3339, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "246b90ba43134cfbb94743c2457e9657", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 120 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3375, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3385, 125, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa8ba02f225f43ac9714a2cdc5267dd5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 121 "C:\Users\Section2\Desktop\ArtGalleryECommerce\ArtGalleryECommerce\Areas\Admin\Views\Order\SetCancelOrderDetail.cshtml"
                                                                WriteLiteral(Model.OrderID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-orderId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["orderId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3510, 12, true);
                WriteLiteral(" |\r\n        ");
                EndContext();
                BeginContext(3522, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71ee93f8332948f6bc0506820296479f", async() => {
                    BeginContext(3544, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3560, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3573, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtGalleryECommerce.Models.ViewModels.OrderProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

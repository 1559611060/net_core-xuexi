#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\core_start\Views\Shared\Components\CompanySummary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "741932ab7e404a907b48c0a0ee7a0bb8305df143"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CompanySummary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CompanySummary/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"741932ab7e404a907b48c0a0ee7a0bb8305df143", @"/Views/Shared/Components/CompanySummary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b2dbaeb09e79df0c43de938bf900b528238223", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CompanySummary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<core_start.Models.CompanySummary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"small\">\r\n        <div class=\"row h6\"> Component 功能使用实例</div>\r\n        <div class=\"row h6\"> ");
#nullable restore
#line 5 "E:\我的资料\net_core学习demo\net_core-start\core_start\Views\Shared\Components\CompanySummary\Default.cshtml"
                        Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">员工总数:</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 8 "E:\我的资料\net_core学习demo\net_core-start\core_start\Views\Shared\Components\CompanySummary\Default.cshtml"
                             Write(Model.EmpoyeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">部门平均人数:</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 12 "E:\我的资料\net_core学习demo\net_core-start\core_start\Views\Shared\Components\CompanySummary\Default.cshtml"
                             Write(Model.AverageDepartmentEmployeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<core_start.Models.CompanySummary> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\RazorPages\Pages\Shared\Components\MyTest\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e3cf55339238150522579e046793145b1cd7785"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPages.Pages.Shared.Components.MyTest.Pages_Shared_Components_MyTest_Default), @"mvc.1.0.view", @"/Pages/Shared/Components/MyTest/Default.cshtml")]
namespace RazorPages.Pages.Shared.Components.MyTest
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
#line 1 "E:\我的资料\net_core学习demo\net_core-start\RazorPages\Pages\_ViewImports.cshtml"
using RazorPages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e3cf55339238150522579e046793145b1cd7785", @"/Pages/Shared/Components/MyTest/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d30f1f79eecd497650beb04c1b5dcb424643536", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_MyTest_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RazorPages.Models.CompanySummary>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"small\">\r\n        <div class=\"row h6\"> Component 功能使用实例2</div>\r\n        <div class=\"row h6\"> ");
#nullable restore
#line 5 "E:\我的资料\net_core学习demo\net_core-start\RazorPages\Pages\Shared\Components\MyTest\Default.cshtml"
                        Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">员工总数:</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 8 "E:\我的资料\net_core学习demo\net_core-start\RazorPages\Pages\Shared\Components\MyTest\Default.cshtml"
                             Write(Model.EmpoyeeCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\">部门平均人数:</div>\r\n            <div class=\"col-md-4\">");
#nullable restore
#line 12 "E:\我的资料\net_core学习demo\net_core-start\RazorPages\Pages\Shared\Components\MyTest\Default.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPages.Models.CompanySummary> Html { get; private set; }
    }
}
#pragma warning restore 1591
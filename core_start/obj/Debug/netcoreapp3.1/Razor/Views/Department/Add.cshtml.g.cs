#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\core_start\Views\Department\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e5e127a0f4736411ca79f072fbb7fb5b88c393d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Add), @"mvc.1.0.view", @"/Views/Department/Add.cshtml")]
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
#line 1 "E:\我的资料\net_core学习demo\net_core-start\core_start\Views\Department\Add.cshtml"
using core_start.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5e127a0f4736411ca79f072fbb7fb5b88c393d", @"/Views/Department/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7986cf81afda83fb9f1a732f910f473bfda6231e", @"/Views/_ViewImports.cshtml")]
    public class Views_Department_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Department>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<form asp-action=""Add"">
    <div class=""row form-group"">
        <div class=""col-md-2 offset-md-2"">
            <label asp-for=""Name""></label>
        </div>
        <div class=""col-md-6"">
            <input class=""form-control"" asp-for=""Name"" />
        </div>
    </div>
    <div class=""row form-group"">
        <div class=""col-md-2 offset-md-2"">
            <label asp-for=""Location""></label>
        </div>
        <div class=""col-md-6"">
            <input class=""form-control"" asp-for=""Location"" />
        </div>
    </div>
    <div class=""row form-group"">
        <div class=""col-md-2 offset-md-2"">
            <label asp-for=""EmployeeCount""></label>
        </div>
        <div class=""col-md-6"">
            <input class=""form-control"" asp-for=""EmployeeCount"" />
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-2 offset-md-2"">
            <button type=""submit"" class=""btn btn-primary"">提交</button>
        </div>
    </div>
</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Department> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0ad65c35525913d0a864086a01a30f1048e71d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using BlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\_Imports.razor"
using BlazorApp2.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
using GRpcApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
using BlazorApp2.Service;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
 if (_departments == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.AddMarkupContent(1, "<p>\r\n        <em>加载中</em>\r\n    </p>\r\n");
#nullable restore
#line 13 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-10 offset-md-2");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "table");
            __builder.AddAttribute(10, "class", "table");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<tr>\r\n                    <th>名称</th>\r\n                    <th>地址</th>\r\n                    <th>人数</th>\r\n                    <th>操作</th>\r\n                </tr>\r\n");
#nullable restore
#line 25 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
                 foreach (var item in _departments)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "                    ");
            __builder.OpenComponent<BlazorApp2.Components.DepatmentItem>(14);
            __builder.AddAttribute(15, "department", 
#nullable restore
#line 27 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
                                                item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 28 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.AddContent(21, "    ");
            __builder.AddMarkupContent(22, "<div class=\"row\">\r\n\r\n        <div class=\"col-md-4 offset-md-2\">\r\n            <a href=\"/Add-Department\">添加</a>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 39 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor"
      
    IEnumerable<Department> _departments;
    //页面第一次初始化执行
    protected override async Task OnInitializedAsync()
    {
        _departments = await DepartmentSevice.GetAll();
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDepartmentSevice DepartmentSevice { get; set; }
    }
}
#pragma warning restore 1591

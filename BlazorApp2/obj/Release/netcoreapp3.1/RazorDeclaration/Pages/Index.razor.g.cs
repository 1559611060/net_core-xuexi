#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e0ad65c35525913d0a864086a01a30f1048e71d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
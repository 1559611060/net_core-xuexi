#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "884215d77d8d0dd308defdc2e026f506d3dcbede"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using BlazorApp1.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using BlazorApp1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\_Imports.razor"
using BlazorApp1.Components;

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
#line 41 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp1\Pages\Index.razor"
      
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

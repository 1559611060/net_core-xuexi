#pragma checksum "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b15bbad5fcfdf39eb8c82734d5a9a36424b5de"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp2.Components
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
#line 1 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
using GRpcApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
using BlazorApp2.Service;

#line default
#line hidden
#nullable disable
    public partial class EmployeeItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddContent(3, 
#nullable restore
#line 6 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
         employee.FristName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "td");
            __builder.AddContent(6, 
#nullable restore
#line 7 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
         employee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 8 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
         employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 9 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
          employee.Fired?"是":""

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "td");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 11 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
         if (!employee.Fired)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "            ");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "javascript:void(0)");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
                                                   HandleFire

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n                开除\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#nullable restore
#line 16 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "E:\我的资料\net_core学习demo\net_core-start\BlazorApp2\Components\EmployeeItem.razor"
       
    [Parameter]
    public Employee employee { get; set; }

    private async void HandleFire()
    {
        var em = await employeeService.Frie(employee.Id);
        //navigationManager.NavigateTo("/Employee/"+employee.DepartmentId);

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmpyloyeeService employeeService { get; set; }
    }
}
#pragma warning restore 1591

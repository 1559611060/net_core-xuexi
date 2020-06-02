using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorApp2.Service;
using Microsoft.AspNetCore.Components;

namespace BlazorApp2.Pages
{
    public class EmployeeViewModel:ComponentBase
    {
        /// <summary>
        /// [Parameter]:特性，可以使DepartmentId在前台页面与某个标签双向绑定
        /// </summary>
        [Parameter]
        public string DepartmentId { get; set; }

        public IEnumerable<GRpcApi.Employee> Employees;

        [Inject]
        protected IEmpyloyeeService empyloyeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await empyloyeeService.GetByDepartmentId( int.Parse(DepartmentId));
        }
    }
}

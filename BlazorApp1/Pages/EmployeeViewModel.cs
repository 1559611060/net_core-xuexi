using BlazorApp1.Service;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Pages
{
    public class EmployeeViewModel:ComponentBase
    {
        /// <summary>
        /// [Parameter]:特性，可以使DepartmentId在前台页面与某个标签双向绑定
        /// </summary>
        [Parameter]
        public string DepartmentId { get; set; }

        public IEnumerable<BlazorApp1.Models.Employee> Employees;

        [Inject]
        protected IEmpyloyeeService empyloyeeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Employees = await empyloyeeService.GetByDepartmentId( int.Parse(DepartmentId));
        }
    }
}

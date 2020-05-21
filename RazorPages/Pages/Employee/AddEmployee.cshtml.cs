using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Service;

namespace RazorPages.Pages.Employee
{
    public class AddEmployeeModel : PageModel
    {
        private readonly IEmpyloyeeService _empyloyeeService;

        [BindProperty]
        public RazorPages.Models.Employee Employee { get; set; }

        public AddEmployeeModel(IEmpyloyeeService empyloyeeService) {
            _empyloyeeService = empyloyeeService;
        }
        public async Task<IActionResult> OnPostAsync(int departmentId) {
            Employee.DepartmentId = departmentId;
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _empyloyeeService.Add(Employee);
            return RedirectToPage("EmployeeList",routeValues:new { departmentId});
        }

        public void OnGet()
        {
        }
    }
}

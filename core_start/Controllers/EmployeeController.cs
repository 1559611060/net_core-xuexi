using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using core_start.Models;
using core_start.Service;
namespace core_start.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDepartmentSevice _departmentSevice;
        private readonly IEmpyloyeeService _empyloyeeService;
        public EmployeeController(IDepartmentSevice departmentSevice, IEmpyloyeeService empyloyeeService)
        {
            _departmentSevice = departmentSevice;
            _empyloyeeService = empyloyeeService;
        }

        /// <summary>
        /// 列出某个部门下的员工
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(int departmentId)
        {
            var department = await _departmentSevice.GetById(departmentId);
            ViewBag.Title = $"部门:{department.Name}";
            ViewBag.DepartmentId = departmentId;
            var employees = await _empyloyeeService.GetByDepartmentId(departmentId);
            return View(employees);
        }
        /// <summary>
        /// 添加员工页
        /// </summary>
        /// <param name="departmentID"></param>
        /// <returns></returns>
        public IActionResult Add(int departmentID)
        {

            ViewBag.Title = "添加员工";
            return View(new Employee
            {
                DepartmentId = departmentID
            });
        }
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add(Employee model) {
            //判断model是否合法
            if (ModelState.IsValid)
            {
                await _empyloyeeService.Add(model);
            }
            return RedirectToAction(nameof(Index),routeValues:new { departmentId=model.DepartmentId });
        }
        /// <summary>
        /// 开除员工
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        /// 
        //[HttpPost]
        public async Task<IActionResult> Fire(int employeeId) {
            var employee = await _empyloyeeService.Frie(employeeId);
            return RedirectToAction(nameof(Index),routeValues:new { departmentId = employee.DepartmentId });
        }
    }
}

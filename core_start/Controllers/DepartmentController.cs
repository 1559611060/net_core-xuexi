using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_start.Service;
using core_start.Models;
namespace core_start.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentSevice _departmentSevice;
        public DepartmentController(IDepartmentSevice departmentSevice)
        {
            _departmentSevice = departmentSevice;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "部门首页";
            var department =await _departmentSevice.GetAll();
            return View(department);
        }

        //[HttpGet]
        public IActionResult Add()
        {
            ViewBag.Title = "添加部门";
            return View(new Department());
        }
        [HttpPost]
        public async Task<IActionResult> Add(Department model)
        {
            //判断model是否合法
            if (ModelState.IsValid)
            {
                await _departmentSevice.Add(model);
            }
            return RedirectToAction(nameof(Index));//添加完成 跳转到index页面
        }

    }
}

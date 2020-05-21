using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Service;

namespace RazorPages.Pages.Department
{
    public class AddDepartmentModel : PageModel
    {
        private readonly IDepartmentSevice _departmentSevice;

        //特性属性绑定
        [BindProperty]
        public RazorPages.Models.Department Department { get; set; }

        public AddDepartmentModel(IDepartmentSevice departmentSevice)
        {
            _departmentSevice = departmentSevice;
        }

        public async Task<IActionResult> OnPostAsync() {
            //验证model是否合法
            if (!ModelState.IsValid)
            {
                return Page();//不合法返回当前页面
            }
            await _departmentSevice.Add(Department);//添加数据
            return RedirectToPage("/Index");//返回根目录下的index页面，不加'/'返回当前目录下的index
        }

        public void OnGet()
        {
        }

    }
}

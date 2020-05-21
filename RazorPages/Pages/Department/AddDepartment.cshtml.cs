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

        //�������԰�
        [BindProperty]
        public RazorPages.Models.Department Department { get; set; }

        public AddDepartmentModel(IDepartmentSevice departmentSevice)
        {
            _departmentSevice = departmentSevice;
        }

        public async Task<IActionResult> OnPostAsync() {
            //��֤model�Ƿ�Ϸ�
            if (!ModelState.IsValid)
            {
                return Page();//���Ϸ����ص�ǰҳ��
            }
            await _departmentSevice.Add(Department);//�������
            return RedirectToPage("/Index");//���ظ�Ŀ¼�µ�indexҳ�棬����'/'���ص�ǰĿ¼�µ�index
        }

        public void OnGet()
        {
        }

    }
}

using core_start.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_start.ViewComponents
{
    public class CompanySummaryViewComponent : ViewComponent
    {
        private readonly IDepartmentSevice _departmentSevice;

        public CompanySummaryViewComponent(IDepartmentSevice departmentSevice)
        {
            _departmentSevice = departmentSevice;
        }
        public async Task<IViewComponentResult> InvokeAsync(string title)
        {
            ViewBag.Title = title;
            var summary = await _departmentSevice.GetCompanySummary();
            return View(summary);
        }
    }
}

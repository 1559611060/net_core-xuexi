using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages.Models
{
    public class CompanySummary
    {
        public int EmpoyeeCount { get; set; }//员工总数
        public int AverageDepartmentEmployeeCount { get; set; }//每个部门评价的 员工数量
    }
}

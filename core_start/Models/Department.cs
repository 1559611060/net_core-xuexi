using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core_start.Models
{
    //部门类
    public class Department
    {
        public int Id { get; set; }
        [Display(Name="部门名称")]
        public string Name { get; set; }
        [Display(Name ="地点")]
        public string Location { get; set; }//地点
        [Display(Name = "员工数量")]
        public int EmployeeCount { get; set; }//员工数量
    }
}

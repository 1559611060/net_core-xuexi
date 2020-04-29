using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_start.Models
{
    //部门类
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }//地点
        public int EmployeeCount { get; set; }//员工数量
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_start.Models;
namespace core_start.Service
{
    public  interface IDepartmentSevice
    {
        //获取所有部门
        Task<IEnumerable<Department>> GetAll();
        // 根据部门ID查询部门
        Task<Department> GetById(int id);
        // 部门总人数、平均人数统计
        Task<CompanySummary> GetCompanySummary();
        // 添加部门
        Task Add(Department department);
    }
}

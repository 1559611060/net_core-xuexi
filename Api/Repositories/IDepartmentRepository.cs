using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public  interface IDepartmentRepository
    {
        //获取所有部门
        Task<IEnumerable<Department>> GetAll();
        // 根据部门ID查询部门
        Task<Department> GetById(int id);
        
        // 添加部门
        Task<Department> Add(Department department);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using GRpcApi;

namespace BlazorApp2.Service
{
    public  interface IDepartmentSevice
    {
        //获取所有部门
        Task<IEnumerable<Department>> GetAll();
       
     
        // 添加部门
        Task Add(Department department);
    }
}

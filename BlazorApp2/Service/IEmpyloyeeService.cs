using System.Collections.Generic;
using System.Threading.Tasks;
using GRpcApi;

namespace BlazorApp2.Service
{
    public interface IEmpyloyeeService
    {
        //添加员工
        Task Add(Employee employee);
        //根据部门ID 查询所有员工
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        //开除员工
        Task<Employee> Frie(int id);
    }
}

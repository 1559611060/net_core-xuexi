using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public interface IEmpyloyeeRepository
    {
        //添加员工
        Task<Employee> Add(Employee employee);
        //根据部门ID 查询所有员工
        Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId);
        //开除员工
        Task<Employee> Frie(int id);

        Task<Employee> GetById(int id);
    }
}

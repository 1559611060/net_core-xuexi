using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRpcApi;

namespace BlazorApp2.Service
{
    public class EmployeeService : IEmpyloyeeService
    {
        private readonly Employees.EmployeesClient _client;


        public EmployeeService(Employees.EmployeesClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public async Task Add(Employee employee)
        {
            await _client.AddEmployeeAsync(
                new AddEmployeeRequest
                {
                    Employee = employee
                });
        }
        /// <summary>
        /// 开除员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Employee> Frie(int id)
        {
            var response = await _client.FireEmployeeAsync(
                new FireEmployeeRequest
                {
                    Id=id
                });
            return response.Employee;
        }
        /// <summary>
        /// 根据部门ID 查询所有员工
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            var response = await _client.GetByDepartmentIdAsync(
                new GetByDepartmentIdRequest
                {
                    DepartmentId = departmentId
                });
            return response.Smployees;
        }

    }
}

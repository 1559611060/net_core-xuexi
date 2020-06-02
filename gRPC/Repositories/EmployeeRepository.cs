using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRpcApi;

namespace gRPCdemo.Repositories
{
    public class EmployeeRepository : IEmpyloyeeRepository
    {

        private readonly List<Employee> _employees = new List<Employee>();
        /// <summary>
        /// 添加基本员工信息
        /// </summary>
        public EmployeeRepository()
        {
            //Task<IEnumerable<Department>> _departments = new DepatmentService().GetAll();
            //List<Department> dp = ;
            int _id = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _employees.Add(new Employee
                    {
                        Id = _id,
                        DepartmentId = i + 1,
                        Name = $"员工_{i + 1}_{j + 1}",
                        FristName = $"编号：{i + 1}_{j + 1}",
                        Gender = j % 2 == 0 ? Gender.Man : Gender.Woman
                    });
                    _id++;
                }
            }
        }
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Task<Employee> Add(Employee employee)
        {
            employee.Id = _employees.Max(x => x.Id) + 1;
            _employees.Add(employee);
            return Task.Run(()=>employee);

        }
        /// <summary>
        /// 开除员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Employee> Frie(int id)
        {
            return Task.Run(function: () =>
             {
                 var employee = _employees.FirstOrDefault(x => x.Id == id);
                 if (employee!=null)
                 {
                     employee.Fired = true;
                     return employee;
                 }
                 return employee;
             });
        }
        /// <summary>
        /// 根据部门ID 查询所有员工
        /// </summary>
        /// <param name="departmentId"></param>
        /// <returns></returns>
        public Task<IEnumerable<Employee>> GetByDepartmentId(int departmentId)
        {
            return Task.Run(function:()=>_employees.Where(x=>x.DepartmentId==departmentId));
        }
        /// <summary>
        /// 根据id获取人员
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Employee> GetById(int id)
        {
            return Task.Run(() => _employees.Where(x=>x.Id==id).FirstOrDefault());
        }
    }
}

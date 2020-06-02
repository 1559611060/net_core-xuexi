using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRpcApi;

namespace gRPCdemo.Repositories
{

    public class DepatmentRepository : IDepartmentRepository
    {
        private readonly List<Department> _departments = new List<Department>();//部门集合
        /// <summary>
        /// 部门集合基本数据添加
        /// </summary>
        public DepatmentRepository()
        {

            for (int i = 0; i < 3; i++)
            {
                _departments.Add(new Department()
                {
                    Id = i + 1,
                    Name = i == 0 ? "HR" : i == 1 ? "R&D" : i == 2 ? "Sales" : "部门_" + (i + 1),
                    EmployeeCount = i == 0 ? 16 : i == 1 ? 52 : i == 2 ? 200 : (i + 10),
                    Location = i == 0 ? "北京" : i == 1 ? "上海" : i == 2 ? "重庆" : "中国_" + (i + 1)
                });
            }
        }
        /// <summary>
        /// 获取所有部门信息
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Department>> GetAll()
        {
            return Task.Run(function: () => _departments.AsEnumerable());
        }
        /// <summary>
        /// 根据部门ID查询部门
        /// </summary>
        /// <param name="id">部门ID </param>
        /// <returns>部门信息</returns>
        public Task<Department> GetById(int id)
        {
            return Task.Run(function: () => _departments.FirstOrDefault(x => x.Id == id));
        }
       
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public Task<Department> Add(Department department) {
            department.Id = _departments.Max(x => x.Id) + 1;
            _departments.Add(department);
            return Task.Run(()=>department);
        }
    }
}

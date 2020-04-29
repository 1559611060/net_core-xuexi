using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_start.Models;
namespace core_start.Service
{

    public class DepatmentService : IDepartmentSevice
    {
        private readonly List<Department> _departments = new List<Department>();//部门集合
        /// <summary>
        /// 部门集合基本数据添加
        /// </summary>
        public DepatmentService()
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
        /// 部门总人数、平均人数统计
        /// </summary>
        /// <returns></returns>
        public Task<CompanySummary> GetCompanySummary()
        {
            return Task.Run(function: () =>
            {
                return new CompanySummary
                {
                    EmpoyeeCount = _departments.Sum(x => x.EmployeeCount),//所有部门总人数
                    AverageDepartmentEmployeeCount = (int)_departments.Average(x => x.EmployeeCount)//部门平均人数

                };
            });
        }
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public Task Add(Department department) {
            department.Id = _departments.Max(x => x.Id) + 1;
            _departments.Add(department);
            return Task.CompletedTask;
        }
    }
}

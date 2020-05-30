using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Repositories
{
    public class SummaryRepository:ISummaryRepository
    {
        private readonly IDepartmentRepository _departmentRepository;

        public  SummaryRepository(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        /// <summary>
        /// 部门总人数、平均人数统计
        /// </summary>
        /// <returns></returns>
        public Task<CompanySummary> GetCompanySummary()
        {
            return Task.Run(function: () =>
            {
                var all = _departmentRepository.GetAll().Result;
                return new CompanySummary
                {
                    EmpoyeeCount = all.Sum(x => x.EmployeeCount),//所有部门总人数
                    AverageDepartmentEmployeeCount = (int)all.Average(x => x.EmployeeCount)//部门平均人数

                };
            });
        }
    }
}

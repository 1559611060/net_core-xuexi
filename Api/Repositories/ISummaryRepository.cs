using Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Repositories
{
    public interface ISummaryRepository
    {
        // 部门总人数、平均人数统计
        Task<CompanySummary> GetCompanySummary();
    }
}

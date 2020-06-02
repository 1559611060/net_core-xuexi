using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Grpc.Core;
using GRpcApi;
using gRPCdemo.Repositories;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;

namespace gRPCdemo.gRPCService
{
    public class EmployeeService : Employees.EmployeesBase
    {
        private readonly IEmpyloyeeRepository _empyloyeeRepository;

        public EmployeeService(IEmpyloyeeRepository empyloyeeRepository)
        {
            _empyloyeeRepository = empyloyeeRepository;
        }
        public override async Task<GetByDepartmentIdRsponse> GetByDepartmentId(GetByDepartmentIdRequest request, ServerCallContext context)
        {
            var result = new GetByDepartmentIdRsponse();
            var empyloees = await _empyloyeeRepository.GetByDepartmentId(request.DepartmentId);
            result.Smployees.AddRange(empyloees);
            return result;
        }

        public override async Task<FireEmployeeRsponse> FireEmployee(FireEmployeeRequest request, ServerCallContext context)
        {
            
            var employee = await _empyloyeeRepository.Frie(request.Id);

            var result = new FireEmployeeRsponse
            {

                Employee=employee
            };

            return result;
        }

        public override async Task<AddEmployeeRsponse> AddEmployee(AddEmployeeRequest request, ServerCallContext context)
        {
            var employee = await _empyloyeeRepository.Add(request.Employee);
            var result = new AddEmployeeRsponse
            {
                Employee = employee
            };
            return result;
        }
    }
}

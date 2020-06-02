using Grpc.Core;
using GRpcApi;
using gRPCdemo.Repositories;
using Microsoft.AspNetCore.Http.Features;
using System.Threading.Tasks;


namespace gRPCdemo.gRPCService
{
    public class DepartmentService : Deparments.DeparmentsBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public override async Task<GetAllDepartmentsResponse> GetAll(GetAllDepartmentsRequest request, ServerCallContext context)
        {
            var result = new GetAllDepartmentsResponse();

            var departments = await _departmentRepository.GetAll();

            result.Deparments.AddRange(departments);

            return result;
        }

        public override async Task<AddDepartmentResponse> Add(AddDepatmentRequest request, ServerCallContext context)
        {
            var departmet = await _departmentRepository.Add(request.Deparment);
            var result = new AddDepartmentResponse
            {
                Deparment=departmet

            };
            return result;
        }
    }
}

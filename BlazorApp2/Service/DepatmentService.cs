using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GRpcApi;

namespace BlazorApp2.Service
{

    public class DepatmentService : IDepartmentSevice
    {
        private readonly Deparments.DeparmentsClient _client;


        public DepatmentService(Deparments.DeparmentsClient client)
        {
            _client = client;
        }
        /// <summary>
        /// 获取所有部门信息
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Department>> GetAll()
        {

            var response = await _client.GetAllAsync
            (new GetAllDepartmentsRequest());

            return response.Deparments;
        }
       
       
        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public async Task Add(Department department)
        {
            await _client.AddAsync(new AddDepatmentRequest { Deparment=department});
        }
    }
}

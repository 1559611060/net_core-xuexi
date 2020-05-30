using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    /// <summary>
    /// [Route("v1/[controller]")]:路由，v1指定版本
    /// [ApiController]：
    /// 1.Attribude 路由
    /// 2.对model自动验证
    /// 3.推断绑定源：[FromBody],[FromFrom],[FromRoute],[FromQuery],[FromHeader],[FromServices]
    /// eg:Add([FromBody]Department department),其中的[FromBody]不写也可以，会自动推断断绑源
    /// </summary>
    [Route("v1/[controller]")]
    [ApiController]
    public class DepartmentsController:ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        [HttpGet]// 默认的，可以不写  对应的路由路径：v1/Depatments  verb:GET
        //public async Task<IActionResult> GetAll()
        public async Task<ActionResult<IEnumerable<Department>>> GetAll()
        {
            var depatments = await _departmentRepository.GetAll();
            if (!depatments.Any())
            {
                return NoContent();
            }

            return Ok(depatments);

            //return new ObjectResult(depatments);
        }

        [HttpPost]//  v1/Depatments  verb:POST
        public async Task<ActionResult<Department>> Add([FromBody]Department department)
        {
            var added =   await _departmentRepository.Add(department);
            return Ok(added);
        }
    }
}

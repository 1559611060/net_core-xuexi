using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class EmployeesController:ControllerBase
    {
        private readonly IEmpyloyeeRepository _empyloyeeRepository;

        public EmployeesController(IEmpyloyeeRepository empyloyeeRepository)
        {
            _empyloyeeRepository = empyloyeeRepository;
        }

        [HttpGet("{departmentId}")]
        public async Task<IActionResult> GetByGepartmentId(int departmentId)
        {
            var employees = await _empyloyeeRepository.GetByDepartmentId(departmentId);
            if (!employees.Any())
            {
                return NoContent();
            }
            return Ok(employees);
        }

        [HttpGet("One/{id}",Name = "GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _empyloyeeRepository.GetById(id);
            return Ok(result);
            
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]Employee model)
        {
            var added = await _empyloyeeRepository.Add(model);
            return CreatedAtRoute("GetById",new {id=added.Id },added);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Fire(int id)
        {
            var result = await _empyloyeeRepository.Frie(id);
            if (result!=null)
            {
                return NoContent();
            }

            return NotFound();
        }


    }
}

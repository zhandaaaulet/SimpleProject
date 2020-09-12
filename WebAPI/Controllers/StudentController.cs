using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Repositories.Interfaces;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        [HttpGet("id/{id}")]
        public IActionResult GetStudentById(long id)
        {
            return Ok(_studentRepository.GetById(id));
        }

        [HttpGet("name/{name}")]
        public IActionResult GetStudentByName(string name)
        {
            var student = Ok(_studentRepository.GetStudentByName(name));
            if(student is null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}

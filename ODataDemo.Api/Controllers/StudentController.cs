using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using ODataDemo.Api.Models;
using ODataDemo.Api.Services;

namespace ODataDemo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studentService) =>
            this.studentService = studentService;

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Student>> GetAllStudents()
        {
            IQueryable<Student> retrievedStudents =
                this.studentService.RetrieveAllStudents();

            return Ok(retrievedStudents);
        }
    }
}

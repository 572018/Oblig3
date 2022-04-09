using Api;
using Microsoft.AspNetCore.Mvc;
using Oblig3.Services;

namespace Oblig3.Controllers
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //public StudentService _studentService;
        public dat154Context _context = new dat154Context();

        //public StudentController(dat154Context context)
        //{
        //    //_studentService = studentService;
        //    _context = context;
        //}

        // GET: api/<StudentController>
        [HttpGet]
        public ActionResult<Student> GetAllStudents()
        {
            var s = _context.Students.ToList();
            if(s == null)
            {
                return BadRequest();
            }
            return Ok(s);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

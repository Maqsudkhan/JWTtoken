using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendMessageEmail.API.Attributes;
using SendMessageEmail.Domain.Enum;

namespace SendMessageEmail.API.Controllers.AuthConroller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize]
    public class UsersConroller : ControllerBase
    {
/*        List<string> users = new List<string>()
        {
            "Student 1", "Student 2", "Student 3", "Student 4", "Student 5",
        };

        List<string> teachers = new List<string>()
        {
            "Teacher 1", "Teacher 2", "Teacher 3", "Teacher 4", "Teacher 5",
        };*/

        [HttpGet]
        [IdentityFilter(Permission.GetAllStudent)]
        public IActionResult GetStudents()
        {
            return Ok("Get boldi");
        }

        [HttpGet]
        [IdentityFilterAttribute(Permission.GetAllTeacher)]
        public IActionResult GetAllTeachers()
        {
            return Ok("Get boldi");
        }

        [HttpPost]
        [IdentityFilter(Permission.CreateStudent)]
        public IActionResult CreateStudents() 
        {
            return Ok("Create Bo'ldi");
        }

        [HttpDelete]
        [IdentityFilter(Permission.DeleteStudent)]
        public IActionResult DeleteStudents()
        {
            return Ok("Delete Boldi");
        }
        [HttpPut]
        [IdentityFilter(Permission.UpdateStudent)]
        public IActionResult UpdateStudents()
        {
            return Ok("Update Boldi");
        }
    }
} 

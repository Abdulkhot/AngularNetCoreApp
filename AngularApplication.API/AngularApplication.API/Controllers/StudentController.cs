using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<students>>> GetStudents()
        {
            return new List<students>
            {
                new students
                {
                    firstName = "Abdulhamid 1",
                    lastName = "Khot 1",
                    place = "Mumbai 1"
                }
            };
        }
    }
}

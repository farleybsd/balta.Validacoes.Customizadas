using Microsoft.AspNetCore.Mvc;
using Validaxion.Models;

namespace Validaxion.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("/")]
        public IActionResult Post([FromBody] CreateUserModel createUserModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}

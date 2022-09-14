using APITestUnitario.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITestUnitario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(User user)
        {
            var usuarioDB = new User();

            if (usuarioDB.Nome == user.Nome && 
                usuarioDB.Idade == user.Idade
                )
                return Ok();

            return BadRequest();

        }
    }
}

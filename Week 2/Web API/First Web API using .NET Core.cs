using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET Request Successful");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST Request Successful");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("PUT Request Successful");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETE Request Successful");
        }
    }
}
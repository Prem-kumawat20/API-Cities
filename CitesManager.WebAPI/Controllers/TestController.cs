using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CitesManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public String Method() 
        {
            return "hello";
        }
    }
}

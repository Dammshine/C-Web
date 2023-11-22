using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    // Light weight controller
    [ApiController]
    [Route("api/home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Index()
        {
            return "Hello World";
        }
    }
}

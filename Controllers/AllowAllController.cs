using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AllowAllController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Working okay";
        }
    }
}

using Base.Domain.Common;
using Microsoft.AspNetCore.Mvc;

namespace OSS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IProfileContext profileContext;

        public FileController(IProfileContext profileContext)
        {
            this.profileContext = profileContext;
        }
        public IActionResult Get()
        {
            return Ok("all files");
        }
    }
}
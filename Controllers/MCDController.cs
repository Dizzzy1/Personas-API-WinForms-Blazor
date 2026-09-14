using Microsoft.AspNetCore.Mvc;
using Personas.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Personas.Api.Services;

namespace Personas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MCDController : ControllerBase
    {
        private readonly McdService _mcdService;

        public MCDController(McdService mcdService)
        {
            _mcdService = mcdService;
        }

        [HttpGet]
        public IActionResult CalcularMcd(int dividendo, int divisor)
        {
            int resultado = _mcdService.CalcularMcd(dividendo, divisor);

            return Ok(resultado);
        }
    }
}
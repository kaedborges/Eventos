using Microsoft.AspNetCore.Mvc;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class EventoController : ControllerBase
{

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return Ok();
    }
}
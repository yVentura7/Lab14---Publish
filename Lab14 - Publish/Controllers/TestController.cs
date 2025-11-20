using Microsoft.AspNetCore.Mvc;

namespace Lab14___Publish.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string Get() => "Laboratorio 14 - ¡Funcionando en Render!";
    
    [HttpGet("health")]
    public string Health() => "OK";
    
    [HttpGet("info")]
    public object Info() => new { 
        proyecto = "Lab14 - Publish", 
        status = "Desplegado en Render",
        fecha = DateTime.Now
    };
}
//ultimo
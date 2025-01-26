using Microsoft.AspNetCore.Mvc;

namespace Orders.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Order Service";
    }
}

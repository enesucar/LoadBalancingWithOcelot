using Microsoft.AspNetCore.Mvc;

namespace Payments.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ValuesController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Payment API";
    }
}

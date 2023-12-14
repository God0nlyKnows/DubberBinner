using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

[ApiController]
public class AuthenticationController : ControllerBase
{
    [Route("/error")]
    public IActionResult Error()
    {
        var exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem();
    }

}
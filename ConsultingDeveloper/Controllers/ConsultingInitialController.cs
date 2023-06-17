using Microsoft.AspNetCore.Mvc;

namespace ConsultingDeveloper.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultingInitialController : ControllerBase
{

    private readonly ILogger<ConsultingInitialController> _logger;

    public ConsultingInitialController(ILogger<ConsultingInitialController> logger)
    {
        _logger = logger;
    }


    [HttpGet]
     [Route("Teste1")]
    public string Teste1([FromBody]Request req){
        return req.valor.ToString();
        
    }

}

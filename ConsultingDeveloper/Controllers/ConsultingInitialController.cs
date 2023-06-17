using ConsultingDeveloperModel;
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

    [HttpGet]
    [Route("Teste2")]
    public Response Teste2([FromBody]Request req){
        Response teste2 = new Response();
        teste2.Id = 0;
        teste2.Nome = "teste2";
        return teste2;
    }

}

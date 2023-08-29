using ConsultingDeveloperModel;
using Microsoft.AspNetCore.Mvc;

namespace ConsultingDeveloper.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultingInitialController : ControllerBase
{

    [HttpGet]
    [Route("euro-real")] 
    public ActionResult<string> EuroReal([FromBody] Euro euro)
    {
        return $"Resultado: {euro.ConverterEuroEmReal(euro.euro):C2}";
    }

}

using ConsultingDeveloperModel;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace ConsultingDeveloper.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConsultingInitialController : ControllerBase
{

    [HttpGet]
    [Route("euro-real")] 
    public ActionResult<string> EuroReal([FromBody] Euro euro)
    {
        var euroFormatado = euro.euro.ToString("C",new CultureInfo("fr-FR"));
        return $"{euroFormatado} Euros equivale em Reais a {euro.ConverterEuroEmReal(euro.euro):C2}";
    }

    [HttpGet]
    [Route("reajuste-salario")]
    public ActionResult<string> ReajusteSalario([FromBody] SalarioAtual salarioAtual)
    {
        return $"O valor do salário com reajuste é {salarioAtual.salarioReajustado(salarioAtual.Salario, salarioAtual.Reajuste):C2} reais.";
    }

}

using Microsoft.AspNetCore.Mvc;
using atividade1.Patterns;

namespace atividade1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var s1 = Singleton.GetInstancia();
            var s2 = Singleton.GetInstancia();

            string resultado = s1.Mensagem();

            if (s1 == s2)
            {
                resultado += " Mesma instância confirmada.";
            }

            return resultado;
        }
    }
}
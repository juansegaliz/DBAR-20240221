using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DBAR.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        public class OperationsBody 
        {
            public int Numero1 { get; set; }
            public int Numero2 { get; set; }
        }

        public class DefaultResponse 
        {
            public int Code { get; set; }
            public string Data { get; set; }
        } 

        [Route("Suma")]
        [HttpPost]
        public IActionResult Suma([FromBody] OperationsBody body)
        {
            int result = body.Numero1 + body.Numero2;

            DefaultResponse response = new DefaultResponse();

            response.Code = Ok().StatusCode;
            response.Data = result.ToString();

            return Ok(response);           
        }

        [Route("Resta")]
        [HttpPost]
        public IActionResult Resta([FromBody] OperationsBody body)
        {
            int result = body.Numero1 - body.Numero2;
            return Ok(result);
        }
    }
}

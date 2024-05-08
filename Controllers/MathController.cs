using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_CianiDiaco_WebAPI.Controllers
{
    public class MathController : Controller
    {

        [HttpGet("MultiploIntero")]

        public JsonResult MultiploIntero(int numero, int divisore)
        {
            string status_result = "OK";
            string message = "é un multiplo intero";
            if (numero == 0)
            {
                status_result = "KO";
            }
            else if (numero % divisore != 0)
            {
                message = "il numero inaserito non è un multiplo intero";
            }
            else
            {
                message = "é un multiplo intero";
            }
            return Json(new {output = message, status = status_result});
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

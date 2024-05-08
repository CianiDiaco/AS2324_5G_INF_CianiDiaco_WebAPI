using Microsoft.AspNetCore.Mvc;

namespace AS2324_5G_INF_CianiDiaco_WebAPI.Controllers
{
    public class MathController : Controller
    {

        [HttpGet("GetMultiploIntero")]

        public JsonResult GetMultiploIntero(int numero, int divisore)
        {
            string status_result = "OK";
            string message = "Errore";
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

        [HttpGet("GetPotenza")]

        public JsonResult GetPotenza(int b, int esponente)
        {
            string status_result = "OK";
            string message = "Errore";
            int res = b;
            int t = res;
            for (int i = esponente; i > 1; i--)
            {
                res = res * b;
            }
            if (res > t)
            { 
                message = "Potenza calcolata";
            }
            return Json(new {risultato = res, output = message, status = status_result });
        }

        [HttpGet("GetBisestile")]

        public JsonResult GetBisestile(int anno)
        {
            string status_result = "OK";
            string message = "Errore";

            if
        }

        [HttpGet("GetIpotenusa")]

        public JsonResult GetIpotenusa(double cateto1, double cateto2)
        {
            string status_result = "OK";
            string message = "Errore";
            double res = 0;

            if((cateto1 == 0) || (cateto2 == 0))
            {
                status_result = "KO";
                message = "Valore non calcolabile";
            }
            else
            {
                res = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
                message = "Valore calcolato";
                status_result = "OK";
            }
            return Json(new { ipotenusa = res, output = message, status = status_result });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

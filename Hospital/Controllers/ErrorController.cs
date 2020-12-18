using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class ErrorController : Controller
    {
        [Route("Error/{statusCode}")]
        public IActionResult HttpStatusCodeHan(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Извините, запрошенный Вами ресурс не был найден";
                    break;
            }

            return View("NotFound");
        }
    }
}
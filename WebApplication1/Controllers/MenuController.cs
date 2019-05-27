using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        /// <summary>
        /// Abrir Tela Index
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}

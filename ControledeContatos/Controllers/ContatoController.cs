using Microsoft.AspNetCore.Mvc;

namespace ControledeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

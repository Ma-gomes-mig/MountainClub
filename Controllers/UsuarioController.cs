using Microsoft.AspNetCore.Mvc;

namespace ProjetoSite1.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

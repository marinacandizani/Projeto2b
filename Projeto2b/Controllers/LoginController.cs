using Microsoft.AspNetCore.Mvc;
using Projeto2b.Repositório;

namespace Projeto2b.Controllers
{
    public class LoginController : Controller
    {
        // Declara uma variavel privada somente leitura 
        private readonly UsuarioRepositorio _usuarioRepositorio;

        // Construtor

        public LoginController (UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }













        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login (String email, String senha)
        {
            return View();
        }

        public IActionResult Cadastro ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}

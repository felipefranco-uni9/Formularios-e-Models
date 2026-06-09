using Microsoft.AspNetCore.Mvc;
using Formulario.Models;

namespace Formulario.Controllers
{
    public class AlunoController : Controller
    {

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                return View("Confirmacao", aluno);
            }
            return View(aluno);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Tec_Legal.Interfaces;

namespace Tec_Legal.Controllers
{
    public class MatchController : Controller
    {
        public readonly IPessoaRepository _pessoaRepository;
        public MatchController(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Buscar(string nome, string areaInteresse, string localizacao)
        {
            var matches = _pessoaRepository.BuscarMatch(areaInteresse, localizacao);
            return View("Index", matches);
        }

    }
}

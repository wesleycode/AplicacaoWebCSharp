using MeuApp.Database.Repositories.Interfaces;
using MeuApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MeuApp.Controllers
{
    public class LanchesController : Controller
    {

        private readonly ILancheRepository _lancheRepository;

        public LanchesController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Listar()
        {
            var lanches = _lancheRepository.GetLanches;
            return View(lanches);
        }

    }
}